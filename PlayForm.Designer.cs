
namespace Battle_boats {
    partial class PlayForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayForm));
            this.playPanel = new System.Windows.Forms.Panel();
            this.opponentStatusLabel = new System.Windows.Forms.Label();
            this.shotStatusLabel = new System.Windows.Forms.Label();
            this.currentActionLabel = new System.Windows.Forms.Label();
            this.LegendLabel = new System.Windows.Forms.Label();
            this.logListView = new System.Windows.Forms.ListView();
            this.logLabel = new System.Windows.Forms.Label();
            this.opponentBoardLabel = new System.Windows.Forms.Label();
            this.yourBoardLabel = new System.Windows.Forms.Label();
            this.opponentBoardTable = new System.Windows.Forms.TableLayoutPanel();
            this.playerBoardTable = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playPanel.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // playPanel
            // 
            this.playPanel.Controls.Add(this.opponentStatusLabel);
            this.playPanel.Controls.Add(this.shotStatusLabel);
            this.playPanel.Controls.Add(this.currentActionLabel);
            this.playPanel.Controls.Add(this.LegendLabel);
            this.playPanel.Controls.Add(this.logListView);
            this.playPanel.Controls.Add(this.logLabel);
            this.playPanel.Controls.Add(this.opponentBoardLabel);
            this.playPanel.Controls.Add(this.yourBoardLabel);
            this.playPanel.Controls.Add(this.opponentBoardTable);
            this.playPanel.Controls.Add(this.playerBoardTable);
            this.playPanel.Location = new System.Drawing.Point(0, 33);
            this.playPanel.Margin = new System.Windows.Forms.Padding(4);
            this.playPanel.Name = "playPanel";
            this.playPanel.Size = new System.Drawing.Size(845, 644);
            this.playPanel.TabIndex = 14;
            // 
            // opponentStatusLabel
            // 
            this.opponentStatusLabel.AutoSize = true;
            this.opponentStatusLabel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opponentStatusLabel.Location = new System.Drawing.Point(391, 554);
            this.opponentStatusLabel.Name = "opponentStatusLabel";
            this.opponentStatusLabel.Size = new System.Drawing.Size(0, 18);
            this.opponentStatusLabel.TabIndex = 17;
            // 
            // shotStatusLabel
            // 
            this.shotStatusLabel.AutoSize = true;
            this.shotStatusLabel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shotStatusLabel.Location = new System.Drawing.Point(391, 516);
            this.shotStatusLabel.Name = "shotStatusLabel";
            this.shotStatusLabel.Size = new System.Drawing.Size(0, 18);
            this.shotStatusLabel.TabIndex = 16;
            // 
            // currentActionLabel
            // 
            this.currentActionLabel.AutoSize = true;
            this.currentActionLabel.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentActionLabel.Location = new System.Drawing.Point(391, 448);
            this.currentActionLabel.Name = "currentActionLabel";
            this.currentActionLabel.Size = new System.Drawing.Size(132, 23);
            this.currentActionLabel.TabIndex = 15;
            this.currentActionLabel.Text = "Current action:";
            // 
            // LegendLabel
            // 
            this.LegendLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LegendLabel.AutoSize = true;
            this.LegendLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LegendLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LegendLabel.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LegendLabel.Location = new System.Drawing.Point(298, 393);
            this.LegendLabel.Margin = new System.Windows.Forms.Padding(0);
            this.LegendLabel.Name = "LegendLabel";
            this.LegendLabel.Padding = new System.Windows.Forms.Padding(3);
            this.LegendLabel.Size = new System.Drawing.Size(86, 52);
            this.LegendLabel.TabIndex = 14;
            this.LegendLabel.Text = "○ : Miss\r\n✕ : Hit";
            // 
            // logListView
            // 
            this.logListView.FullRowSelect = true;
            this.logListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.logListView.HideSelection = false;
            this.logListView.Location = new System.Drawing.Point(15, 448);
            this.logListView.Margin = new System.Windows.Forms.Padding(4);
            this.logListView.MultiSelect = false;
            this.logListView.Name = "logListView";
            this.logListView.Size = new System.Drawing.Size(369, 191);
            this.logListView.TabIndex = 13;
            this.logListView.UseCompatibleStateImageBehavior = false;
            this.logListView.View = System.Windows.Forms.View.Details;
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logLabel.Location = new System.Drawing.Point(9, 420);
            this.logLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(45, 25);
            this.logLabel.TabIndex = 12;
            this.logLabel.Text = "Log";
            // 
            // opponentBoardLabel
            // 
            this.opponentBoardLabel.AutoSize = true;
            this.opponentBoardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opponentBoardLabel.Location = new System.Drawing.Point(455, 23);
            this.opponentBoardLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.opponentBoardLabel.Name = "opponentBoardLabel";
            this.opponentBoardLabel.Size = new System.Drawing.Size(168, 25);
            this.opponentBoardLabel.TabIndex = 10;
            this.opponentBoardLabel.Text = "Opponent\'s board";
            // 
            // yourBoardLabel
            // 
            this.yourBoardLabel.AutoSize = true;
            this.yourBoardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourBoardLabel.Location = new System.Drawing.Point(9, 23);
            this.yourBoardLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yourBoardLabel.Name = "yourBoardLabel";
            this.yourBoardLabel.Size = new System.Drawing.Size(108, 25);
            this.yourBoardLabel.TabIndex = 9;
            this.yourBoardLabel.Text = "Your board";
            // 
            // opponentBoardTable
            // 
            this.opponentBoardTable.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.opponentBoardTable.ColumnCount = 11;
            this.opponentBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.opponentBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.opponentBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.opponentBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.opponentBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.opponentBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.opponentBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.opponentBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.opponentBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.opponentBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.opponentBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.opponentBoardTable.Location = new System.Drawing.Point(460, 49);
            this.opponentBoardTable.Margin = new System.Windows.Forms.Padding(0);
            this.opponentBoardTable.Name = "opponentBoardTable";
            this.opponentBoardTable.RowCount = 11;
            this.opponentBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.opponentBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.opponentBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.opponentBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.opponentBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.opponentBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.opponentBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.opponentBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.opponentBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.opponentBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.opponentBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.opponentBoardTable.Size = new System.Drawing.Size(371, 341);
            this.opponentBoardTable.TabIndex = 3;
            this.opponentBoardTable.TabStop = true;
            // 
            // playerBoardTable
            // 
            this.playerBoardTable.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.playerBoardTable.ColumnCount = 11;
            this.playerBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.playerBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.playerBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.playerBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.playerBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.playerBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.playerBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.playerBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.playerBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.playerBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.playerBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.playerBoardTable.Location = new System.Drawing.Point(15, 49);
            this.playerBoardTable.Margin = new System.Windows.Forms.Padding(0);
            this.playerBoardTable.Name = "playerBoardTable";
            this.playerBoardTable.RowCount = 11;
            this.playerBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.playerBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.playerBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.playerBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.playerBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.playerBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.playerBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.playerBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.playerBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.playerBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.playerBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.playerBoardTable.Size = new System.Drawing.Size(371, 341);
            this.playerBoardTable.TabIndex = 2;
            this.playerBoardTable.TabStop = true;
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(843, 28);
            this.menuStrip.TabIndex = 15;
            this.menuStrip.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 679);
            this.Controls.Add(this.playPanel);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(861, 726);
            this.MinimumSize = new System.Drawing.Size(861, 726);
            this.Name = "PlayForm";
            this.Text = "Battleships";
            this.Load += new System.EventHandler(this.PlayForm_Load);
            this.playPanel.ResumeLayout(false);
            this.playPanel.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel playPanel;
        private System.Windows.Forms.Label logLabel;
        private System.Windows.Forms.Label opponentBoardLabel;
        private System.Windows.Forms.Label yourBoardLabel;
        private System.Windows.Forms.TableLayoutPanel opponentBoardTable;
        private System.Windows.Forms.TableLayoutPanel playerBoardTable;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ListView logListView;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Label LegendLabel;
        private System.Windows.Forms.Label currentActionLabel;
        private System.Windows.Forms.Label shotStatusLabel;
        private System.Windows.Forms.Label opponentStatusLabel;
    }
}