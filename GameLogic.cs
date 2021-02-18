using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

/*
 * Need to fix:
 * FIXED can shoot at the same place multiple times
 * FIXED AI logic cancels directions incorrectly
 * FIXED AI wins game when starting another game
 * FIXED error when placing large boats
 * FIXED error when AI starts game
 * 
 */

public class GameLogic {
    Random rand = new Random();
    // default boats;
    static public List<Boat> possibleBoats = new List<Boat>{
        new Boat("Carrier", 5, Color.Red, 0),
        new Boat("Battleship", 4, Color.Blue, 1),
        new Boat("Cruiser", 3, Color.Yellow, 2),
        new Boat("Submarine", 3, Color.Aqua, 3),
        new Boat("Destroyer", 2, Color.DarkGreen, 4)
    };


    public enum BoatDirections { Vertical, Horizontal };

    #region Game Logic Variables
    public enum GameTypes { AI, Local };
    public GameTypes gameType;
    public enum AILevels { None, Easy, Regular, Hard };
    public AILevels AILevel;
    public enum sendMessages { shotCoords, ok, none };
    public enum recieveMessages { won, lost, hit, miss, sunk, alreadyShot, badCoords, shotCoords, waiting, opponentHit, opponentMiss, opponentSunk };

    private sendMessages msgExpecting;
    private object msgData;

    // game loop tracking
    public enum GameLoop { RequestShot, CheckShot, CheckIfWon, SwitchPlayer };
    private GameLoop currEvent;
    private int currPlayer = -1; // 1, 2. Corresponds to the vars

    #endregion

    // the boards are in reference to what the other player is targeting
    #region boards
    private int[,] player1Board = new int[10, 10]; // -2 = empty, -1 = shot missed, 0->7 boat index
    private int[,] player2Board = new int[10, 10];
    private ref int[,] currPlayerBoard {
        get {
            if (currPlayer == 1)
                return ref player1Board;
            else
                return ref player2Board;
        }
    }
    private ref int[,] otherPlayerBoard {
        get {
            if (currPlayer == 2)
                return ref player1Board;
            else
                return ref player2Board;
        }
    }
    #endregion

    #region boats
    private List<Boat> player1Boats;
    private List<Boat> player2Boats = new List<Boat>(); // or AI
    private ref List<Boat> currPlayerBoats {
        get {
            if (currPlayer == 1)
                return ref player1Boats;
            else
                return ref player2Boats;
        }
    }
    private ref List<Boat> otherPlayerBoats {
        get {
            if (currPlayer == 2)
                return ref player1Boats;
            else
                return ref player2Boats;
        }
    }
    #endregion

    #region actions
    // actions used when game is going through its loop
    private Action<recieveMessages, object> player1RecieveAction;
    private Action<recieveMessages, object> player2RecieveAction;
    private ref Action<recieveMessages, object> currPlayerRecieveAction {
        get {
            if (currPlayer == 1)
                return ref player1RecieveAction;
            else
                return ref player2RecieveAction;
        }
    }
    private ref Action<recieveMessages, object> otherPlayerRecieveAction {
        get {
            if (currPlayer == 2)
                return ref player1RecieveAction;
            else
                return ref player2RecieveAction;
        }
    }
    #endregion

    #region AI logic Variables
    private int turnsUntilForceDefault;
    private int turnsUntilForce;
    private bool forceNextTurn = false;

    private enum Directions { N, E, S, W };
    private List<Directions> possibleDirections = new List<Directions>();
    private List<Directions> allDirections = new List<Directions> { Directions.N, Directions.E, Directions.S, Directions.W };
    private List<int> possibleLengths = new List<int>();
    private List<Coordinate> sectionsHit = new List<Coordinate>();

