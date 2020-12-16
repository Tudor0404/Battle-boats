using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battle_boats {
    public partial class PlayForm : Form {

        #region Ingame variables

        private Label[,] playerTableLabels = new Label[10, 10];
        private Label[,] opponentTableLabels = new Label[10, 10];

        private DisplayBoard playerDisplay;

        private bool selectingShot = false;

        #endregion

        public PlayForm() {
            InitializeComponent();
            playerDisplay = new DisplayBoard(setPlayerBoard, playTableLabel_MouseClick, playTableLabel_MouseEnter, playTableLabel_MouseLeave);
            playerDisplay = new DisplayBoard(setOpponentBoard, playTableLabel_MouseClick, playTableLabel_MouseEnter, playTableLabel_MouseLeave);
        }

        private void PlayForm_Load(object sender, EventArgs e) {
        }

        #region update Boards

        private void setPlayerBoard(int col, int row, Label lbl) {
            playerBoardTable.Controls.Add(lbl, col, row);
            playerTableLabels[col, row] = lbl;

        }

        private void setOpponentBoard(int col, int row, Label lbl) {
            opponentBoardTable.Controls.Add(lbl, col, row);
            opponentTableLabels[col, row] = lbl;
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
    }
}
