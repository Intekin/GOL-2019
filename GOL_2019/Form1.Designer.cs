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
            this.TestButton = new System.Windows.Forms.Button();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TestButton);
            this.groupBox1.Controls.Add(this.tb_NameOfGame);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_StartNewGame);
            this.groupBox1.Controls.Add(this.btn_Delete);
            this.groupBox1.Controls.Add(this.btn_Load);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbx_SavedGames);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(269, 426);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(148, 358);
            this.TestButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(100, 28);
            this.TestButton.TabIndex = 8;
            this.TestButton.Text = "Test";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // tb_NameOfGame
            // 
            this.tb_NameOfGame.Location = new System.Drawing.Point(9, 358);
            this.tb_NameOfGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_NameOfGame.MaxLength = 18;
            this.tb_NameOfGame.Name = "tb_NameOfGame";
            this.tb_NameOfGame.Size = new System.Drawing.Size(119, 22);
            this.tb_NameOfGame.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // btn_StartNewGame
            // 
            this.btn_StartNewGame.Location = new System.Drawing.Point(9, 386);
            this.btn_StartNewGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_StartNewGame.Name = "btn_StartNewGame";
            this.btn_StartNewGame.Size = new System.Drawing.Size(119, 34);
            this.btn_StartNewGame.TabIndex = 6;
            this.btn_StartNewGame.Text = "Start new game";
            this.btn_StartNewGame.UseVisualStyleBackColor = true;
            this.btn_StartNewGame.Click += new System.EventHandler(this.btn_StartNewGame_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(133, 279);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(112, 23);
            this.btn_Delete.TabIndex = 5;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(9, 279);
            this.btn_Load.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(119, 23);
            this.btn_Load.TabIndex = 4;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Saved Games";
            // 
            // lbx_SavedGames
            // 
            this.lbx_SavedGames.FormattingEnabled = true;
            this.lbx_SavedGames.ItemHeight = 16;
            this.lbx_SavedGames.Location = new System.Drawing.Point(9, 62);
            this.lbx_SavedGames.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbx_SavedGames.Name = "lbx_SavedGames";
            this.lbx_SavedGames.Size = new System.Drawing.Size(237, 212);
            this.lbx_SavedGames.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GameGrid);
            this.groupBox2.Location = new System.Drawing.Point(373, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(387, 383);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Game Of Life";
            // 
            // GameGrid
            // 
            this.GameGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GameGrid.Location = new System.Drawing.Point(7, 22);
            this.GameGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GameGrid.Name = "GameGrid";
            this.GameGrid.RowTemplate.Height = 24;
            this.GameGrid.Size = new System.Drawing.Size(380, 351);
            this.GameGrid.TabIndex = 0;
            // 
            // btn_NextGeneration
            // 
            this.btn_NextGeneration.Enabled = false;
            this.btn_NextGeneration.Location = new System.Drawing.Point(359, 411);
            this.btn_NextGeneration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_NextGeneration.Name = "btn_NextGeneration";
            this.btn_NextGeneration.Size = new System.Drawing.Size(205, 27);
            this.btn_NextGeneration.TabIndex = 3;
            this.btn_NextGeneration.Text = "Next Generation";
            this.btn_NextGeneration.UseVisualStyleBackColor = true;
            this.btn_NextGeneration.Click += new System.EventHandler(this.btn_NextGeneration_Click);
            // 
            // btn_SaveGame
            // 
            this.btn_SaveGame.Location = new System.Drawing.Point(571, 411);
            this.btn_SaveGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SaveGame.Name = "btn_SaveGame";
            this.btn_SaveGame.Size = new System.Drawing.Size(201, 27);
            this.btn_SaveGame.TabIndex = 4;
            this.btn_SaveGame.Text = "Save Game";
            this.btn_SaveGame.UseVisualStyleBackColor = true;
            this.btn_SaveGame.Click += new System.EventHandler(this.btn_SaveGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_SaveGame);
            this.Controls.Add(this.btn_NextGeneration);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "GOL";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GameGrid)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button TestButton;
    }
}

