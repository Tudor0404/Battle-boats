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
    class DisplayBoard {
        private readonly BackgroundWorker worker;

        public DisplayBoard(Action<int, int, Label> setBoard, Action<object, EventArgs> mouseClickEvent, Action<object, EventArgs> mouseEnterEvent, Action<object, EventArgs> mouseLeaveEvent) {            
            worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += (sender, e) => displayBoardWork(sender, e, mouseClickEvent,  mouseEnterEvent,  mouseLeaveEvent);
            worker.ProgressChanged += (sender, e) => displayBoardProgressChanged(sender, e, setBoard);
        }

        public void displayBoard() {
            // Asynchronously update the board when needed
            worker.RunWorkerAsync();
        }

        private void displayBoardWork(object sender, DoWorkEventArgs e, Action<object, EventArgs> mouseClickEvent, Action<object, EventArgs> mouseEnterEvent, Action<object, EventArgs> mouseLeaveEvent) {
            var bgWorker = sender as BackgroundWorker; 
            
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

                    }
                    bgWorker.ReportProgress(1, new Response { col = col, row = row, lbl = labelTemp});
                }
            }
        }

        private void displayBoardProgressChanged(object sender, ProgressChangedEventArgs e, Action<int, int, Label> setBoard) {
            Response response = (Response)e.UserState;
            setBoard(response.col, response.row, response.lbl);
        }

        struct Response {
            public int col;
            public int row;
            public Label lbl;
        }
    }
}