    // return all possible shots 
    private List<Coordinate> possibleShots {
        get {
            var tempShots = new List<Coordinate>();

            // if missed too many times on hard mode
            if (forceNextTurn) {
                var tempList = otherPlayerBoats.FindAll(x => x.destroyed == false).ToList();
                var randBoat = tempList[rand.Next(0, tempList.Count)];
                tempShots.Add(randBoat.coords[rand.Next(0, randBoat.coords.Count)]);
                return tempShots;
            }

            // return all of the coords which are empty if difficulty is easy or no sections have been hit
            if (sectionsHit.Count == 0 || AILevel == AILevels.Easy) {
                for (int i = 0; i < 10; i++) {
                    for (int j = 0; j < 10; j++) {
                        if (otherPlayerBoard[i, j] == -2) {
                            tempShots.Add(new Coordinate { col = i, row = j });
                        }
                    }
                }

            } else {
                var tempCoord = new Coordinate();
                // goes through all of the sections and possible directions
                foreach (var coord in sectionsHit) {
                    foreach (var dir in allDirections.ToList()) {
                        if (possibleDirections.Contains(dir)) {
                            var newDirections = new List<Directions>();
                            switch (dir) {
                                // set temp coord
                                case Directions.N:
                                    tempCoord.row = coord.row - 1;
                                    tempCoord.col = coord.col;
                                    break;
                                case Directions.E:
                                    tempCoord.row = coord.row;
                                    tempCoord.col = coord.col + 1;
                                    break;
                                case Directions.S:
                                    tempCoord.row = coord.row + 1;
                                    tempCoord.col = coord.col;
                                    break;
                                case Directions.W:
                                    tempCoord.row = coord.row;
                                    tempCoord.col = coord.col - 1;
                                    break;
                                default:
                                    break;
                            }

                            try {
                                // checks if the new temp coord is part of a new boat, if it is, skip it 
                                // (this is a quick fix to a big issue which would require a lot of change to the algorithm)
                                bool otherBoat = false;
                                foreach (var boat in otherPlayerBoats) {
                                    if (boat.index != otherPlayerBoard[coord.col, coord.row] && boat.coords.Contains(tempCoord)) {
                                        otherBoat = true;
                                        break;
                                    }
                                }
                                if (otherBoat)
                                    continue;

                                // checks if the tempcoord is not empty and it is not part of the ship, removes the directions if it is
                                if (otherPlayerBoard[tempCoord.col, tempCoord.row] != -2 && otherPlayerBoard[tempCoord.col, tempCoord.row] != otherPlayerBoard[coord.col, coord.row]) {
                                    possibleDirections.Remove(dir);
                                    // if the temp coord is empty or is the same ship it encountered last time, and the sections hasn't been hit yet, add it to the list
                                } else if ((otherPlayerBoard[tempCoord.col, tempCoord.row] == -2 || otherPlayerBoard[tempCoord.col, tempCoord.row] == otherPlayerBoard[coord.col, coord.row]) && !sectionsHit.Contains(tempCoord))
                                    tempShots.Add(tempCoord);
                            } catch {
                                // goes out of the board
                                possibleDirections.Remove(dir);
                            }
                        }
                    }
                }
            }

            return tempShots;
        }
    }

    #endregion

    public GameLogic(GameTypes type, AILevels Difficulty = AILevels.None) {
        // type 0 == AI, 1 == Local
        gameType = type;
        AILevel = Difficulty;
    }

    #region game setup
    // function to set the possible boats, also checks if the boats go out of the board, and if 0 < boats.count < 9
    static public String[] setPossibleBoats(List<Boat> boats) {
        string[] response = { "", "" };

        if (boats == null) {
            response[0] = "false";
            response[1] = $"No boats have been given";
            return response;
        }

        if (boats.Count == 0) {
            response[0] = "false";
            response[1] = $"There should be at least 1 boats";
            return response;
        }

        if (boats.Count > 8) {
            response[0] = "false";
            response[1] = $"There are too many boats, the maximum number of boats is 8";
            return response;
        }

        foreach (var boat in boats) {
            if (boat.length > 10) {
                response[0] = "false";
                response[1] = $"boat {boat.name} is too long, the maximum length is 10";
                return response;
            } else if (boat.length < 1) {
                response[0] = "false";
                response[1] = $"boat {boat.name} is too short, the minimum length is 1";
                return response;
            }
        }

        possibleBoats = boats;
        response[0] = "true";
        return response;
    }

