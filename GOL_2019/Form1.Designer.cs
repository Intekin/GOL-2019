namespace GOL_2019
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_GameMode = new System.Windows.Forms.ComboBox();
            this.tb_NameOfGame = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_StartNewGame = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Load = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbx_SavedGames = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GameGrid = new System.Windows.Forms.DataGridView();
            this.btn_NextGeneration = new System.Windows.Forms.Button();
            this.btn_SaveGame = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arkivToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nud_X = new System.Windows.Forms.NumericUpDown();
            this.nud_Y = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Y)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nud_Y);
            this.groupBox1.Controls.Add(this.nud_X);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_GameMode);
            this.groupBox1.Controls.Add(this.tb_NameOfGame);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_StartNewGame);
            this.groupBox1.Controls.Add(this.btn_Delete);
            this.groupBox1.Controls.Add(this.btn_Load);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbx_SavedGames);
            this.groupBox1.Location = new System.Drawing.Point(8, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(202, 401);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Game Mode";
            // 
            // cb_GameMode
            // 
            this.cb_GameMode.FormattingEnabled = true;
            this.cb_GameMode.Location = new System.Drawing.Point(108, 27);
            this.cb_GameMode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_GameMode.Name = "cb_GameMode";
            this.cb_GameMode.Size = new System.Drawing.Size(90, 21);
            this.cb_GameMode.TabIndex = 8;
            this.cb_GameMode.SelectedIndexChanged += new System.EventHandler(this.cb_GameMode_SelectedIndexChanged);
            // 
            // tb_NameOfGame
            // 
            this.tb_NameOfGame.Location = new System.Drawing.Point(7, 27);
            this.tb_NameOfGame.Margin = new System.Windows.Forms.Padding(2);
            this.tb_NameOfGame.MaxLength = 18;
            this.tb_NameOfGame.Name = "tb_NameOfGame";
            this.tb_NameOfGame.Size = new System.Drawing.Size(90, 20);
            this.tb_NameOfGame.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // btn_StartNewGame
            // 
            this.btn_StartNewGame.Location = new System.Drawing.Point(109, 160);
            this.btn_StartNewGame.Margin = new System.Windows.Forms.Padding(2);
            this.btn_StartNewGame.Name = "btn_StartNewGame";
            this.btn_StartNewGame.Size = new System.Drawing.Size(89, 28);
            this.btn_StartNewGame.TabIndex = 6;
            this.btn_StartNewGame.Text = "Start new game";
            this.btn_StartNewGame.UseVisualStyleBackColor = true;
            this.btn_StartNewGame.Click += new System.EventHandler(this.btn_StartNewGame_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(113, 375);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(85, 19);
            this.btn_Delete.TabIndex = 5;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(8, 375);
            this.btn_Load.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(101, 19);
            this.btn_Load.TabIndex = 4;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 191);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Saved Games";
            // 
            // lbx_SavedGames
            // 
            this.lbx_SavedGames.FormattingEnabled = true;
            this.lbx_SavedGames.Location = new System.Drawing.Point(4, 206);
            this.lbx_SavedGames.Margin = new System.Windows.Forms.Padding(2);
            this.lbx_SavedGames.Name = "lbx_SavedGames";
            this.lbx_SavedGames.Size = new System.Drawing.Size(187, 160);
            this.lbx_SavedGames.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_SaveGame);
            this.groupBox2.Controls.Add(this.GameGrid);
            this.groupBox2.Controls.Add(this.btn_NextGeneration);
            this.groupBox2.Location = new System.Drawing.Point(212, 34);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(519, 399);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Game Of Life";
            // 
            // GameGrid
            // 
            this.GameGrid.AllowUserToAddRows = false;
            this.GameGrid.AllowUserToDeleteRows = false;
            this.GameGrid.AllowUserToResizeColumns = false;
            this.GameGrid.AllowUserToResizeRows = false;
            this.GameGrid.CausesValidation = false;
            this.GameGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GameGrid.Enabled = false;
            this.GameGrid.Location = new System.Drawing.Point(4, 14);
            this.GameGrid.Margin = new System.Windows.Forms.Padding(2);
            this.GameGrid.MultiSelect = false;
            this.GameGrid.Name = "GameGrid";
            this.GameGrid.ReadOnly = true;
            this.GameGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GameGrid.RowTemplate.Height = 24;
            this.GameGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.GameGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GameGrid.Size = new System.Drawing.Size(512, 352);
            this.GameGrid.TabIndex = 0;
            // 
            // btn_NextGeneration
            // 
            this.btn_NextGeneration.Enabled = false;
            this.btn_NextGeneration.Location = new System.Drawing.Point(4, 371);
            this.btn_NextGeneration.Margin = new System.Windows.Forms.Padding(2);
            this.btn_NextGeneration.Name = "btn_NextGeneration";
            this.btn_NextGeneration.Size = new System.Drawing.Size(138, 22);
            this.btn_NextGeneration.TabIndex = 3;
            this.btn_NextGeneration.Text = "Next Generation";
            this.btn_NextGeneration.UseVisualStyleBackColor = true;
            this.btn_NextGeneration.Click += new System.EventHandler(this.btn_NextGeneration_Click);
            // 
            // btn_SaveGame
            // 
            this.btn_SaveGame.Location = new System.Drawing.Point(419, 371);
            this.btn_SaveGame.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SaveGame.Name = "btn_SaveGame";
            this.btn_SaveGame.Size = new System.Drawing.Size(96, 22);
            this.btn_SaveGame.TabIndex = 4;
            this.btn_SaveGame.Text = "Save Game";
            this.btn_SaveGame.UseVisualStyleBackColor = true;
            this.btn_SaveGame.Click += new System.EventHandler(this.btn_SaveGame_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arkivToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(742, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arkivToolStripMenuItem
            // 
            this.arkivToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.arkivToolStripMenuItem.Name = "arkivToolStripMenuItem";
            this.arkivToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.arkivToolStripMenuItem.Text = "Arkiv";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // nud_X
            // 
            this.nud_X.Location = new System.Drawing.Point(133, 54);
            this.nud_X.Name = "nud_X";
            this.nud_X.Size = new System.Drawing.Size(65, 20);
            this.nud_X.TabIndex = 10;
            this.nud_X.ValueChanged += new System.EventHandler(this.nud_X_ValueChanged);
            // 
            // nud_Y
            // 
            this.nud_Y.Location = new System.Drawing.Point(133, 80);
            this.nud_Y.Name = "nud_Y";
            this.nud_Y.Size = new System.Drawing.Size(65, 20);
            this.nud_Y.TabIndex = 11;
            this.nud_Y.ValueChanged += new System.EventHandler(this.nud_Y_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Y:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 437);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "GOL";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GameGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Y)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_NameOfGame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_StartNewGame;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbx_SavedGames;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_NextGeneration;
        private System.Windows.Forms.Button btn_SaveGame;
        private System.Windows.Forms.DataGridView GameGrid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arkivToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_GameMode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nud_Y;
        private System.Windows.Forms.NumericUpDown nud_X;
    }
}
