using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

/* 
 * BUGS:
 * FIXED -index exception when changing the sort on the add/remove columns
 * 
 * FEATURES:
 * DONE -remove boats
 * DONE -enable disable start button depending if the boats are out or not
 * DONE -change boats
 * -save/load boats
 * */


namespace Battle_boats {
    public partial class playAgainstAIForm : Form {
        public playAgainstAIForm() {
            InitializeComponent();
        }

        public Label[,] boardLabel = new Label[10, 10];
        private GameLogic game = new GameLogic();
        List<GameLogic.Boat> boatsOnBoard = new List<GameLogic.Boat>();

        // boat index selected related to the gamelogic possible boats
        int currentBoatIndex = -1;
        bool isLocationSuitable = true;

        private void playAgainstAIForm_Load(object sender, EventArgs e) {
            setupValues();
        }

        private void setupValues() {
            boatsOnBoard.Clear();
            // allow to add items to the table later on
            this.Controls.Add(boardSetupTable);
            boardSetupTable.Controls.Clear();

            // Add an empty label on each cell outside the existing labels to make the checkerboard pattern.
            // Also adds a click/hover event when trying add Boats on the Board.
            string alpha = "ABCDEFGHIJ";

            for (int col = 0; col < 11; col++) {
                for (int row = 0; row < 11; row++) {
                    var labelTemp = new Label();
                    labelTemp.Dock = DockStyle.Fill;
                    labelTemp.TextAlign = ContentAlignment.MiddleCenter;
                    labelTemp.AutoSize = true;
                    labelTemp.Font = new Font("Roboto", 10, FontStyle.Regular);
                    labelTemp.Margin = new Padding(0);
                    if ((col + row) % 2 == 0) {
                        labelTemp.BackColor = Color.LightGray;
                    } else {
                        labelTemp.BackColor = Color.White;
                    }

                    if (col == 0) {
                        if (row != 0)
                            labelTemp.Text = row.ToString();
                    } else if (row == 0) {
                        if (col != 0)
                            labelTemp.Text = alpha[col - 1].ToString();
                    } else {
                        // col, row and default color
                        labelTemp.Name = $"{col - 1}.{row - 1}.{labelTemp.BackColor.Name}";

                        labelTemp.Click += new EventHandler(tableLabel_Click);
                        labelTemp.MouseEnter += new EventHandler(tableLabel_MouseEnter);
                        labelTemp.MouseLeave += new EventHandler(tableLabel_MouseLeave);

                        boardLabel[col - 1, row - 1] = labelTemp;
                    }

                    boardSetupTable.Controls.Add(labelTemp, col, row);
                }
            }

            boatsListDataGrid.Rows.Clear();
            // set the DataGridView to the possible boats, also styles to rows, red not placed, green = placed
            boatsListDataGrid.RowsDefaultCellStyle.SelectionBackColor = Color.Transparent;
            boatsListDataGrid.DefaultCellStyle.SelectionForeColor = Color.Black;

            for (int i = 0; i < GameLogic.possibleBoats.Count; i++) {
                boatsListDataGrid.Rows.Add(
                    GameLogic.possibleBoats[i].index,
                    GameLogic.possibleBoats[i].name,
                    GameLogic.possibleBoats[i].length,
                    GameLogic.possibleBoats[i].color.Name,
                    "Add",
                    "Remove");
                boatsListDataGrid.Rows[i].Cells["boatColorColumn"].Style.ForeColor = GameLogic.possibleBoats[i].color;
            }

            setDataGridStatus();
            boatsListDataGrid.Sort(boatsListDataGrid.Columns[1], ListSortDirection.Descending);
            boatsListDataGrid.ClearSelection();
        }