    // function to add to boatsOnBoard
    static public bool addBoatCheck(Boat newBoat, List<Boat> prevBoats) {
        var coords = new List<Coordinate>();

        // get all of the coords from the existing boats to check later
        foreach (var boat in prevBoats) {
            coords.AddRange(boat.coords);
        }

        foreach (var coord in newBoat.coords) {
            // check if coordinates are out of bounds
            if (coord.col > 10 || coord.row > 10 || coord.col < 0 || coord.row < 0) {
                return false;
            }

            // check if boats overlap
            if (coords.Any(other => coord.Equals(other))) {
                return false;
            }
        }

        return true;
    }

    // save boats
    static public bool saveBoats(List<Boat> boatsToSave = null) {

        // serialise all the boats to json
        string jsonString;
        if (boatsToSave != null)
            jsonString = JsonConvert.SerializeObject(boatsToSave);
        else
            jsonString = JsonConvert.SerializeObject(possibleBoats);
        // save a file dialog to get path
        SaveFileDialog saveBoatsDialog = new SaveFileDialog();
        saveBoatsDialog.Filter = "Text File|*.txt";
        saveBoatsDialog.Title = "Save Current Boats to a File";
        saveBoatsDialog.ShowDialog();

        // check if file path is valid, and delete it if it already exists
        if (saveBoatsDialog.FileName != "") {

            if (File.Exists(saveBoatsDialog.FileName))
                File.Delete(saveBoatsDialog.FileName);

            // save the serialised string
            File.WriteAllText(saveBoatsDialog.FileName, jsonString);

            return true;

        }

        MessageBox.Show("Invalid file selected", "Error");
        return false;
    }

    // load boats
    static public bool loadBoats() {

        // open a file dialog to get path
        OpenFileDialog loadBoatsDialog = new OpenFileDialog();
        loadBoatsDialog.Filter = "Text File|*.txt";
        loadBoatsDialog.Title = "Load  Boats from a File";
        loadBoatsDialog.Multiselect = false;
        loadBoatsDialog.ShowDialog();

        if (loadBoatsDialog.FileName != "") {

            // open file and deserialise
            string jsonString = File.ReadAllText(loadBoatsDialog.FileName);
            List<Boat> boats = null;

            try {
                boats = JsonConvert.DeserializeObject<List<Boat>>(jsonString);
            } catch {
                var res = MessageBox.Show("The save file seems to be corrupted, do you want to delete it?", "error", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes) {
                    if (File.Exists(loadBoatsDialog.FileName))
                        File.Delete(loadBoatsDialog.FileName);
                }
                return false;
            }

            string[] response = setPossibleBoats(boats);

            // return response
            if (response[0] == "true") {
                return true;
            } else {
                MessageBox.Show(response[1], "Error");
                return false;
            }
        }

        MessageBox.Show("Invalid file selected", "Error");
        return false;
    }

    // class to store boat data
    public class Boat {
        public Boat(string Name, int Length, Color color_, int Index) {
            name = Name;
            length = Length;
            color = color_;
            index = Index;
            sections = new int[length];
            resetSections();
        }

        public string name { get; set; }
        public int length { get; set; }
        public int index { get; set; }
        public Coordinate mainCoord { get; set; }
        public Color color { get; set; }
        public int[] sections { get; set; }
        // returns true if its destroyed, by looping over all the sections and checking if at least one is intact
        public void resetSections() {
            for (int i = 0; i < length; i++) {
                sections[i] = 1; // 1 = intact, 0 = hit
            }
        }
        public bool destroyed {
            get {
                foreach (var section in sections) {
                    if (section == 1)
                        return false;
                }
                return true;
            }
        }
        public void removeSectionFromCoords(Coordinate coord) {
            // removes a section from the boat by calculating the difference from the main coord to the one given
            int colDif = coord.col - mainCoord.col;
            int rowDif = coord.row - mainCoord.row;
            sections[Math.Max(colDif, rowDif)] = 0;
        }
        public BoatDirections direc { get; set; }
        // calculates the coords of the boat by looping by how many sections there are,
        // and adding/subtracting the Coord depending on the direction
        public List<Coordinate> coords {
            get {
                var tempCoords = new List<Coordinate>();
                tempCoords.Add(mainCoord);
                for (int i = 1; i < length; i++) {
                    if (direc == BoatDirections.Horizontal)
                        tempCoords.Add(new Coordinate(mainCoord.col + i, mainCoord.row));
                    else
                        tempCoords.Add(new Coordinate(mainCoord.col, mainCoord.row + i));

                }
                return tempCoords;
            }
        }
    }

