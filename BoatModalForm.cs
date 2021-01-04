using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Battle_boats {
    public partial class BoatModalForm : Form {
        public BoatModalForm() {
            InitializeComponent();
        }
        private void BoatModalForm_Load(object sender, EventArgs e) {
            setupValues();
        }

        private void setupValues() {
            boatsListDataGrid.Rows.Clear();

            boatsListDataGrid.ClearSelection();
            boatsListDataGrid.CurrentCell = null;

            // add the current boats in the grid
            for (int i = 0; i < GameLogic.possibleBoats.Count; i++) {
                var boat = GameLogic.possibleBoats[i];
                boatsListDataGrid.Rows.Add(boat.name, boat.length.ToString(), "", "Remove");
                DataGridViewButtonCell bc = new DataGridViewButtonCell();
                bc.FlatStyle = FlatStyle.Flat;
                bc.Style.BackColor = boat.color;
                bc.Style.SelectionBackColor = boat.color;
                boatsListDataGrid.Rows[i].Cells[2] = bc;
            }
        }

        // allow for a max of 8 boats
        private void boatAddButton_Click(object sender, EventArgs e) {
            if (boatsListDataGrid.Rows.Count < 8)
                boatsListDataGrid.Rows.Add("", "4", "", "Remove");
            else
                MessageBox.Show("Max of 8 boats can be used");
        }

        // set the color and remove the boat
        private void boatsListDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            var dataGrid = sender as DataGridView;

            if (dataGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn) {
                if (e.ColumnIndex == 2) {
                    Debug.Print(dataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor.ToString());
                    ColorDialog colorDialog = new ColorDialog();
                    // Keeps the user from selecting a custom color.
                    colorDialog.AllowFullOpen = false;
                    colorDialog.SolidColorOnly = true;

                    // Updates the button colors so reflect what the user chose
                    if (colorDialog.ShowDialog() == DialogResult.OK) {
                        DataGridViewButtonCell bc = new DataGridViewButtonCell();
                        bc.FlatStyle = FlatStyle.Flat;
                        bc.Style.BackColor = colorDialog.Color;
                        bc.Style.SelectionBackColor = colorDialog.Color;
                        dataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex] = bc;
                    }
                } else if (e.ColumnIndex == 3) {
                    dataGrid.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void setBoatsButton_Click(object sender, EventArgs e) {

            // exit modal, and refresh main page
            if (checkBoats())
                this.DialogResult = DialogResult.OK;
        }

        // check if boats are valid
        private bool checkBoats() {

            var tempBoatList = new List<GameLogic.Boat>();
            if (boatsListDataGrid.Rows.Count > 8 || boatsListDataGrid.Rows.Count == 0) {
                MessageBox.Show("A minimum of 1 and a maximum of 8 boats can be set");
                return false;
            }

            for (int i = 0; i < boatsListDataGrid.Rows.Count; i++) {
                var tempRow = boatsListDataGrid.Rows[i];

                // check name
                try {
                    if (tempRow.Cells[0].Value.ToString().Length < 3) {
                        MessageBox.Show($"Row {i + 1} name '{tempRow.Cells[0].Value}' is too short");
                        return false;
                    }
                } catch {
                    MessageBox.Show($"Row {i + 1} has no name");
                    return false;
                }

                // check length
                if (int.Parse(tempRow.Cells[1].Value.ToString()) < 0 || int.Parse(tempRow.Cells[1].Value.ToString()) > 10) {
                    MessageBox.Show($"Row {i + 1} length '{tempRow.Cells[1].Value}' should be between 1 and 10");
                    return false;
                }

                // check color
                var tempButton = tempRow.Cells[2] as DataGridViewButtonCell;
                if (tempButton.Style.BackColor.IsEmpty) {
                    MessageBox.Show($"Row {i + 1} color has not been chosen yet");
                    return false;
                }

                tempBoatList.Add(new GameLogic.Boat(tempRow.Cells[0].Value.ToString(), int.Parse(tempRow.Cells[1].Value.ToString()), tempButton.Style.BackColor, i));
            }

            if (GameLogic.setPossibleBoats(tempBoatList)[0] == "true") {
                return true;
            }

            return false;
        }

        // exit modal
        private void exitButton_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            if (checkBoats())
                GameLogic.saveBoats();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e) {
            if (GameLogic.loadBoats())
                setupValues();
        }
    }
}
