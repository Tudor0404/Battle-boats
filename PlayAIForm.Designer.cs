
namespace Battle_boats {
    partial class playAgainstAIForm {
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeBoatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBoatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadBoatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boardSetupTable = new System.Windows.Forms.TableLayoutPanel();
            this.axis1Label = new System.Windows.Forms.Label();
            this.axis2Label = new System.Windows.Forms.Label();
            this.axis3Label = new System.Windows.Forms.Label();
            this.axis4Label = new System.Windows.Forms.Label();
            this.axis5Label = new System.Windows.Forms.Label();
            this.axis6Label = new System.Windows.Forms.Label();
            this.axis7Label = new System.Windows.Forms.Label();
            this.axis8Label = new System.Windows.Forms.Label();
            this.axis9Label = new System.Windows.Forms.Label();
            this.axis10Label = new System.Windows.Forms.Label();
            this.axisJLabel = new System.Windows.Forms.Label();
            this.axisILabel = new System.Windows.Forms.Label();
            this.axisHLabel = new System.Windows.Forms.Label();
            this.axisGLabel = new System.Windows.Forms.Label();
            this.axisFLabel = new System.Windows.Forms.Label();
            this.axisELabel = new System.Windows.Forms.Label();
            this.axisDLabel = new System.Windows.Forms.Label();
            this.axisCLabel = new System.Windows.Forms.Label();
            this.axisBLabel = new System.Windows.Forms.Label();
            this.axisALabel = new System.Windows.Forms.Label();
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
            this.yourBoardLabel = new System.Windows.Forms.Label();
            this.boatDirectionButton = new System.Windows.Forms.Button();
            this.directionLabel = new System.Windows.Forms.Label();
            this.placementStatusLabel = new System.Windows.Forms.Label();
            this.unselectBoatButton = new System.Windows.Forms.Button();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip.SuspendLayout();
            this.boardSetupTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boatsListDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
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
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.changeBoatsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changeBoatsToolStripMenuItem.Text = "Change boats";
            this.changeBoatsToolStripMenuItem.Click += new System.EventHandler(this.changeBoatsToolStripMenuItem_Click);
            // 
            // saveBoatsToolStripMenuItem
            // 
            this.saveBoatsToolStripMenuItem.Name = "saveBoatsToolStripMenuItem";
            this.saveBoatsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveBoatsToolStripMenuItem.Text = "Save boats";
            // 
            // loadBoatsToolStripMenuItem
            // 
            this.loadBoatsToolStripMenuItem.Name = "loadBoatsToolStripMenuItem";
            this.loadBoatsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadBoatsToolStripMenuItem.Text = "Load boats";
            // 
            // boardSetupTable
            // 
            this.boardSetupTable.AutoSize = true;
            this.boardSetupTable.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.boardSetupTable.ColumnCount = 11;
            this.boardSetupTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.boardSetupTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.boardSetupTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.boardSetupTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.boardSetupTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.boardSetupTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.boardSetupTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.boardSetupTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.boardSetupTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.boardSetupTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.boardSetupTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.boardSetupTable.Controls.Add(this.axis1Label, 0, 1);
            this.boardSetupTable.Controls.Add(this.axis2Label, 0, 2);
            this.boardSetupTable.Controls.Add(this.axis3Label, 0, 3);
            this.boardSetupTable.Controls.Add(this.axis4Label, 0, 4);
            this.boardSetupTable.Controls.Add(this.axis5Label, 0, 5);
            this.boardSetupTable.Controls.Add(this.axis6Label, 0, 6);
            this.boardSetupTable.Controls.Add(this.axis7Label, 0, 7);
            this.boardSetupTable.Controls.Add(this.axis8Label, 0, 8);
            this.boardSetupTable.Controls.Add(this.axis9Label, 0, 9);
            this.boardSetupTable.Controls.Add(this.axis10Label, 0, 10);
            this.boardSetupTable.Controls.Add(this.axisJLabel, 10, 0);
            this.boardSetupTable.Controls.Add(this.axisILabel, 9, 0);
            this.boardSetupTable.Controls.Add(this.axisHLabel, 8, 0);
            this.boardSetupTable.Controls.Add(this.axisGLabel, 7, 0);
            this.boardSetupTable.Controls.Add(this.axisFLabel, 6, 0);
            this.boardSetupTable.Controls.Add(this.axisELabel, 5, 0);
            this.boardSetupTable.Controls.Add(this.axisDLabel, 4, 0);
            this.boardSetupTable.Controls.Add(this.axisCLabel, 3, 0);
            this.boardSetupTable.Controls.Add(this.axisBLabel, 2, 0);
            this.boardSetupTable.Controls.Add(this.axisALabel, 1, 0);
            this.boardSetupTable.Location = new System.Drawing.Point(11, 48);
            this.boardSetupTable.Margin = new System.Windows.Forms.Padding(2);
            this.boardSetupTable.Name = "boardSetupTable";
            this.boardSetupTable.RowCount = 11;
            this.boardSetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.boardSetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.boardSetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.boardSetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.boardSetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.boardSetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.boardSetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.boardSetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.boardSetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.boardSetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.boardSetupTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.boardSetupTable.Size = new System.Drawing.Size(275, 275);
            this.boardSetupTable.TabIndex = 1;
            this.boardSetupTable.TabStop = true;
            // 
            // axis1Label
            // 
            this.axis1Label.AutoSize = true;
            this.axis1Label.BackColor = System.Drawing.SystemColors.Window;
            this.axis1Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axis1Label.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.axis1Label.Location = new System.Drawing.Point(0, 25);
            this.axis1Label.Margin = new System.Windows.Forms.Padding(0);
            this.axis1Label.Name = "axis1Label";
            this.axis1Label.Size = new System.Drawing.Size(25, 25);
            this.axis1Label.TabIndex = 19;
            this.axis1Label.Text = "1";
            this.axis1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // axis2Label
            // 
            this.axis2Label.AutoSize = true;
            this.axis2Label.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.axis2Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axis2Label.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.axis2Label.Location = new System.Drawing.Point(0, 50);
            this.axis2Label.Margin = new System.Windows.Forms.Padding(0);
            this.axis2Label.Name = "axis2Label";
            this.axis2Label.Size = new System.Drawing.Size(25, 25);
            this.axis2Label.TabIndex = 18;
            this.axis2Label.Text = "2";
            this.axis2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // axis3Label
            // 
            this.axis3Label.AutoSize = true;
            this.axis3Label.BackColor = System.Drawing.SystemColors.Window;
            this.axis3Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axis3Label.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.axis3Label.Location = new System.Drawing.Point(0, 75);
            this.axis3Label.Margin = new System.Windows.Forms.Padding(0);
            this.axis3Label.Name = "axis3Label";
            this.axis3Label.Size = new System.Drawing.Size(25, 25);
            this.axis3Label.TabIndex = 17;
            this.axis3Label.Text = "3";
            this.axis3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // axis4Label
            // 
            this.axis4Label.AutoSize = true;
            this.axis4Label.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.axis4Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axis4Label.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.axis4Label.Location = new System.Drawing.Point(0, 100);
            this.axis4Label.Margin = new System.Windows.Forms.Padding(0);
            this.axis4Label.Name = "axis4Label";
            this.axis4Label.Size = new System.Drawing.Size(25, 25);
            this.axis4Label.TabIndex = 16;
            this.axis4Label.Text = "4";
            this.axis4Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // axis5Label
            // 
            this.axis5Label.AutoSize = true;
            this.axis5Label.BackColor = System.Drawing.SystemColors.Window;
            this.axis5Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axis5Label.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.axis5Label.Location = new System.Drawing.Point(0, 125);
            this.axis5Label.Margin = new System.Windows.Forms.Padding(0);
            this.axis5Label.Name = "axis5Label";
            this.axis5Label.Size = new System.Drawing.Size(25, 25);
            this.axis5Label.TabIndex = 15;
            this.axis5Label.Text = "5";
            this.axis5Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // axis6Label
            // 
            this.axis6Label.AutoSize = true;
            this.axis6Label.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.axis6Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axis6Label.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.axis6Label.Location = new System.Drawing.Point(0, 150);
            this.axis6Label.Margin = new System.Windows.Forms.Padding(0);
            this.axis6Label.Name = "axis6Label";
            this.axis6Label.Size = new System.Drawing.Size(25, 25);
            this.axis6Label.TabIndex = 14;
            this.axis6Label.Text = "6";
            this.axis6Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // axis7Label
            // 
            this.axis7Label.AutoSize = true;
            this.axis7Label.BackColor = System.Drawing.SystemColors.Window;
            this.axis7Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axis7Label.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.axis7Label.Location = new System.Drawing.Point(0, 175);
            this.axis7Label.Margin = new System.Windows.Forms.Padding(0);
            this.axis7Label.Name = "axis7Label";
            this.axis7Label.Size = new System.Drawing.Size(25, 25);
            this.axis7Label.TabIndex = 13;
            this.axis7Label.Text = "7";
            this.axis7Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // axis8Label
            // 
            this.axis8Label.AutoSize = true;
            this.axis8Label.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.axis8Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axis8Label.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.axis8Label.Location = new System.Drawing.Point(0, 200);
            this.axis8Label.Margin = new System.Windows.Forms.Padding(0);
            this.axis8Label.Name = "axis8Label";
            this.axis8Label.Size = new System.Drawing.Size(25, 25);
            this.axis8Label.TabIndex = 12;
            this.axis8Label.Text = "8";
            this.axis8Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // axis9Label
            // 
            this.axis9Label.AutoSize = true;
            this.axis9Label.BackColor = System.Drawing.SystemColors.Window;
            this.axis9Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axis9Label.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.axis9Label.Location = new System.Drawing.Point(0, 225);
            this.axis9Label.Margin = new System.Windows.Forms.Padding(0);
            this.axis9Label.Name = "axis9Label";
            this.axis9Label.Size = new System.Drawing.Size(25, 25);
            this.axis9Label.TabIndex = 11;
            this.axis9Label.Text = "9";
            this.axis9Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // axis10Label
            // 
            this.axis10Label.AutoSize = true;
            this.axis10Label.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.axis10Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axis10Label.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.axis10Label.Location = new System.Drawing.Point(0, 250);
            this.axis10Label.Margin = new System.Windows.Forms.Padding(0);
            this.axis10Label.Name = "axis10Label";
            this.axis10Label.Size = new System.Drawing.Size(25, 25);
            this.axis10Label.TabIndex = 10;
            this.axis10Label.Text = "10";
            this.axis10Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // axisJLabel
            // 
            this.axisJLabel.AutoSize = true;
            this.axisJLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.axisJLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axisJLabel.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.axisJLabel.Location = new System.Drawing.Point(250, 0);
            this.axisJLabel.Margin = new System.Windows.Forms.Padding(0);
            this.axisJLabel.Name = "axisJLabel";
            this.axisJLabel.Size = new System.Drawing.Size(25, 25);
            this.axisJLabel.TabIndex = 9;
            this.axisJLabel.Text = "J";
            this.axisJLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // axisILabel
            // 
            this.axisILabel.AutoSize = true;
            this.axisILabel.BackColor = System.Drawing.SystemColors.Window;
            this.axisILabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axisILabel.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.axisILabel.Location = new System.Drawing.Point(225, 0);
            this.axisILabel.Margin = new System.Windows.Forms.Padding(0);
            this.axisILabel.Name = "axisILabel";
            this.axisILabel.Size = new System.Drawing.Size(25, 25);
            this.axisILabel.TabIndex = 8;
            this.axisILabel.Text = "I";
            this.axisILabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // axisHLabel
            // 
            this.axisHLabel.AutoSize = true;
            this.axisHLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axisHLabel.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.axisHLabel.Location = new System.Drawing.Point(200, 0);
            this.axisHLabel.Margin = new System.Windows.Forms.Padding(0);
            this.axisHLabel.Name = "axisHLabel";
            this.axisHLabel.Size = new System.Drawing.Size(25, 25);
            this.axisHLabel.TabIndex = 7;
            this.axisHLabel.Text = "H";
            this.axisHLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // axisGLabel
            // 
            this.axisGLabel.AutoSize = true;
            this.axisGLabel.BackColor = System.Drawing.SystemColors.Window;
            this.axisGLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axisGLabel.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.axisGLabel.Location = new System.Drawing.Point(175, 0);
            this.axisGLabel.Margin = new System.Windows.Forms.Padding(0);
            this.axisGLabel.Name = "axisGLabel";
            this.axisGLabel.Size = new System.Drawing.Size(25, 25);
            this.axisGLabel.TabIndex = 6;
            this.axisGLabel.Text = "G";
            this.axisGLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // axisFLabel
            // 
            this.axisFLabel.AutoSize = true;
            this.axisFLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axisFLabel.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.axisFLabel.Location = new System.Drawing.Point(150, 0);
            this.axisFLabel.Margin = new System.Windows.Forms.Padding(0);
            this.axisFLabel.Name = "axisFLabel";
            this.axisFLabel.Size = new System.Drawing.Size(25, 25);
            this.axisFLabel.TabIndex = 5;
            this.axisFLabel.Text = "F";
            this.axisFLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // axisELabel
            // 
            this.axisELabel.AutoSize = true;
            this.axisELabel.BackColor = System.Drawing.SystemColors.Window;
            this.axisELabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axisELabel.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.axisELabel.Location = new System.Drawing.Point(125, 0);
            this.axisELabel.Margin = new System.Windows.Forms.Padding(0);
            this.axisELabel.Name = "axisELabel";
            this.axisELabel.Size = new System.Drawing.Size(25, 25);
            this.axisELabel.TabIndex = 4;
            this.axisELabel.Text = "E";
            this.axisELabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // axisDLabel
            // 
            this.axisDLabel.AutoSize = true;
            this.axisDLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axisDLabel.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.axisDLabel.Location = new System.Drawing.Point(100, 0);
            this.axisDLabel.Margin = new System.Windows.Forms.Padding(0);
            this.axisDLabel.Name = "axisDLabel";
            this.axisDLabel.Size = new System.Drawing.Size(25, 25);
            this.axisDLabel.TabIndex = 3;
            this.axisDLabel.Text = "D";
            this.axisDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // axisCLabel
            // 
            this.axisCLabel.AutoSize = true;
            this.axisCLabel.BackColor = System.Drawing.SystemColors.Window;
            this.axisCLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axisCLabel.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.axisCLabel.Location = new System.Drawing.Point(75, 0);
            this.axisCLabel.Margin = new System.Windows.Forms.Padding(0);
            this.axisCLabel.Name = "axisCLabel";
            this.axisCLabel.Size = new System.Drawing.Size(25, 25);
            this.axisCLabel.TabIndex = 2;
            this.axisCLabel.Text = "C";
            this.axisCLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // axisBLabel
            // 
            this.axisBLabel.AutoSize = true;
            this.axisBLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axisBLabel.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.axisBLabel.Location = new System.Drawing.Point(50, 0);
            this.axisBLabel.Margin = new System.Windows.Forms.Padding(0);
            this.axisBLabel.Name = "axisBLabel";
            this.axisBLabel.Size = new System.Drawing.Size(25, 25);
            this.axisBLabel.TabIndex = 1;
            this.axisBLabel.Text = "B";
            this.axisBLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // axisALabel
            // 
            this.axisALabel.AutoSize = true;
            this.axisALabel.BackColor = System.Drawing.SystemColors.Window;
            this.axisALabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axisALabel.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.axisALabel.Location = new System.Drawing.Point(25, 0);
            this.axisALabel.Margin = new System.Windows.Forms.Padding(0);
            this.axisALabel.Name = "axisALabel";
            this.axisALabel.Size = new System.Drawing.Size(25, 25);
            this.axisALabel.TabIndex = 0;
            this.axisALabel.Text = "A";
            this.axisALabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.boatsListDataGrid.Location = new System.Drawing.Point(11, 376);
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
            this.Index.Name = "Index";
            this.Index.Visible = false;
            // 
            // boatNameColumn
            // 
            this.boatNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.boatNameColumn.HeaderText = "Name";
            this.boatNameColumn.Name = "boatNameColumn";
            this.boatNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // boatLengthColumn
            // 
            this.boatLengthColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.boatLengthColumn.HeaderText = "Length";
            this.boatLengthColumn.Name = "boatLengthColumn";
            this.boatLengthColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // boatColorColumn
            // 
            this.boatColorColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.boatColorColumn.HeaderText = "Color";
            this.boatColorColumn.Name = "boatColorColumn";
            this.boatColorColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // boatAddColumn
            // 
            this.boatAddColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.boatAddColumn.HeaderText = "Add";
            this.boatAddColumn.Name = "boatAddColumn";
            this.boatAddColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.boatAddColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // boatRemoveColumn
            // 
            this.boatRemoveColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.boatRemoveColumn.HeaderText = "Remove";
            this.boatRemoveColumn.Name = "boatRemoveColumn";
            this.boatRemoveColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.boatRemoveColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // AIDifficultyLabel
            // 
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
            this.startGameButton.Enabled = false;
            this.startGameButton.Location = new System.Drawing.Point(482, 513);
            this.startGameButton.Margin = new System.Windows.Forms.Padding(2);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(141, 37);
            this.startGameButton.TabIndex = 6;
            this.startGameButton.Text = "START";
            this.startGameButton.UseVisualStyleBackColor = true;
            // 
            // hardAIButton
            // 
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
            // yourBoardLabel
            // 
            this.yourBoardLabel.AutoSize = true;
            this.yourBoardLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourBoardLabel.Location = new System.Drawing.Point(7, 27);
            this.yourBoardLabel.Name = "yourBoardLabel";
            this.yourBoardLabel.Size = new System.Drawing.Size(86, 19);
            this.yourBoardLabel.TabIndex = 8;
            this.yourBoardLabel.Text = "Your board";
            // 
            // boatDirectionButton
            // 
            this.boatDirectionButton.Location = new System.Drawing.Point(365, 345);
            this.boatDirectionButton.Name = "boatDirectionButton";
            this.boatDirectionButton.Size = new System.Drawing.Size(113, 26);
            this.boatDirectionButton.TabIndex = 9;
            this.boatDirectionButton.Text = "Horizontal";
            this.boatDirectionButton.UseVisualStyleBackColor = true;
            this.boatDirectionButton.Click += new System.EventHandler(this.boatDirectionButton_Click);
            // 
            // directionLabel
            // 
            this.directionLabel.AutoSize = true;
            this.directionLabel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directionLabel.Location = new System.Drawing.Point(362, 327);
            this.directionLabel.Name = "directionLabel";
            this.directionLabel.Size = new System.Drawing.Size(101, 15);
            this.directionLabel.TabIndex = 10;
            this.directionLabel.Text = "Direction of boat";
            // 
            // placementStatusLabel
            // 
            this.placementStatusLabel.AutoSize = true;
            this.placementStatusLabel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placementStatusLabel.Location = new System.Drawing.Point(13, 356);
            this.placementStatusLabel.Name = "placementStatusLabel";
            this.placementStatusLabel.Size = new System.Drawing.Size(0, 15);
            this.placementStatusLabel.TabIndex = 11;
            // 
            // unselectBoatButton
            // 
            this.unselectBoatButton.Location = new System.Drawing.Point(246, 345);
            this.unselectBoatButton.Name = "unselectBoatButton";
            this.unselectBoatButton.Size = new System.Drawing.Size(113, 26);
            this.unselectBoatButton.TabIndex = 12;
            this.unselectBoatButton.Text = "Unselect booat";
            this.unselectBoatButton.UseVisualStyleBackColor = true;
            this.unselectBoatButton.Visible = false;
            this.unselectBoatButton.Click += new System.EventHandler(this.unselectBoatButton_Click);
            // 
            // playAgainstAIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(634, 561);
            this.Controls.Add(this.unselectBoatButton);
            this.Controls.Add(this.placementStatusLabel);
            this.Controls.Add(this.directionLabel);
            this.Controls.Add(this.boatDirectionButton);
            this.Controls.Add(this.yourBoardLabel);
            this.Controls.Add(this.hardAIButton);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.regularAIRadio);
            this.Controls.Add(this.easyAIRadio);
            this.Controls.Add(this.AIDifficultyLabel);
            this.Controls.Add(this.boatsListDataGrid);
            this.Controls.Add(this.boardSetupTable);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(650, 600);
            this.MinimumSize = new System.Drawing.Size(650, 600);
            this.Name = "playAgainstAIForm";
            this.Text = "Play against AI";
            this.Load += new System.EventHandler(this.playAgainstAIForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.boardSetupTable.ResumeLayout(false);
            this.boardSetupTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boatsListDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
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
        private System.Windows.Forms.TableLayoutPanel boardSetupTable;
        private System.Windows.Forms.DataGridView boatsListDataGrid;
        private System.Windows.Forms.Label axisALabel;
        private System.Windows.Forms.Label axisGLabel;
        private System.Windows.Forms.Label axisFLabel;
        private System.Windows.Forms.Label axisELabel;
        private System.Windows.Forms.Label axisDLabel;
        private System.Windows.Forms.Label axisCLabel;
        private System.Windows.Forms.Label axisBLabel;
        private System.Windows.Forms.Label axisILabel;
        private System.Windows.Forms.Label axisHLabel;
        private System.Windows.Forms.Label axisJLabel;
        private System.Windows.Forms.Label axis1Label;
        private System.Windows.Forms.Label axis2Label;
        private System.Windows.Forms.Label axis3Label;
        private System.Windows.Forms.Label axis4Label;
        private System.Windows.Forms.Label axis5Label;
        private System.Windows.Forms.Label axis6Label;
        private System.Windows.Forms.Label axis7Label;
        private System.Windows.Forms.Label axis8Label;
        private System.Windows.Forms.Label axis9Label;
        private System.Windows.Forms.Label axis10Label;
        private System.Windows.Forms.Label AIDifficultyLabel;
        private System.Windows.Forms.RadioButton easyAIRadio;
        private System.Windows.Forms.RadioButton regularAIRadio;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.RadioButton hardAIButton;
        private System.Windows.Forms.Label yourBoardLabel;
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
    }
}