    // coordinates structure base on the board, first comes the column then the row

    public struct Coordinate {
        public Coordinate(int Col, int Row) {
            col = Col;
            row = Row;
        }

        public int col { get; set; }
        public int row { get; set; }
        // user friendly version
        public override string ToString() {
            string alpha = "ABCDEFGHIJ";
            return $"{alpha[col]}{row + 1}";
        }
        public bool Equals(Coordinate other) {
            if (this.col == other.col && this.row == other.row) {
                return true;
            } else {
                return false;
            }
        }
    }

    #endregion

    #region game loop

    // initialise the game, returns an action the player can call.
    public Action<sendMessages, object> startGame(List<Boat> Player1Boats, Action<recieveMessages, object> Player1RecieveAction, List<Boat> Player2Boats = null, Action<recieveMessages, object> Player2RecieveAction = null) {
        // setup the values and actions to call during the game loop
        player1Boats = Player1Boats;
        player1RecieveAction = Player1RecieveAction;

        if (gameType == GameTypes.AI) {
            setAIboats();
            player2RecieveAction = AIRecieveAction;
            possibleDirections = allDirections;
            sectionsHit.Clear();
            possibleLengths = possibleBoats.Select(x => x.length).ToList();
            if (AILevel != AILevels.None || AILevel != AILevels.Easy) {
                if (AILevel == AILevels.Hard) {
                    turnsUntilForceDefault = 5;
                    turnsUntilForce = turnsUntilForceDefault;
                }
            }
        } else {
            player2Boats = Player2Boats;
            player2RecieveAction = Player2RecieveAction;
        }

        // clear the boards
        for (int i = 0; i < 10; i++) {
            for (int y = 0; y < 10; y++) {
                player1Board[i, y] = -2;
                player2Board[i, y] = -2;
            }
        }

        // currPlayer = rand.Next(1,3);
        currPlayer = 2;

        // set the game loop
        currEvent = GameLoop.RequestShot;

        return SendGameloopAction;
    }

    public void StartGameLoop() {
        GameloopNext();
    }

    private void SendGameloopAction(sendMessages msg, object data) {
        if (msg == msgExpecting) {
            msgData = data;
            GameloopNext();
        }
    }

