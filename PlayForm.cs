using System;
using System.Drawing;
using System.Windows.Forms;

namespace Battle_boats {
    public partial class PlayForm : Form {
        private Label[,] playerTableLabels = new Label[10, 10];
        private Label[,] opponentTableLabels = new Label[10, 10];

        private DisplayBoard playerDisplay;
        private DisplayBoard opponentDisplay;

        private bool selectingShot = false;

        GameLogic game;
        private string playerName;

        public PlayForm(GameLogic.GameTypes Type, GameLogic.AILevels Difficuly, string Name = "Player") {
            InitializeComponent();
            game = new GameLogic(Type, Difficuly);
            playerName = Name;

            // make listVIew look like a listBox
            logListView.Columns.Add("", -2);

            playerDisplay = new DisplayBoard(setPlayerBoard, playTableLabel_MouseClick, playTableLabel_MouseEnter, playTableLabel_MouseLeave);
            opponentDisplay = new DisplayBoard(setOpponentBoard, playTableLabel_MouseClick, playTableLabel_MouseEnter, playTableLabel_MouseLeave);
        }

        private void PlayForm_Load(object sender, EventArgs e) {
            setupValues();

            if (game.gameType == GameLogic.GameTypes.AI)
                writeToLog($"Game started, {playerName} vs AI level {game.AILevel}");
            else
                writeToLog($"Local game started");

            for (int i = 0; i < 40; i++) {
                writeToLog(i.ToString());
            }
        }

        private void setupValues() {
            playerDisplay.displayBoard();
            opponentDisplay.displayBoard();
        }

        #region update Boards

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


        #endregion

        private void playTableLabel_MouseClick(object sender, EventArgs e) {
            return;
        }
        private void playTableLabel_MouseEnter(object sender, EventArgs e) {
            return;
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
        }
    }
}
