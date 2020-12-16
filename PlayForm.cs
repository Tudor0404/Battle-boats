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


        private bool selectingShot = false;

        #endregion

        public PlayForm() {
            InitializeComponent();
        }

        private void PlayForm_Load(object sender, EventArgs e) {
            FormLogic.displayBoard(ref playerTableLabels, ref playerBoardTable, playTableLabel_MouseClick, playTableLabel_MouseEnter, playTableLabel_MouseLeave);
            FormLogic.displayBoard(ref opponentTableLabels, ref opponentBoardTable, playTableLabel_MouseClick, playTableLabel_MouseEnter, playTableLabel_MouseLeave);
        }

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
