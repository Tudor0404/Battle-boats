
namespace Battle_boats {
    partial class SetupBoardForm {
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeBoatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBoatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadBoatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupBoardTable = new System.Windows.Forms.TableLayoutPanel();
            this.boatsListDataGrid = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boatNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boatLengthColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boatColorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boatAddColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.boatRemoveColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AIDifficultyLabel = new System.Windows.Forms.Label();
            this.easyAIRadio = new System.Windows.Forms.RadioButton();
            this.regularAIRadio = new System.Windows.Forms.RadioButton();
            this.startGameButton = new System.Windows.Forms.Button();
            this.hardAIButton = new System.Windows.Forms.RadioButton();
            this.setupBoardLabel = new System.Windows.Forms.Label();
            this.boatDirectionButton = new System.Windows.Forms.Button();
            this.directionLabel = new System.Windows.Forms.Label();
            this.placementStatusLabel = new System.Windows.Forms.Label();
            this.unselectBoatButton = new System.Windows.Forms.Button();
            this.setupPanel = new System.Windows.Forms.Panel();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boatsListDataGrid)).BeginInit();
            this.setupPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.boatsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(634, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // boatsToolStripMenuItem
            // 
            this.boatsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeBoatsToolStripMenuItem,
            this.saveBoatsToolStripMenuItem,
            this.loadBoatsToolStripMenuItem});
            this.boatsToolStripMenuItem.Name = "boatsToolStripMenuItem";
            this.boatsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.boatsToolStripMenuItem.Text = "Boats";
            // 
            // changeBoatsToolStripMenuItem
            // 
            this.changeBoatsToolStripMenuItem.Name = "changeBoatsToolStripMenuItem";
            this.changeBoatsToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.changeBoatsToolStripMenuItem.Text = "Change boats";
            this.changeBoatsToolStripMenuItem.Click += new System.EventHandler(this.changeBoatsToolStripMenuItem_Click);
            // 
            // saveBoatsToolStripMenuItem
            // 
            this.saveBoatsToolStripMenuItem.Name = "saveBoatsToolStripMenuItem";
            this.saveBoatsToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.saveBoatsToolStripMenuItem.Text = "Save boats";
            // 
            // loadBoatsToolStripMenuItem
            // 
            this.loadBoatsToolStripMenuItem.Name = "loadBoatsToolStripMenuItem";
            this.loadBoatsToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.loadBoatsToolStripMenuItem.Text = "Load boats";
            // 
            // setupBoardTable
            // 
            this.setupBoardTable.AutoSize = true;
            this.setupBoardTable.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.setupBoardTable.ColumnCount = 11;
            this.setupBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.setupBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.setupBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.setupBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.setupBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.setupBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.setupBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.setupBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.setupBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.setupBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.setupBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.setupBoardTable.Location = new System.Drawing.Point(7, 28);
            this.setupBoardTable.Margin = new System.Windows.Forms.Padding(2);
            this.setupBoardTable.Name = "setupBoardTable";
            this.setupBoardTable.RowCount = 11;
            this.setupBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.setupBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.setupBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.setupBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.setupBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.setupBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.setupBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.setupBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.setupBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.setupBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.setupBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.setupBoardTable.Size = new System.Drawing.Size(278, 277);
            this.setupBoardTable.TabIndex = 1;
            this.setupBoardTable.TabStop = true;
            // 
            // boatsListDataGrid
            // 
            this.boatsListDataGrid.AllowUserToAddRows = false;
            this.boatsListDataGrid.AllowUserToDeleteRows = false;
            this.boatsListDataGrid.AllowUserToResizeColumns = false;
            this.boatsListDataGrid.AllowUserToResizeRows = false;
            this.boatsListDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.boatsListDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.boatsListDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.boatNameColumn,
            this.boatLengthColumn,
            this.boatColorColumn,
            this.boatAddColumn,
            this.boatRemoveColumn});
            this.boatsListDataGrid.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.boatsListDataGrid.Location = new System.Drawing.Point(7, 330);
            this.boatsListDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.boatsListDataGrid.MultiSelect = false;
            this.boatsListDataGrid.Name = "boatsListDataGrid";
            this.boatsListDataGrid.RowHeadersVisible = false;
            this.boatsListDataGrid.RowHeadersWidth = 51;
            this.boatsListDataGrid.RowTemplate.Height = 24;
            this.boatsListDataGrid.RowTemplate.ReadOnly = true;
            this.boatsListDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.boatsListDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.boatsListDataGrid.Size = new System.Drawing.Size(467, 174);
            this.boatsListDataGrid.TabIndex = 2;
            this.boatsListDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.boatsListDataGrid_CellContentClick);
            this.boatsListDataGrid.SelectionChanged += new System.EventHandler(this.boatsListDataGrid_SelectionChanged);
            this.boatsListDataGrid.Sorted += new System.EventHandler(this.boatsListDataGrid_Sorted);
            // 
            // Index
            // 
            this.Index.DataPropertyName = "boatIndexColumn";
            this.Index.HeaderText = "Index";
            this.Index.MinimumWidth = 6;
            this.Index.Name = "Index";
            this.Index.Visible = false;
            this.Index.Width = 125;
            // 
            // boatNameColumn
            // 
            this.boatNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.boatNameColumn.HeaderText = "Name";
            this.boatNameColumn.MinimumWidth = 6;
            this.boatNameColumn.Name = "boatNameColumn";
            this.boatNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // boatLengthColumn
            // 
            this.boatLengthColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.boatLengthColumn.HeaderText = "Length";
            this.boatLengthColumn.MinimumWidth = 6;
            this.boatLengthColumn.Name = "boatLengthColumn";
            this.boatLengthColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // boatColorColumn
            // 
            this.boatColorColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.boatColorColumn.HeaderText = "Color";
            this.boatColorColumn.MinimumWidth = 6;
            this.boatColorColumn.Name = "boatColorColumn";
            this.boatColorColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // boatAddColumn
            // 
            this.boatAddColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.boatAddColumn.HeaderText = "Add";
            this.boatAddColumn.MinimumWidth = 6;
            this.boatAddColumn.Name = "boatAddColumn";
            this.boatAddColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.boatAddColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // boatRemoveColumn
            // 
            this.boatRemoveColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.boatRemoveColumn.HeaderText = "Remove";
            this.boatRemoveColumn.MinimumWidth = 6;
            this.boatRemoveColumn.Name = "boatRemoveColumn";
            this.boatRemoveColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.boatRemoveColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // AIDifficultyLabel
            // 
            this.AIDifficultyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AIDifficultyLabel.AutoSize = true;
            this.AIDifficultyLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AIDifficultyLabel.Location = new System.Drawing.Point(424, 27);
            this.AIDifficultyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AIDifficultyLabel.Name = "AIDifficultyLabel";
            this.AIDifficultyLabel.Size = new System.Drawing.Size(76, 19);
            this.AIDifficultyLabel.TabIndex = 3;
            this.AIDifficultyLabel.Text = "Difficulty:";
            // 
            // easyAIRadio
            // 
            this.easyAIRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.easyAIRadio.AutoSize = true;
            this.easyAIRadio.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyAIRadio.Location = new System.Drawing.Point(427, 57);
            this.easyAIRadio.Margin = new System.Windows.Forms.Padding(2);
            this.easyAIRadio.Name = "easyAIRadio";
            this.easyAIRadio.Size = new System.Drawing.Size(56, 21);
            this.easyAIRadio.TabIndex = 4;
            this.easyAIRadio.Text = "Easy";
            this.easyAIRadio.UseVisualStyleBackColor = true;
            // 
            // regularAIRadio
            // 
            this.regularAIRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.regularAIRadio.AutoSize = true;
            this.regularAIRadio.Checked = true;
            this.regularAIRadio.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regularAIRadio.Location = new System.Drawing.Point(427, 81);
            this.regularAIRadio.Margin = new System.Windows.Forms.Padding(2);
            this.regularAIRadio.Name = "regularAIRadio";
            this.regularAIRadio.Size = new System.Drawing.Size(74, 21);
            this.regularAIRadio.TabIndex = 5;
            this.regularAIRadio.TabStop = true;
            this.regularAIRadio.Text = "Regular";
            this.regularAIRadio.UseVisualStyleBackColor = true;
            // 
            // startGameButton
            // 
            this.startGameButton.AutoSize = true;
            this.startGameButton.Enabled = false;
            this.startGameButton.Location = new System.Drawing.Point(482, 481);
            this.startGameButton.Margin = new System.Windows.Forms.Padding(2);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(141, 37);
            this.startGameButton.TabIndex = 6;
            this.startGameButton.Text = "START";
            this.startGameButton.UseVisualStyleBackColor = true;
            // 
            // hardAIButton
            // 
            this.hardAIButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hardAIButton.AutoSize = true;
            this.hardAIButton.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardAIButton.Location = new System.Drawing.Point(427, 106);
            this.hardAIButton.Margin = new System.Windows.Forms.Padding(2);
            this.hardAIButton.Name = "hardAIButton";
            this.hardAIButton.Size = new System.Drawing.Size(57, 21);
            this.hardAIButton.TabIndex = 7;
            this.hardAIButton.Text = "Hard";
            this.hardAIButton.UseVisualStyleBackColor = true;
            // 
            // setupBoardLabel
            // 
            this.setupBoardLabel.AutoSize = true;
            this.setupBoardLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setupBoardLabel.Location = new System.Drawing.Point(3, 7);
            this.setupBoardLabel.Name = "setupBoardLabel";
            this.setupBoardLabel.Size = new System.Drawing.Size(86, 19);
            this.setupBoardLabel.TabIndex = 8;
            this.setupBoardLabel.Text = "Your board";
            // 
            // boatDirectionButton
            // 
            this.boatDirectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.boatDirectionButton.Location = new System.Drawing.Point(361, 299);
            this.boatDirectionButton.Name = "boatDirectionButton";
            this.boatDirectionButton.Size = new System.Drawing.Size(113, 26);
            this.boatDirectionButton.TabIndex = 9;
            this.boatDirectionButton.Text = "Horizontal";
            this.boatDirectionButton.UseVisualStyleBackColor = true;
            this.boatDirectionButton.Click += new System.EventHandler(this.boatDirectionButton_Click);
            // 
            // directionLabel
            // 
            this.directionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.directionLabel.AutoSize = true;
            this.directionLabel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directionLabel.Location = new System.Drawing.Point(358, 281);
            this.directionLabel.Name = "directionLabel";
            this.directionLabel.Size = new System.Drawing.Size(101, 15);
            this.directionLabel.TabIndex = 10;
            this.directionLabel.Text = "Direction of boat";
            // 
            // placementStatusLabel
            // 
            this.placementStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.placementStatusLabel.AutoSize = true;
            this.placementStatusLabel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placementStatusLabel.Location = new System.Drawing.Point(12, 305);
            this.placementStatusLabel.Name = "placementStatusLabel";
            this.placementStatusLabel.Size = new System.Drawing.Size(0, 15);
            this.placementStatusLabel.TabIndex = 11;
            // 
            // unselectBoatButton
            // 
            this.unselectBoatButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.unselectBoatButton.Location = new System.Drawing.Point(242, 299);
            this.unselectBoatButton.Name = "unselectBoatButton";
            this.unselectBoatButton.Size = new System.Drawing.Size(113, 26);
            this.unselectBoatButton.TabIndex = 12;
            this.unselectBoatButton.Text = "Unselect booat";
            this.unselectBoatButton.UseVisualStyleBackColor = true;
            this.unselectBoatButton.Visible = false;
            this.unselectBoatButton.Click += new System.EventHandler(this.unselectBoatButton_Click);
            // 
            // setupPanel
            // 
            this.setupPanel.Controls.Add(this.unselectBoatButton);
            this.setupPanel.Controls.Add(this.placementStatusLabel);
            this.setupPanel.Controls.Add(this.directionLabel);
            this.setupPanel.Controls.Add(this.boatDirectionButton);
            this.setupPanel.Controls.Add(this.setupBoardLabel);
            this.setupPanel.Controls.Add(this.hardAIButton);
            this.setupPanel.Controls.Add(this.startGameButton);
            this.setupPanel.Controls.Add(this.regularAIRadio);
            this.setupPanel.Controls.Add(this.easyAIRadio);
            this.setupPanel.Controls.Add(this.AIDifficultyLabel);
            this.setupPanel.Controls.Add(this.setupBoardTable);
            this.setupPanel.Controls.Add(this.boatsListDataGrid);
            this.setupPanel.Location = new System.Drawing.Point(0, 27);
            this.setupPanel.Name = "setupPanel";
            this.setupPanel.Size = new System.Drawing.Size(634, 523);
            this.setupPanel.TabIndex = 13;
            // 
            // SetupBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(634, 561);
            this.Controls.Add(this.setupPanel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(650, 600);
            this.Name = "SetupBoardForm";
            this.Text = "Play against AI";
            this.Load += new System.EventHandler(this.playAgainstAIForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boatsListDataGrid)).EndInit();
            this.setupPanel.ResumeLayout(false);
            this.setupPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeBoatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveBoatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadBoatsToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel setupBoardTable;
        private System.Windows.Forms.DataGridView boatsListDataGrid;
        private System.Windows.Forms.Label AIDifficultyLabel;
        private System.Windows.Forms.RadioButton easyAIRadio;
        private System.Windows.Forms.RadioButton regularAIRadio;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.RadioButton hardAIButton;
        private System.Windows.Forms.Label setupBoardLabel;
        private System.Windows.Forms.Button boatDirectionButton;
        private System.Windows.Forms.Label directionLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn boatNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boatLengthColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boatColorColumn;
        private System.Windows.Forms.DataGridViewButtonColumn boatAddColumn;
        private System.Windows.Forms.DataGridViewButtonColumn boatRemoveColumn;
        private System.Windows.Forms.Label placementStatusLabel;
        private System.Windows.Forms.Button unselectBoatButton;
        private System.Windows.Forms.Panel setupPanel;
    }
}