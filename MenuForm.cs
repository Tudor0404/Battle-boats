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
    public partial class MenuForm : Form {
        public MenuForm() {
            InitializeComponent();
        }


        #region Menu Buttons
        private void Form1_Load(object sender, EventArgs e) {
        }

        
        private void playAIButton_Click(object sender, EventArgs e) {
            // creates the playAgainstAIForm when pressing the button. Positions the form on top of this one. After closing the new form, this form reappears
            // this method is used for the other methods
            // https://stackoverflow.com/a/5848187/9296938
            var newForm = new SetupBoardForm(0);
            newForm.Location = this.Location;
            newForm.StartPosition = FormStartPosition.Manual;
            newForm.FormClosing += delegate { this.Show(); };
            newForm.Show();
            this.Hide();
        }

        private void playLocalButton_Click(object sender, EventArgs e) {
            // same logic as above
            var newForm = new SetupBoardForm(1);
            newForm.Location = this.Location;
            newForm.StartPosition = FormStartPosition.Manual;
            newForm.FormClosing += delegate { this.Show(); };
            newForm.Show();
            this.Hide();
        }

        private void leaderboardButton_Click(object sender, EventArgs e) {
            // same logic as above
            var newForm = new leaderboardForm();
            newForm.Location = this.Location;
            newForm.StartPosition = FormStartPosition.Manual;
            newForm.FormClosing += delegate { this.Show(); };
            newForm.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e) {
            // exit program
            System.Windows.Forms.Application.Exit();
        }

        #endregion

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) {

        }
    }
}