        // places boats on the board
        private void tableLabel_Click(object sender, EventArgs e) {
            Label lbl = sender as Label;

            // check if ghost image had trouble rendering
            if (currentBoatIndex < 0) {
                return;
            } else if (!isLocationSuitable) {
                clearGhostCells();
                MessageBox.Show("The boat goes out of the board, choose another location", "Error");
            } else {
                try {
                    // create copy of boat and set coords
                    var tempBoat = GameLogic.possibleBoats[currentBoatIndex];
                    string[] tempString = lbl.Name.Split('.');
                    int[] tempInt = { int.Parse(tempString[0]), int.Parse(tempString[1]) };
                    tempBoat.mainCoord = new GameLogic.Coords(tempInt[0], tempInt[1]);
                    if (boatDirectionButton.Text == "Vertical")
                        tempBoat.direc = GameLogic.Direction.Vertical;
                    else
                        tempBoat.direc = GameLogic.Direction.Horizontal;

                    if (GameLogic.addBoatCheck(tempBoat, boatsOnBoard)) {
                        // if the boat is good, add it to the list
                        boatsOnBoard.Add(tempBoat);

                        // goes through the length of the boat, and colors in the square next to it depending on the direction
                        for (int i = 0; i < boatsOnBoard[boatsOnBoard.Count - 1].length; i++) {

                            if (boatDirectionButton.Text == GameLogic.Direction.Horizontal.ToString()) {

                                boardLabel[tempInt[0] + i, tempInt[1]].BackColor = GameLogic.possibleBoats[currentBoatIndex].color;
                                if (GameLogic.possibleBoats[currentBoatIndex].color.Name.ToString().Substring(0, 2) == "ff")
                                    boardLabel[tempInt[0] + i, tempInt[1]].Name = $"{tempInt[0] + i}.{tempInt[1]}.#{GameLogic.possibleBoats[currentBoatIndex].color.Name}";
                                else
                                    boardLabel[tempInt[0] + i, tempInt[1]].Name = $"{tempInt[0] + i}.{tempInt[1]}.{GameLogic.possibleBoats[currentBoatIndex].color.Name}";
                            } else {

                                boardLabel[tempInt[0], tempInt[1] + i].BackColor = GameLogic.possibleBoats[currentBoatIndex].color;
                                if (GameLogic.possibleBoats[currentBoatIndex].color.Name.ToString().Substring(0, 2) == "ff")
                                    boardLabel[tempInt[0], tempInt[1] + i].Name = $"{tempInt[0]}.{tempInt[1] + i}.#{GameLogic.possibleBoats[currentBoatIndex].color.Name}";
                                else
                                    boardLabel[tempInt[0], tempInt[1] + i].Name = $"{tempInt[0]}.{tempInt[1] + i}.{GameLogic.possibleBoats[currentBoatIndex].color.Name}";
                            }
                        }
                    } else {
                        MessageBox.Show("The boat overlaps with another", "Error");
                    }

                    setDataGridStatus();
                    unselectBoat();
                } catch (Exception err) {

                    MessageBox.Show(err.ToString(), "Error");
                }
            }
        }

        private void unselectBoat() {
            currentBoatIndex = -1;
            placementStatusLabel.Text = "";
            clearGhostCells();
            unselectBoatButton.Visible = false;
        }

        // shows the user where the user where the boat would be placed
        private void tableLabel_MouseEnter(object sender, EventArgs e) {

            if (currentBoatIndex > -1) {
                var lbl = sender as Label;

                // gets the coord of the initial position from the label name
                string[] tempString = lbl.Name.Split('.');
                int[] lblCoords = { int.Parse(tempString[0]), int.Parse(tempString[1]) };
                isLocationSuitable = true;

                // goes through the length of the boat, and colors in the square next to it depending on the direction
                for (int i = 0; i < GameLogic.possibleBoats[currentBoatIndex].length; i++) {
                    if (boatDirectionButton.Text == GameLogic.Direction.Horizontal.ToString()) {

                        try {
                            boardLabel[lblCoords[0] + i, lblCoords[1]].BackColor = GameLogic.possibleBoats[currentBoatIndex].color;
                        } catch {
                            // if it can't draw, that mean it is out of bounds
                            isLocationSuitable = false;
                        }
                    } else {

                        try {
                            boardLabel[lblCoords[0], lblCoords[1] + i].BackColor = GameLogic.possibleBoats[currentBoatIndex].color;
                        } catch {
                            // if it can't draw, that mean it is out of bounds
                            isLocationSuitable = false;
                        }
                    }
                }
            }
        }