    private void GameloopNext() {
        switch (currEvent) {
            case GameLoop.RequestShot:
                msgExpecting = sendMessages.shotCoords;
                currEvent = GameLoop.CheckShot;
                otherPlayerRecieveAction(recieveMessages.waiting, null);
                currPlayerRecieveAction(recieveMessages.shotCoords, null);
                break;

            case GameLoop.CheckShot:
                //try {
                    Coordinate tempCoord = (Coordinate)msgData;
                    // check if the player already tried that spot7
                    if (otherPlayerBoard[tempCoord.col, tempCoord.row] != -2) {
                        currPlayerRecieveAction(recieveMessages.alreadyShot, null);
                        otherPlayerRecieveAction(recieveMessages.waiting, null);
                        currEvent = GameLoop.RequestShot;
                        msgExpecting = sendMessages.shotCoords;
                    } else {
                        // the shot is good, checks if it hit a boat
                        bool found = false;
                        int index = -1;
                        int boatIndex = -1;

                        // goes through all the coords of the enemy to check if the shot hit any boat
                        for (int i = 0; i < otherPlayerBoats.Count; i++) {
                            var boat = otherPlayerBoats[i];
                            foreach (var coord in boat.coords) {
                                if (coord.Equals(tempCoord)) {
                                    found = true;
                                    index = i;
                                    boatIndex = boat.index;
                                    break;
                                }
                            }
                            if (found)
                                break;
                        }

                        // remove a section from the boat, and report back with the results
                        if (found) {
                            otherPlayerBoard[tempCoord.col, tempCoord.row] = boatIndex;
                            otherPlayerBoats[index].removeSectionFromCoords(tempCoord);
                            if (otherPlayerBoats[index].destroyed) {
                                // shot sunk a boat
                                currPlayerRecieveAction(recieveMessages.sunk, tempCoord);
                                otherPlayerRecieveAction(recieveMessages.opponentSunk, tempCoord);
                            } else {
                                // shot hit but not sunk
                                currPlayerRecieveAction(recieveMessages.hit, tempCoord);
                                otherPlayerRecieveAction(recieveMessages.opponentHit, tempCoord);
                            }
                        } else {
                            // the shot missed
                            otherPlayerBoard[tempCoord.col, tempCoord.row] = -1;
                            currPlayerRecieveAction(recieveMessages.miss, tempCoord);
                            otherPlayerRecieveAction(recieveMessages.opponentMiss, tempCoord);
                        }

                        // go to next event
                        msgExpecting = sendMessages.ok;
                        currEvent = GameLoop.CheckIfWon;

                    }
                /*} 
                catch (Exception e) {
                    // bad coords
                    currPlayerRecieveAction(recieveMessages.badCoords, null);
                    otherPlayerRecieveAction(recieveMessages.waiting, null);
                    msgExpecting = sendMessages.shotCoords;
                    break;
                }*/

                GameloopNext();
                break;

            case GameLoop.CheckIfWon:
                bool won = true;
                // check if all of the enemy's boats are destroyed
                foreach (var boat in otherPlayerBoats) {
                    if (!boat.destroyed) {
                        won = false;
                        break;
                    }
                }

                if (won) {
                    currPlayerRecieveAction(recieveMessages.won, null);
                    otherPlayerRecieveAction(recieveMessages.lost, null);
                    break;
                }

                msgExpecting = sendMessages.ok;
                currEvent = GameLoop.SwitchPlayer;
                GameloopNext();

                break;

            case GameLoop.SwitchPlayer:
                if (currPlayer == 1)
                    currPlayer = 2;
                else
                    currPlayer = 1;

                currEvent = GameLoop.RequestShot;
                msgExpecting = sendMessages.shotCoords;

                GameloopNext();

                break;

            default:
                break;
        }
    }

    private void setAIboats() {

        // 6 tries
        bool boatPlaced = false;

        for (int i = 0; i < 6; i++) {
            player2Boats.Clear();

            foreach (var boat in possibleBoats) {
                int firstDirection = rand.Next(1, 3);
                int maxCol = -1; // index form
                int maxRow = -1;

                // in what order it tries to place the boats
                int[] directionTurns = { firstDirection, firstDirection == 2 ? 1 : 2 };

                boatPlaced = false;

                foreach (var direc in directionTurns) {

                    // vertical
                    if (direc == 1) {
                        maxCol = 9;
                        maxRow = (9 - boat.length) + 1;
                    } else { // horizontal
                        maxRow = 9;
                        maxCol = (9 - boat.length) + 1;
                    }

                    // creates a shuffled list of all possible places the boat starting place could be
                    var possiblePlaces = new List<int[]>();

                    for (int col = 0; col < maxCol + 1; col++) {
                        for (int row = 0; row < maxRow + 1; row++) {
                            possiblePlaces.Add(new int[] { col, row });
                        }
                    }

                    // https://improveandrepeat.com/2018/08/a-simple-way-to-shuffle-your-lists-in-c/
                    possiblePlaces = possiblePlaces.OrderBy(x => Guid.NewGuid()).ToList();

                    // tries all of the places until it finds a spot, if it doesn't find a spot, restart the loop
                    // if it still fails, place all boats in a generic spot

                    foreach (var place in possiblePlaces) {
                        Boat temp = new Boat(boat.name, boat.length, boat.color, boat.index);
                        temp.mainCoord = new Coordinate(place[0], place[1]);

                        if (direc == 1)
                            temp.direc = BoatDirections.Vertical;
                        else
                            temp.direc = BoatDirections.Horizontal;

                        if (addBoatCheck(temp, player2Boats)) {
                            player2Boats.Add(temp);
                            boatPlaced = true;
                            break;
                        }
                    }
                    // break out of directions
                    if (boatPlaced)
                        break;
                }

                // break out if a boat has not been placed
                if (!boatPlaced)
                    break;
            }

            // break out if all boats have been placed
            if (boatPlaced)
                break;
        }

        // break out if boats do not have to be set again in a standard way
        if (boatPlaced)
            return;

        player2Boats.Clear();

        for (int i = 0; i < possibleBoats.Count; i++) {
            Boat temp = new Boat(possibleBoats[i].name, possibleBoats[i].length, possibleBoats[i].color, possibleBoats[i].index);
            temp.mainCoord = new Coordinate(i, 0);
            temp.direc = BoatDirections.Vertical;
            player2Boats.Add(temp);
        }
    }

