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
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 221);
            this.Controls.Add(this.CB_ShowDead);
            this.Name = "OptionsForm";
            this.Text = "Game of Life - Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CB_ShowDead;
    }
}