        // changes the background color to the default one set
        private void tableLabel_MouseLeave(object sender, EventArgs e) {
            if (currentBoatIndex != -1) {
                clearGhostCells();
            }
        }

        // remove temporary colors of labels
        private void clearGhostCells() {
            foreach (var cell in boardLabel) {
                cell.BackColor = System.Drawing.ColorTranslator.FromHtml(cell.Name.Split('.')[2]);
            }
        }

        // toggles between directions when pressing the button
        private void boatDirectionButton_Click(object sender, EventArgs e) {
            if (boatDirectionButton.Text == GameLogic.Direction.Horizontal.ToString()) {
                boatDirectionButton.Text = GameLogic.Direction.Vertical.ToString();
            } else {
                boatDirectionButton.Text = GameLogic.Direction.Horizontal.ToString();
            }
        }

        // prevents the grid from being selected
        private void boatsListDataGrid_SelectionChanged(object sender, EventArgs e) {
            boatsListDataGrid.ClearSelection();
        }

        // change the row colors of the table
        private void setDataGridStatus() {
            foreach (DataGridViewRow row in boatsListDataGrid.Rows) {
                // check if the boat is on the board currently
                if (boatsOnBoard.Any(other => other.index == int.Parse(row.Cells[0].Value.ToString()))) {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 27, 177, 27);
                    row.Cells["boatRemoveColumn"].Value = "Remove";
                    row.Cells["boatAddColumn"].Value = "";
                } else {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 222, 41, 41);
                    row.Cells["boatRemoveColumn"].Value = "";
                    row.Cells["boatAddColumn"].Value = "Add";
                }
            }

            checkStart();
        }

        // checks if the game is able to be started
        private void checkStart() {
            if (boatsOnBoard.Count == GameLogic.possibleBoats.Count) {
                startGameButton.Enabled = true;
            } else {
                startGameButton.Enabled = false;
            }
        }

        private void unselectBoatButton_Click(object sender, EventArgs e) {
            unselectBoat();
        }

        // reset the rows colors when changing sorting
        private void boatsListDataGrid_Sorted(object sender, EventArgs e) {
            setDataGridStatus();
        }

        // checks if a button in the grid has been clicked, if it has do the associated action
        private void boatsListDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) {

            // checks if the header isn't selected and that the button is enabled
            if (e.RowIndex > -1 && boatsListDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "") {
                // add a boat
                if (e.ColumnIndex == 4) {
                    currentBoatIndex = (int)boatsListDataGrid.Rows[e.RowIndex].Cells[0].Value;
                    placementStatusLabel.Text = $"Placing boat '{GameLogic.possibleBoats[currentBoatIndex].name}'";
                    placementStatusLabel.Visible = true;
                    unselectBoatButton.Visible = true;


                    // remove a boat
                } else if (e.ColumnIndex == 5) {

                    // gets the boat with the index selected and goes through all of the coords, reseting them to the default
                    var boatToRemove = boatsOnBoard.Find(x => x.index == (int)boatsListDataGrid.Rows[e.RowIndex].Cells[0].Value);
                    foreach (var coord in boatToRemove.coords) {
                        var tempString = boardLabel[coord.col, coord.row].Name.Split('.');
                        if ((coord.col + coord.row) % 2 == 0) {
                            boardLabel[coord.col, coord.row].Name = $"{tempString[0]}.{tempString[1]}.LightGray";
                        } else {
                            boardLabel[coord.col, coord.row].Name = $"{tempString[0]}.{tempString[1]}.White";
                        }
                    }

                    boatsOnBoard.Remove(boatToRemove);

                    // update cells
                    setDataGridStatus();
                    clearGhostCells();
                }
            }
        }

        private void changeBoatsToolStripMenuItem_Click(object sender, EventArgs e) {
            var modalForm = new BoatModalForm();
            modalForm.ShowDialog();
            if (modalForm.DialogResult == DialogResult.OK) {
                modalForm.Dispose();
                setupValues();
            } else {
                modalForm.Dispose();
            }
        }
    }
}
