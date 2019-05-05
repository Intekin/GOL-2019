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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nud_Y = new System.Windows.Forms.NumericUpDown();
            this.nud_X = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_GameMode = new System.Windows.Forms.ComboBox();
            this.tb_NameOfGame = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_StartNewGame = new System.Windows.Forms.Button();
            this.btn_NextGeneration = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arkivToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PB_MainView = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_X)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_MainView)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "X:";
            // 
            // nud_Y
            // 
            this.nud_Y.Location = new System.Drawing.Point(312, 39);
            this.nud_Y.Name = "nud_Y";
            this.nud_Y.Size = new System.Drawing.Size(65, 20);
            this.nud_Y.TabIndex = 11;
            // 
            // nud_X
            // 
            this.nud_X.Location = new System.Drawing.Point(220, 39);
            this.nud_X.Name = "nud_X";
            this.nud_X.Size = new System.Drawing.Size(65, 20);
            this.nud_X.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Game Mode";
            // 
            // cb_GameMode
            // 
            this.cb_GameMode.FormattingEnabled = true;
            this.cb_GameMode.Location = new System.Drawing.Point(109, 39);
            this.cb_GameMode.Margin = new System.Windows.Forms.Padding(2);
            this.cb_GameMode.Name = "cb_GameMode";
            this.cb_GameMode.Size = new System.Drawing.Size(90, 21);
            this.cb_GameMode.TabIndex = 8;
            // 
            // tb_NameOfGame
            // 
            this.tb_NameOfGame.Location = new System.Drawing.Point(8, 39);
            this.tb_NameOfGame.Margin = new System.Windows.Forms.Padding(2);
            this.tb_NameOfGame.MaxLength = 18;
            this.tb_NameOfGame.Name = "tb_NameOfGame";
            this.tb_NameOfGame.Size = new System.Drawing.Size(90, 20);
            this.tb_NameOfGame.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // btn_StartNewGame
            // 
            this.btn_StartNewGame.Location = new System.Drawing.Point(379, 34);
            this.btn_StartNewGame.Margin = new System.Windows.Forms.Padding(2);
            this.btn_StartNewGame.Name = "btn_StartNewGame";
            this.btn_StartNewGame.Size = new System.Drawing.Size(89, 28);
            this.btn_StartNewGame.TabIndex = 6;
            this.btn_StartNewGame.Text = "Start";
            this.btn_StartNewGame.UseVisualStyleBackColor = true;
            this.btn_StartNewGame.Click += new System.EventHandler(this.btn_StartNewGame_Click);
            // 
            // btn_NextGeneration
            // 
            this.btn_NextGeneration.Location = new System.Drawing.Point(472, 34);
            this.btn_NextGeneration.Margin = new System.Windows.Forms.Padding(2);
            this.btn_NextGeneration.Name = "btn_NextGeneration";
            this.btn_NextGeneration.Size = new System.Drawing.Size(96, 28);
            this.btn_NextGeneration.TabIndex = 3;
            this.btn_NextGeneration.Text = "Next Generation";
            this.btn_NextGeneration.UseVisualStyleBackColor = true;
            this.btn_NextGeneration.Click += new System.EventHandler(this.btn_NextGeneration_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arkivToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(875, 24);
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
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // PB_MainView
            // 
            this.PB_MainView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PB_MainView.Location = new System.Drawing.Point(0, 65);
            this.PB_MainView.Margin = new System.Windows.Forms.Padding(0);
            this.PB_MainView.Name = "PB_MainView";
            this.PB_MainView.Size = new System.Drawing.Size(875, 457);
            this.PB_MainView.TabIndex = 0;
            this.PB_MainView.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 522);
            this.Controls.Add(this.btn_NextGeneration);
            this.Controls.Add(this.PB_MainView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_NameOfGame);
            this.Controls.Add(this.nud_Y);
            this.Controls.Add(this.btn_StartNewGame);
            this.Controls.Add(this.nud_X);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_GameMode);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "GOL";
            ((System.ComponentModel.ISupportInitialize)(this.nud_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_X)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_MainView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_NameOfGame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_StartNewGame;
        private System.Windows.Forms.Button btn_NextGeneration;
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
        private System.Windows.Forms.PictureBox PB_MainView;
    }
}
