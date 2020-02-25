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
            this.btn_StartNewGame = new System.Windows.Forms.Button();
            this.btn_NextGeneration = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_New = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Options = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_About = new System.Windows.Forms.ToolStripMenuItem();
            this.PB_MainView = new System.Windows.Forms.PictureBox();
            this.nud_CellsAlive = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_X)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_MainView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CellsAlive)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "X:";
            // 
            // nud_Y
            // 
            this.nud_Y.Location = new System.Drawing.Point(98, 28);
            this.nud_Y.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nud_Y.Name = "nud_Y";
            this.nud_Y.Size = new System.Drawing.Size(50, 20);
            this.nud_Y.TabIndex = 11;
            this.nud_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nud_X
            // 
            this.nud_X.Location = new System.Drawing.Point(29, 28);
            this.nud_X.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nud_X.Name = "nud_X";
            this.nud_X.Size = new System.Drawing.Size(50, 20);
            this.nud_X.TabIndex = 10;
            this.nud_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_StartNewGame
            // 
            this.btn_StartNewGame.Location = new System.Drawing.Point(239, 28);
            this.btn_StartNewGame.Margin = new System.Windows.Forms.Padding(2);
            this.btn_StartNewGame.Name = "btn_StartNewGame";
            this.btn_StartNewGame.Size = new System.Drawing.Size(50, 20);
            this.btn_StartNewGame.TabIndex = 6;
            this.btn_StartNewGame.Text = "Start";
            this.btn_StartNewGame.UseVisualStyleBackColor = true;
            this.btn_StartNewGame.Click += new System.EventHandler(this.btn_StartNewGame_Click);
            // 
            // btn_NextGeneration
            // 
            this.btn_NextGeneration.Enabled = false;
            this.btn_NextGeneration.Location = new System.Drawing.Point(293, 28);
            this.btn_NextGeneration.Margin = new System.Windows.Forms.Padding(2);
            this.btn_NextGeneration.Name = "btn_NextGeneration";
            this.btn_NextGeneration.Size = new System.Drawing.Size(50, 20);
            this.btn_NextGeneration.TabIndex = 3;
            this.btn_NextGeneration.Text = "Next";
            this.btn_NextGeneration.UseVisualStyleBackColor = true;
            this.btn_NextGeneration.Click += new System.EventHandler(this.btn_NextGeneration_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.TSMI_About});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1234, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_New,
            this.TSMI_Options,
            this.TSMI_Exit});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // TSMI_New
            // 
            this.TSMI_New.Name = "TSMI_New";
            this.TSMI_New.Size = new System.Drawing.Size(116, 22);
            this.TSMI_New.Text = "New";
            // 
            // TSMI_Options
            // 
            this.TSMI_Options.Name = "TSMI_Options";
            this.TSMI_Options.Size = new System.Drawing.Size(116, 22);
            this.TSMI_Options.Text = "Options";
            this.TSMI_Options.Click += new System.EventHandler(this.TSMI_Options_Click);
            // 
            // TSMI_Exit
            // 
            this.TSMI_Exit.Name = "TSMI_Exit";
            this.TSMI_Exit.Size = new System.Drawing.Size(116, 22);
            this.TSMI_Exit.Text = "Exit";
            this.TSMI_Exit.Click += new System.EventHandler(this.TSMI_Exit_Click);
            // 
            // TSMI_About
            // 
            this.TSMI_About.Name = "TSMI_About";
            this.TSMI_About.Size = new System.Drawing.Size(52, 20);
            this.TSMI_About.Text = "About";
            this.TSMI_About.Click += new System.EventHandler(this.TSMI_About_Click);
            // 
            // PB_MainView
            // 
            this.PB_MainView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PB_MainView.Location = new System.Drawing.Point(0, 52);
            this.PB_MainView.Margin = new System.Windows.Forms.Padding(0);
            this.PB_MainView.Name = "PB_MainView";
            this.PB_MainView.Size = new System.Drawing.Size(1234, 809);
            this.PB_MainView.TabIndex = 0;
            this.PB_MainView.TabStop = false;
            // 
            // nud_CellsAlive
            // 
            this.nud_CellsAlive.Location = new System.Drawing.Point(184, 28);
            this.nud_CellsAlive.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nud_CellsAlive.Name = "nud_CellsAlive";
            this.nud_CellsAlive.Size = new System.Drawing.Size(50, 20);
            this.nud_CellsAlive.TabIndex = 14;
            this.nud_CellsAlive.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cells:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 861);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud_CellsAlive);
            this.Controls.Add(this.btn_NextGeneration);
            this.Controls.Add(this.PB_MainView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nud_Y);
            this.Controls.Add(this.btn_StartNewGame);
            this.Controls.Add(this.nud_X);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Game of Life - 2020";
            ((System.ComponentModel.ISupportInitialize)(this.nud_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_X)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_MainView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CellsAlive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_StartNewGame;
        private System.Windows.Forms.Button btn_NextGeneration;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nud_Y;
        private System.Windows.Forms.NumericUpDown nud_X;
        private System.Windows.Forms.PictureBox PB_MainView;
        private System.Windows.Forms.NumericUpDown nud_CellsAlive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_New;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Options;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Exit;
        private System.Windows.Forms.ToolStripMenuItem TSMI_About;
    }
}