    // AI logic 
    private void AIRecieveAction(GameLogic.recieveMessages msg, object data) {
        switch (msg) {
            case recieveMessages.alreadyShot:
                goto case recieveMessages.shotCoords;
            case recieveMessages.badCoords:
                goto case recieveMessages.shotCoords;
            case recieveMessages.shotCoords:
                Coordinate coord = possibleShots[rand.Next(0, possibleShots.Count)];
                SendGameloopAction(sendMessages.shotCoords, coord);
                break;

            case recieveMessages.hit:
                if (AILevel != AILevels.Easy) {
                    var tempCoord = (Coordinate)data;
                    // remove possible directions where it was not shot
                    sectionsHit.Add(tempCoord);
                    if (sectionsHit.Count != 1) {
                        int colDiff = tempCoord.col - sectionsHit[0].col;
                        int rowDiff = tempCoord.row - sectionsHit[0].row;
                        if (colDiff == 0) {
                            possibleDirections.Remove(Directions.E);
                            possibleDirections.Remove(Directions.W);
                        } else if (rowDiff == 0) {
                            possibleDirections.Remove(Directions.N);
                            possibleDirections.Remove(Directions.S);
                        }
                    }
                    if (AILevel == AILevels.Hard) {
                        turnsUntilForce = turnsUntilForceDefault;
                        forceNextTurn = false;
                    }
                }
                break;

            case recieveMessages.miss:
                if (AILevel != AILevels.Easy) {
                    var tempCoord = (Coordinate)data;
                    // remove a possible directions if that is where it was shot
                    if (sectionsHit.Count != 0) {
                        int colDiff = tempCoord.col - sectionsHit.Last().col;
                        int rowDiff = tempCoord.row - sectionsHit.Last().row;
                        if (colDiff == -1) {
                            possibleDirections.Remove(Directions.W);
                        } else if (colDiff == 1) {
                            possibleDirections.Remove(Directions.E);
                        } else if (rowDiff == 1) {
                            possibleDirections.Remove(Directions.S);
                        } else if (rowDiff == -1) {
                            possibleDirections.Remove(Directions.N);
                        }
                    }
                    if (AILevel == AILevels.Hard) {
                        turnsUntilForce -= 1;
                        if (turnsUntilForce <= 0) {
                            forceNextTurn = true;
                        }
                    }
                }
                break;

            case recieveMessages.sunk:
                if (AILevel != AILevels.Easy) {
                    // reset values and remove the boat from possible ones
                    possibleLengths.Remove(sectionsHit.Count);
                    possibleDirections.Clear();
                    possibleDirections.AddRange(new List<Directions> { Directions.N, Directions.E, Directions.S, Directions.W });
                    sectionsHit.Clear();

                    if (AILevel == AILevels.Hard) {
                        turnsUntilForce = turnsUntilForceDefault;
                        forceNextTurn = false;
                    }
                }
                break;

            default:
                break;
        }
    }

    private bool GameStateSave() {
        return true;
    }

    private bool GameStateLoad() {
        return true;
    }

    #endregion

}
