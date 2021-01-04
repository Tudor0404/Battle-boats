using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Battle_boats {
    public partial class PlayForm : Form {
        private Label[,] playerTableLabels = new Label[10, 10];
        private Label[,] opponentTableLabels = new Label[10, 10];

        private DisplayBoard playerDisplay;
        private DisplayBoard opponentDisplay;

        private bool selectingShot = false;

        GameLogic game;
        private Action<GameLogic.sendMessages, object> sendGameLogic;

        private string playerName;
        private string opponentName;
        List<GameLogic.Boat> playerBoats;

        private GameLogic.GameTypes gameType;
        private GameLogic.AILevels AIDifficuly;

        public PlayForm(GameLogic.GameTypes Type, GameLogic.AILevels Difficuly, List<GameLogic.Boat> PlayerBoats, string Name_= "Player", string OpponentName = "AI") {
            InitializeComponent();
            gameType = Type;
            AIDifficuly = Difficuly;
            playerName = Name_;
            opponentName = OpponentName;
            playerBoats = PlayerBoats;

            // make listVIew look like a listBox
            logListView.Columns.Add("", -2);

            playerDisplay = new DisplayBoard(setPlayerBoard, setBoatsAfter: setupPlayerBoats);
            opponentDisplay = new DisplayBoard(setOpponentBoard,
                                               playTableLabel_MouseClick,
                                               playTableLabel_MouseEnter,
                                               playTableLabel_MouseLeave);
        }

        private void PlayForm_Load(object sender, EventArgs e) {
            setupValues();
        }

        private void setupValues() {
            playerDisplay.displayBoard();
            opponentDisplay.displayBoard();
            game = new GameLogic(gameType, AIDifficuly);

            if (game.gameType == GameLogic.GameTypes.AI)
                writeToLog($"Game started, {playerName} vs AI level {game.AILevel}");
            else
                writeToLog($"Local game started");

            sendGameLogic = game.startGame(playerBoats, RecieveGameResponse);
        }

        public void RecieveGameResponse(GameLogic.recieveMessages msg, object data = null) {
            switch (msg) {
                // do something depending on each event, most of them are self explanatory
                case GameLogic.recieveMessages.won:
                    writeToLog($"{playerName} won the game!");
                    MessageBox.Show($"You won the game against {opponentName}!","Congratulations!");
                    this.Close();
                    selectingShot = false;
                    break;

                case GameLogic.recieveMessages.lost:
                    writeToLog($"{opponentName} won the game!");
                    MessageBox.Show($"You lost the game against {opponentName}!", "Better luck next time");
                    this.Close();
                    selectingShot = false;
                    break;

                case GameLogic.recieveMessages.hit:
                    var tempCoord = (GameLogic.Coordinate)data;
                    opponentTableLabels[tempCoord.col, tempCoord.row].Text = "✕";
                    writeToLog($"{playerName} hit {opponentName}'s boat at {tempCoord}");
                    ChangeShotStatus("Shot hit!", 0);
                    selectingShot = false;
                    break;

                case GameLogic.recieveMessages.sunk:
                    tempCoord = (GameLogic.Coordinate)data;
                    opponentTableLabels[tempCoord.col, tempCoord.row].Text = "✕";
                    writeToLog($"{playerName} hit {opponentName}'s boat at {tempCoord}");
                    writeToLog($"{playerName} sank one of {opponentName}'s ships!");
                    ChangeShotStatus("Ship sunk!", 1);
                    selectingShot = false;
                    break;

                case GameLogic.recieveMessages.miss:
                    tempCoord = (GameLogic.Coordinate)data;
                    opponentTableLabels[tempCoord.col, tempCoord.row].Text = "○";
                    writeToLog($"{playerName} shot at {tempCoord} and missed");
                    ChangeShotStatus("Shot missed!", 2);
                    selectingShot = false;
                    break;

                case GameLogic.recieveMessages.opponentHit:
                    tempCoord = (GameLogic.Coordinate)data;
                    playerTableLabels[tempCoord.col, tempCoord.row].Text = "✕";
                    writeToLog($"{opponentName} hit {playerName}'s boat at {tempCoord}");
                    ChangeOpponentStatus("The opponent hit one of your boats!", 2);
                    selectingShot = false;
                    break;

                case GameLogic.recieveMessages.opponentMiss:
                    tempCoord = (GameLogic.Coordinate)data;
                    playerTableLabels[tempCoord.col, tempCoord.row].Text = "○";
                    writeToLog($"{opponentName} shot at {tempCoord} and missed");
                    ChangeOpponentStatus("The opponent missed his shot!", 0);
                    selectingShot = false;
                    break;

                case GameLogic.recieveMessages.opponentSunk:
                    tempCoord = (GameLogic.Coordinate)data;
                    playerTableLabels[tempCoord.col, tempCoord.row].Text = "✕";
                    ChangeOpponentStatus("The opponent just destroyed one of your boats!", 3);
                    writeToLog($"{opponentName} hit {playerName}'s boat at {tempCoord}");
                    writeToLog($"{opponentName} sank one of {playerName}'s ships!");
                    selectingShot = false;
                    break;

                case GameLogic.recieveMessages.badCoords:
                    ChangeShotStatus("Those coordinates are bad!");
                    goto case GameLogic.recieveMessages.shotCoords;

                case GameLogic.recieveMessages.alreadyShot:
                    ChangeShotStatus("Those coordinates have already been chosen!");
                    goto case GameLogic.recieveMessages.shotCoords;

                case GameLogic.recieveMessages.shotCoords:
                    currentActionLabel.Text = "CurrentAction:\nSelect a cell to shoot at...";
                    selectingShot = true;
                    break;

                case GameLogic.recieveMessages.waiting:
                    currentActionLabel.Text = "CurrentAction:\nWaiting for opponent...";
                    selectingShot = false;
                    break;

                default:
                    break;
            }
            return;
        }

        // https://stackoverflow.com/a/16878492
        private async void ChangeShotStatus(string msg, int type = 0,int milliseconds = 4000) {

            Debug.Print("msg given: " + msg);
            shotStatusLabel.Text = msg;
            switch (type) {
                case 0:
                    shotStatusLabel.BackColor = Color.LightGreen;
                    break;
                case 1:
                    shotStatusLabel.BackColor = Color.Green;
                    break;
                case 2:
                    shotStatusLabel.BackColor = Color.OrangeRed;
                    break;
                case 3:
                    shotStatusLabel.BackColor = Color.Red;
                    break;
                default:
                    break;
            }
            await Task.Delay(milliseconds);
            shotStatusLabel.Text = "";
        }

        private async void ChangeOpponentStatus(string msg, int type = 0, int milliseconds = 4000) {

            opponentStatusLabel.Text = msg;
            switch (type) {
                case 0:
                    opponentStatusLabel.BackColor = Color.LightGreen;
                    break;
                case 1:
                    opponentStatusLabel.BackColor = Color.Green;
                    break;
                case 2:
                    opponentStatusLabel.BackColor = Color.OrangeRed;
                    break;
                case 3:
                    opponentStatusLabel.BackColor = Color.Red;
                    break;
                default:
                    break;
            }
            await Task.Delay(milliseconds);
            opponentStatusLabel.Text = "";
        }

        // ○ : Shot missed
        // ✕ : Shot Hit

        #region update Boards

        // create the labels on the main thread
        private void setPlayerBoard(int col, int row, Label lbl) {
            playerBoardTable.Controls.Add(lbl, col, row);
            if (!(col - 1 < 0 || row - 1 < 0))
                playerTableLabels[col - 1, row - 1] = lbl;

        }

        private void setOpponentBoard(int col, int row, Label lbl) {
            opponentBoardTable.Controls.Add(lbl, col, row);
            if (!(col - 1 < 0 || row - 1 < 0))
                opponentTableLabels[col - 1, row - 1] = lbl;
        }

        // since the background worker is on another thread, you can not change the labels directly in the setupValue() function
        private void setupPlayerBoats() {
            foreach (var boat in playerBoats) {
                foreach (var coord in boat.coords) {
                    string[] tempString = playerTableLabels[coord.col, coord.row].Name.Split('.');
                    if (boat.color.Name.ToString().Substring(0, 2) == "ff")
                        playerTableLabels[coord.col, coord.row].Name = $"{tempString[0]}.{tempString[1]}.#{boat.color}";
                    else
                        playerTableLabels[coord.col, coord.row].Name = $"{tempString[0]}.{tempString[1]}.{boat.color}";
                    playerTableLabels[coord.col, coord.row].BackColor = boat.color;

                }
            }

            game.StartGameLoop();
        }

        #endregion

        private void playTableLabel_MouseClick(object sender, EventArgs e) {
            // send a response back with the coordinates selected
            if (selectingShot) {
                var lbl = sender as Label;
                string[] tempString = lbl.Name.Split('.');
                int[] lblCoords = { int.Parse(tempString[0]), int.Parse(tempString[1]) };
                sendGameLogic(GameLogic.sendMessages.shotCoords, new GameLogic.Coordinate { col = lblCoords[0], row = lblCoords[1]});
            }
        }
        private void playTableLabel_MouseEnter(object sender, EventArgs e) {
            if (selectingShot) {
                var lbl = sender as Label;
                string[] tempString = lbl.Name.Split('.');
                int[] lblCoords = { int.Parse(tempString[0]), int.Parse(tempString[1]) };
                opponentTableLabels[lblCoords[0], lblCoords[1]].BackColor = Color.Blue;
            }
        }

        // changes the background color to the default one set
        private void playTableLabel_MouseLeave(object sender, EventArgs e) {
            if (selectingShot) {
                clearGhostCells();
            }
        }

        // remove temporary colors of labels
        private void clearGhostCells() {
            foreach (var cell in opponentTableLabels) {
                cell.BackColor = ColorTranslator.FromHtml(cell.Name.Split('.')[2]);
            }
        }

        private void writeToLog(string line) {
            ListViewItem temp = new ListViewItem();
            temp.Text = line;

            if (logListView.Items.Count % 2 == 0)
                temp.BackColor = Color.LightGray;
            else
                temp.BackColor = Color.White;
            logListView.Items.Add(temp);

            // scroll to new text
            logListView.Items[logListView.Items.Count - 1].EnsureVisible();
        }
    }
}
