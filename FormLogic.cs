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
    class FormLogic {
        static public void displayBoard(ref Label[,] labelList, ref TableLayoutPanel boardTable, Action<object, EventArgs> mouseClickEvent, Action<object, EventArgs> mouseEnterEvent, Action<object, EventArgs> mouseLeaveEvent) {
            // Add an empty label on each cell outside the existing labels to make the checkerboard pattern.
            // Also adds a click/hover event when trying add Boats on the Board.
            // type 0 = setup, 1 = ingame

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

                        labelTemp.Click += new EventHandler(mouseClickEvent);
                        labelTemp.MouseEnter += new EventHandler(mouseEnterEvent);
                        labelTemp.MouseLeave += new EventHandler(mouseLeaveEvent);

                        labelList[col - 1, row - 1] = labelTemp;
                    }

                    boardTable.Controls.Add(labelTemp, col, row);
                }
            }
        }
    }
}
