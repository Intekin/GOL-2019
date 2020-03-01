namespace GOL_2019
{
    partial class OptionsForm
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
            this.CB_ShowDead = new System.Windows.Forms.CheckBox();
            this.CB_ShowGrid = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nub_UpdateInterval = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nub_UpdateInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_ShowDead
            // 
            this.CB_ShowDead.AutoSize = true;
            this.CB_ShowDead.Location = new System.Drawing.Point(12, 12);
            this.CB_ShowDead.Name = "CB_ShowDead";
            this.CB_ShowDead.Size = new System.Drawing.Size(107, 17);
            this.CB_ShowDead.TabIndex = 0;
            this.CB_ShowDead.Text = "Show Dead Cells";
            this.CB_ShowDead.UseVisualStyleBackColor = true;
            this.CB_ShowDead.CheckedChanged += new System.EventHandler(this.CB_ShowDead_CheckedChanged);
            // 
            // CB_ShowGrid
            // 
            this.CB_ShowGrid.AutoSize = true;
            this.CB_ShowGrid.Location = new System.Drawing.Point(12, 35);
            this.CB_ShowGrid.Name = "CB_ShowGrid";
            this.CB_ShowGrid.Size = new System.Drawing.Size(75, 17);
            this.CB_ShowGrid.TabIndex = 1;
            this.CB_ShowGrid.Text = "Show Grid";
            this.CB_ShowGrid.UseVisualStyleBackColor = true;
            this.CB_ShowGrid.CheckedChanged += new System.EventHandler(this.CB_ShowGrid_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Update Interval:";
            // 
            // nub_UpdateInterval
            // 
            this.nub_UpdateInterval.Location = new System.Drawing.Point(98, 53);
            this.nub_UpdateInterval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nub_UpdateInterval.Name = "nub_UpdateInterval";
            this.nub_UpdateInterval.Size = new System.Drawing.Size(47, 20);
            this.nub_UpdateInterval.TabIndex = 4;
            this.nub_UpdateInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nub_UpdateInterval.ValueChanged += new System.EventHandler(this.nub_UpdateInterval_ValueChanged);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 221);
            this.Controls.Add(this.nub_UpdateInterval);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_ShowGrid);
            this.Controls.Add(this.CB_ShowDead);
            this.Name = "OptionsForm";
            this.Text = "Game of Life - Options";
            ((System.ComponentModel.ISupportInitialize)(this.nub_UpdateInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CB_ShowDead;
        private System.Windows.Forms.CheckBox CB_ShowGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nub_UpdateInterval;
    }
}