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


        private void playButton_Click(object sender, EventArgs e) {
            var newForm = new SetupBoardForm();
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
