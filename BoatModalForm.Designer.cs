
namespace Battle_boats {
    partial class BoatModalForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoatModalForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.boatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.boatsListDataGrid = new System.Windows.Forms.DataGridView();
            this.boatNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boatLengthColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.boatColorColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.boatRemoveColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.boatLabel = new System.Windows.Forms.Label();
            this.boatAddButton = new System.Windows.Forms.Button();
            this.setBoatsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boatsListDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boatsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(723, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // boatsToolStripMenuItem
            // 
            this.boatsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.boatsToolStripMenuItem.Name = "boatsToolStripMenuItem";
            this.boatsToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.boatsToolStripMenuItem.Text = "Boats";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // boatsListDataGrid
            // 
            this.boatsListDataGrid.AllowUserToAddRows = false;
            this.boatsListDataGrid.AllowUserToDeleteRows = false;
            this.boatsListDataGrid.AllowUserToResizeColumns = false;
            this.boatsListDataGrid.AllowUserToResizeRows = false;
            this.boatsListDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.boatsListDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.boatNameColumn,
            this.boatLengthColumn,
            this.boatColorColumn,
            this.boatRemoveColumn});
            this.boatsListDataGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.boatsListDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.boatsListDataGrid.Location = new System.Drawing.Point(15, 54);
            this.boatsListDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boatsListDataGrid.MultiSelect = false;
            this.boatsListDataGrid.Name = "boatsListDataGrid";
            this.boatsListDataGrid.RowHeadersVisible = false;
            this.boatsListDataGrid.RowHeadersWidth = 51;
            this.boatsListDataGrid.RowTemplate.Height = 24;
            this.boatsListDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.boatsListDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.boatsListDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.boatsListDataGrid.Size = new System.Drawing.Size(583, 281);
            this.boatsListDataGrid.TabIndex = 3;
            this.boatsListDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.boatsListDataGrid_CellContentClick);
            // 
            // boatNameColumn
            // 
            this.boatNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.boatNameColumn.FillWeight = 200F;
            this.boatNameColumn.HeaderText = "Name";
            this.boatNameColumn.MaxInputLength = 20;
            this.boatNameColumn.MinimumWidth = 6;
            this.boatNameColumn.Name = "boatNameColumn";
            this.boatNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // boatLengthColumn
            // 
            this.boatLengthColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.boatLengthColumn.HeaderText = "Length";
            this.boatLengthColumn.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.boatLengthColumn.MinimumWidth = 6;
            this.boatLengthColumn.Name = "boatLengthColumn";
            this.boatLengthColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.boatLengthColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // boatColorColumn
            // 
            this.boatColorColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.boatColorColumn.HeaderText = "Color";
            this.boatColorColumn.MinimumWidth = 6;
            this.boatColorColumn.Name = "boatColorColumn";
            this.boatColorColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.boatColorColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // boatRemoveColumn
            // 
            this.boatRemoveColumn.HeaderText = "Remove";
            this.boatRemoveColumn.MinimumWidth = 6;
            this.boatRemoveColumn.Name = "boatRemoveColumn";
            this.boatRemoveColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.boatRemoveColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.boatRemoveColumn.Width = 125;
            // 
            // boatLabel
            // 
            this.boatLabel.AutoSize = true;
            this.boatLabel.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boatLabel.Location = new System.Drawing.Point(16, 30);
            this.boatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.boatLabel.Name = "boatLabel";
            this.boatLabel.Size = new System.Drawing.Size(64, 23);
            this.boatLabel.TabIndex = 4;
            this.boatLabel.Text = "Boats:";
            // 
            // boatAddButton
            // 
            this.boatAddButton.Location = new System.Drawing.Point(615, 54);
            this.boatAddButton.Margin = new System.Windows.Forms.Padding(4);
            this.boatAddButton.Name = "boatAddButton";
            this.boatAddButton.Size = new System.Drawing.Size(95, 36);
            this.boatAddButton.TabIndex = 5;
            this.boatAddButton.Text = "Add";
            this.boatAddButton.UseVisualStyleBackColor = true;
            this.boatAddButton.Click += new System.EventHandler(this.boatAddButton_Click);
            // 
            // setBoatsButton
            // 
            this.setBoatsButton.Location = new System.Drawing.Point(615, 97);
            this.setBoatsButton.Margin = new System.Windows.Forms.Padding(4);
            this.setBoatsButton.Name = "setBoatsButton";
            this.setBoatsButton.Size = new System.Drawing.Size(95, 36);
            this.setBoatsButton.TabIndex = 6;
            this.setBoatsButton.Text = "Set Boats";
            this.setBoatsButton.UseVisualStyleBackColor = true;
            this.setBoatsButton.Click += new System.EventHandler(this.setBoatsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(615, 140);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(95, 36);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // BoatModalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 336);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.setBoatsButton);
            this.Controls.Add(this.boatAddButton);
            this.Controls.Add(this.boatLabel);
            this.Controls.Add(this.boatsListDataGrid);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(741, 383);
            this.MinimumSize = new System.Drawing.Size(741, 383);
            this.Name = "BoatModalForm";
            this.Text = "Change Boats";
            this.Load += new System.EventHandler(this.BoatModalForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boatsListDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem boatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DataGridView boatsListDataGrid;
        private System.Windows.Forms.Label boatLabel;
        private System.Windows.Forms.Button boatAddButton;
        private System.Windows.Forms.Button setBoatsButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn boatNameColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn boatLengthColumn;
        private System.Windows.Forms.DataGridViewButtonColumn boatColorColumn;
        private System.Windows.Forms.DataGridViewButtonColumn boatRemoveColumn;
        private System.Windows.Forms.Button exitButton;
    }
}