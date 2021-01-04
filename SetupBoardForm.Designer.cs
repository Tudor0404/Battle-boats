
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupBoardForm));
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
            this.startGameButton = new System.Windows.Forms.Button();
            this.setupBoardLabel = new System.Windows.Forms.Label();
            this.directionLabel = new System.Windows.Forms.Label();
            this.placementStatusLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.boatFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.boatButtonTable = new System.Windows.Forms.TableLayoutPanel();
            this.boatDirectionButton = new System.Windows.Forms.Button();
            this.unselectBoatButton = new System.Windows.Forms.Button();
            this.gameSettingsTabs = new System.Windows.Forms.TabControl();
            this.AITabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.hardAIRadio = new System.Windows.Forms.RadioButton();
            this.regularAIRadio = new System.Windows.Forms.RadioButton();
            this.easyAIRadio = new System.Windows.Forms.RadioButton();
            this.localTabPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boatsListDataGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.boatFlowPanel.SuspendLayout();
            this.boatButtonTable.SuspendLayout();
            this.gameSettingsTabs.SuspendLayout();
            this.AITabPage.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.localTabPage.SuspendLayout();
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
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(845, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // boatsToolStripMenuItem
            // 
            this.boatsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeBoatsToolStripMenuItem,
            this.saveBoatsToolStripMenuItem,
            this.loadBoatsToolStripMenuItem});
            this.boatsToolStripMenuItem.Name = "boatsToolStripMenuItem";
            this.boatsToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.boatsToolStripMenuItem.Text = "Boats";
            // 
            // changeBoatsToolStripMenuItem
            // 
            this.changeBoatsToolStripMenuItem.Name = "changeBoatsToolStripMenuItem";
            this.changeBoatsToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.changeBoatsToolStripMenuItem.Text = "Change boats";
            this.changeBoatsToolStripMenuItem.Click += new System.EventHandler(this.changeBoatsToolStripMenuItem_Click);
            // 
            // saveBoatsToolStripMenuItem
            // 
            this.saveBoatsToolStripMenuItem.Name = "saveBoatsToolStripMenuItem";
            this.saveBoatsToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.saveBoatsToolStripMenuItem.Text = "Save boats";
            this.saveBoatsToolStripMenuItem.Click += new System.EventHandler(this.saveBoatsToolStripMenuItem_Click);
            // 
            // loadBoatsToolStripMenuItem
            // 
            this.loadBoatsToolStripMenuItem.Name = "loadBoatsToolStripMenuItem";
            this.loadBoatsToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.loadBoatsToolStripMenuItem.Text = "Load boats";
            this.loadBoatsToolStripMenuItem.Click += new System.EventHandler(this.loadBoatsToolStripMenuItem_Click);
            // 
            // setupBoardTable
            // 
            this.setupBoardTable.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.setupBoardTable.ColumnCount = 11;
            this.setupBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.setupBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.setupBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.setupBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.setupBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.setupBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.setupBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.setupBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.setupBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.setupBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.setupBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.setupBoardTable.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.setupBoardTable.Location = new System.Drawing.Point(0, 25);
            this.setupBoardTable.Margin = new System.Windows.Forms.Padding(0);
            this.setupBoardTable.MinimumSize = new System.Drawing.Size(347, 320);
            this.setupBoardTable.Name = "setupBoardTable";
            this.setupBoardTable.RowCount = 11;
            this.setupBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.setupBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.setupBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.setupBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.setupBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.setupBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.setupBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.setupBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.setupBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.setupBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.setupBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.setupBoardTable.Size = new System.Drawing.Size(367, 338);
            this.setupBoardTable.TabIndex = 1;
            this.setupBoardTable.TabStop = true;
            // 
            // boatsListDataGrid
            // 
            this.boatsListDataGrid.AllowUserToAddRows = false;
            this.boatsListDataGrid.AllowUserToDeleteRows = false;
            this.boatsListDataGrid.AllowUserToResizeColumns = false;
            this.boatsListDataGrid.AllowUserToResizeRows = false;
            this.boatsListDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.boatsListDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.boatNameColumn,
            this.boatLengthColumn,
            this.boatColorColumn,
            this.boatAddColumn,
            this.boatRemoveColumn});
            this.boatsListDataGrid.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.boatsListDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boatsListDataGrid.Location = new System.Drawing.Point(3, 413);
            this.boatsListDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boatsListDataGrid.MultiSelect = false;
            this.boatsListDataGrid.Name = "boatsListDataGrid";
            this.boatsListDataGrid.RowHeadersVisible = false;
            this.boatsListDataGrid.RowHeadersWidth = 51;
            this.boatsListDataGrid.RowTemplate.Height = 24;
            this.boatsListDataGrid.RowTemplate.ReadOnly = true;
            this.boatsListDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.boatsListDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.boatsListDataGrid.Size = new System.Drawing.Size(501, 272);
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
            this.AIDifficultyLabel.AutoSize = true;
            this.AIDifficultyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AIDifficultyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AIDifficultyLabel.Location = new System.Drawing.Point(3, 0);
            this.AIDifficultyLabel.Name = "AIDifficultyLabel";
            this.AIDifficultyLabel.Size = new System.Drawing.Size(213, 33);
            this.AIDifficultyLabel.TabIndex = 3;
            this.AIDifficultyLabel.Text = "AI Difficulty";
            this.AIDifficultyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // startGameButton
            // 
            this.startGameButton.AutoSize = true;
            this.startGameButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.startGameButton.Enabled = false;
            this.startGameButton.Location = new System.Drawing.Point(679, 623);
            this.startGameButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 18);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(163, 46);
            this.startGameButton.TabIndex = 6;
            this.startGameButton.Text = "START";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // setupBoardLabel
            // 
            this.setupBoardLabel.AutoSize = true;
            this.setupBoardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setupBoardLabel.Location = new System.Drawing.Point(4, 0);
            this.setupBoardLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.setupBoardLabel.Name = "setupBoardLabel";
            this.setupBoardLabel.Size = new System.Drawing.Size(108, 25);
            this.setupBoardLabel.TabIndex = 8;
            this.setupBoardLabel.Text = "Your board";
            // 
            // directionLabel
            // 
            this.directionLabel.AutoSize = true;
            this.directionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.directionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directionLabel.Location = new System.Drawing.Point(0, 0);
            this.directionLabel.Margin = new System.Windows.Forms.Padding(0);
            this.directionLabel.Name = "directionLabel";
            this.directionLabel.Size = new System.Drawing.Size(161, 26);
            this.directionLabel.TabIndex = 10;
            this.directionLabel.Text = "Direction of boat";
            this.directionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // placementStatusLabel
            // 
            this.placementStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.placementStatusLabel.AutoSize = true;
            this.placementStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placementStatusLabel.Location = new System.Drawing.Point(4, 391);
            this.placementStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.placementStatusLabel.Name = "placementStatusLabel";
            this.placementStatusLabel.Size = new System.Drawing.Size(0, 20);
            this.placementStatusLabel.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.boatFlowPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.placementStatusLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.boatsListDataGrid, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.boatButtonTable, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.startGameButton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.gameSettingsTabs, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(845, 687);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // boatFlowPanel
            // 
            this.boatFlowPanel.AutoSize = true;
            this.boatFlowPanel.Controls.Add(this.setupBoardLabel);
            this.boatFlowPanel.Controls.Add(this.setupBoardTable);
            this.boatFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boatFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.boatFlowPanel.Location = new System.Drawing.Point(4, 4);
            this.boatFlowPanel.Margin = new System.Windows.Forms.Padding(4);
            this.boatFlowPanel.Name = "boatFlowPanel";
            this.boatFlowPanel.Size = new System.Drawing.Size(499, 369);
            this.boatFlowPanel.TabIndex = 0;
            // 
            // boatButtonTable
            // 
            this.boatButtonTable.ColumnCount = 1;
            this.boatButtonTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.boatButtonTable.Controls.Add(this.directionLabel, 0, 0);
            this.boatButtonTable.Controls.Add(this.boatDirectionButton, 0, 1);
            this.boatButtonTable.Controls.Add(this.unselectBoatButton, 0, 3);
            this.boatButtonTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boatButtonTable.Location = new System.Drawing.Point(511, 415);
            this.boatButtonTable.Margin = new System.Windows.Forms.Padding(4);
            this.boatButtonTable.Name = "boatButtonTable";
            this.boatButtonTable.RowCount = 5;
            this.boatButtonTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.boatButtonTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.boatButtonTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.boatButtonTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.boatButtonTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.boatButtonTable.Size = new System.Drawing.Size(161, 268);
            this.boatButtonTable.TabIndex = 13;
            // 
            // boatDirectionButton
            // 
            this.boatDirectionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boatDirectionButton.Location = new System.Drawing.Point(4, 30);
            this.boatDirectionButton.Margin = new System.Windows.Forms.Padding(4);
            this.boatDirectionButton.Name = "boatDirectionButton";
            this.boatDirectionButton.Size = new System.Drawing.Size(153, 45);
            this.boatDirectionButton.TabIndex = 9;
            this.boatDirectionButton.Text = "Horizontal";
            this.boatDirectionButton.UseVisualStyleBackColor = true;
            this.boatDirectionButton.Click += new System.EventHandler(this.boatDirectionButton_Click);
            // 
            // unselectBoatButton
            // 
            this.unselectBoatButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unselectBoatButton.Location = new System.Drawing.Point(4, 109);
            this.unselectBoatButton.Margin = new System.Windows.Forms.Padding(4);
            this.unselectBoatButton.Name = "unselectBoatButton";
            this.unselectBoatButton.Size = new System.Drawing.Size(153, 45);
            this.unselectBoatButton.TabIndex = 12;
            this.unselectBoatButton.Text = "Unselect booat";
            this.unselectBoatButton.UseVisualStyleBackColor = true;
            this.unselectBoatButton.Visible = false;
            this.unselectBoatButton.Click += new System.EventHandler(this.unselectBoatButton_Click);
            // 
            // gameSettingsTabs
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gameSettingsTabs, 2);
            this.gameSettingsTabs.Controls.Add(this.AITabPage);
            this.gameSettingsTabs.Controls.Add(this.localTabPage);
            this.gameSettingsTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameSettingsTabs.Location = new System.Drawing.Point(511, 4);
            this.gameSettingsTabs.Margin = new System.Windows.Forms.Padding(4);
            this.gameSettingsTabs.Name = "gameSettingsTabs";
            this.gameSettingsTabs.SelectedIndex = 0;
            this.gameSettingsTabs.Size = new System.Drawing.Size(330, 369);
            this.gameSettingsTabs.TabIndex = 14;
            // 
            // AITabPage
            // 
            this.AITabPage.Controls.Add(this.tableLayoutPanel2);
            this.AITabPage.Location = new System.Drawing.Point(4, 25);
            this.AITabPage.Margin = new System.Windows.Forms.Padding(4);
            this.AITabPage.Name = "AITabPage";
            this.AITabPage.Padding = new System.Windows.Forms.Padding(4);
            this.AITabPage.Size = new System.Drawing.Size(322, 340);
            this.AITabPage.TabIndex = 0;
            this.AITabPage.Text = "AI";
            this.AITabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.AIDifficultyLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.hardAIRadio, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.regularAIRadio, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.easyAIRadio, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(314, 332);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // hardAIRadio
            // 
            this.hardAIRadio.AutoSize = true;
            this.hardAIRadio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hardAIRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardAIRadio.Location = new System.Drawing.Point(3, 101);
            this.hardAIRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hardAIRadio.Name = "hardAIRadio";
            this.hardAIRadio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.hardAIRadio.Size = new System.Drawing.Size(213, 29);
            this.hardAIRadio.TabIndex = 7;
            this.hardAIRadio.Text = "Hard";
            this.hardAIRadio.UseVisualStyleBackColor = true;
            // 
            // regularAIRadio
            // 
            this.regularAIRadio.AutoSize = true;
            this.regularAIRadio.Checked = true;
            this.regularAIRadio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.regularAIRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regularAIRadio.Location = new System.Drawing.Point(3, 68);
            this.regularAIRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.regularAIRadio.Name = "regularAIRadio";
            this.regularAIRadio.Size = new System.Drawing.Size(213, 29);
            this.regularAIRadio.TabIndex = 5;
            this.regularAIRadio.TabStop = true;
            this.regularAIRadio.Text = "Regular";
            this.regularAIRadio.UseVisualStyleBackColor = true;
            // 
            // easyAIRadio
            // 
            this.easyAIRadio.AutoSize = true;
            this.easyAIRadio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.easyAIRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyAIRadio.Location = new System.Drawing.Point(3, 35);
            this.easyAIRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.easyAIRadio.Name = "easyAIRadio";
            this.easyAIRadio.Size = new System.Drawing.Size(213, 29);
            this.easyAIRadio.TabIndex = 4;
            this.easyAIRadio.Text = "Easy";
            this.easyAIRadio.UseVisualStyleBackColor = true;
            // 
            // localTabPage
            // 
            this.localTabPage.Controls.Add(this.label1);
            this.localTabPage.Location = new System.Drawing.Point(4, 25);
            this.localTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.localTabPage.Name = "localTabPage";
            this.localTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.localTabPage.Size = new System.Drawing.Size(322, 340);
            this.localTabPage.TabIndex = 1;
            this.localTabPage.Text = "Local";
            this.localTabPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Not available yet";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SetupBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(845, 715);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(861, 752);
            this.Name = "SetupBoardForm";
            this.Text = "Play against AI";
            this.Load += new System.EventHandler(this.playAgainstAIForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boatsListDataGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.boatFlowPanel.ResumeLayout(false);
            this.boatFlowPanel.PerformLayout();
            this.boatButtonTable.ResumeLayout(false);
            this.boatButtonTable.PerformLayout();
            this.gameSettingsTabs.ResumeLayout(false);
            this.AITabPage.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.localTabPage.ResumeLayout(false);
            this.localTabPage.PerformLayout();
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
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Label setupBoardLabel;
        private System.Windows.Forms.Label directionLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn boatNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boatLengthColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boatColorColumn;
        private System.Windows.Forms.DataGridViewButtonColumn boatAddColumn;
        private System.Windows.Forms.DataGridViewButtonColumn boatRemoveColumn;
        private System.Windows.Forms.Label placementStatusLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel boatFlowPanel;
        private System.Windows.Forms.TableLayoutPanel boatButtonTable;
        private System.Windows.Forms.Button boatDirectionButton;
        private System.Windows.Forms.Button unselectBoatButton;
        private System.Windows.Forms.TabControl gameSettingsTabs;
        private System.Windows.Forms.TabPage AITabPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TabPage localTabPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton hardAIRadio;
        private System.Windows.Forms.RadioButton regularAIRadio;
        private System.Windows.Forms.RadioButton easyAIRadio;
    }
}