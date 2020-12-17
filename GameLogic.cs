using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;


public class GameLogic {
    Random rand = new Random();
    static public List<Boat> possibleBoats = new List<Boat>{
        new Boat("Carrier", 5, Color.Red, 0),
        new Boat("Battleship", 4, Color.Blue, 1),
        new Boat("Cruiser", 3, Color.Yellow, 2),
        new Boat("Submarine", 3, Color.Aqua, 3),
        new Boat("Destroyer", 2, Color.DarkGreen, 4)
    };
    public enum Direction { Vertical, Horizontal };
    public enum GameTypes { AI, Local};
    public GameTypes gameType;
    public enum AILevels {None, Easy, Regular, Hard};
    public AILevels AILevel;

    public GameLogic(GameTypes type, AILevels Difficulty = AILevels.None) {
        // type 0 == AI, 1 == Local
        gameType = type;
        AILevel = Difficulty;
    }

    // function to set the possible boats, also checks if the boats go out of the board, and if 0 < boats.count < 9
    static public String[] setPossibleBoats(List<Boat> boats) {
        string[] response = { "", "" };

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
        var coords = new List<Coords>();

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

    // Boat class to store 
    public class Boat {
        public Boat(string Name, int Length, Color color_, int Index) {
            name = Name;
            length = Length;
            color = color_;
            index = Index;
            sections = new int[length];
            for (int i = 0; i < length; i++) {
                sections[i] = 1; // 1 = intact, 0 = hit
            }
        }

        public string name { get; set; }
        public int length { get; set; }
        public int index { get; set; }
        public Coords mainCoord { get; set; }
        public Color color { get; set; }
        public int[] sections { get; set; }
        // returns true if its destroyed, by looping over all the sections and checking if at least one is intact
        public bool destroyed {
            get {
                foreach (var section in sections) {
                    if (section == 1)
                        return false;
                }
                return true;
            }
        }
        public Direction direc { get; set; }
        // calculates the coords of the boat by looping by how many length there are,
        // and adding/subtracting the Coord depending on the direction
        public List<Coords> coords {
            get {
                var tempCoords = new List<Coords>();
                tempCoords.Add(mainCoord);
                for (int i = 1; i < length; i++) {
                    if (direc == Direction.Horizontal)
                        tempCoords.Add(new Coords(mainCoord.col + i, mainCoord.row));
                    else
                        tempCoords.Add(new Coords(mainCoord.col, mainCoord.row + i));

                }
                return tempCoords;
            }
        }
    }

    // AI player
    public class AI {

    }

    // coordinates structure base on the board, first comes the column then the row
    public struct Coords {
        public Coords(int Col, int Row) {
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

        public bool Equals(Coords other) {
            if (this.col == other.col && this.row == other.row) {
                return true;
            } else {
                return false;
            }
        }
    }
}