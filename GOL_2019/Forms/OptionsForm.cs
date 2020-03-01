using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOL_2019
{
    public partial class OptionsForm : Form
    {
        
        public OptionsForm()
        {
            InitializeComponent();

            CB_ShowDead.Checked = GameSettings.ShowDead;
            CB_ShowGrid.Checked = GameSettings.ShowGrid;
            nub_UpdateInterval.Value = GameSettings.UpdateInterval;
        }

        private void CB_ShowDead_CheckedChanged(object sender, EventArgs e)
        {
            GameSettings.ShowDead = CB_ShowDead.Checked;
            
        }

        private void CB_ShowGrid_CheckedChanged(object sender, EventArgs e)
        {
            GameSettings.ShowGrid = CB_ShowGrid.Checked;
        }

        private void nub_UpdateInterval_ValueChanged(object sender, EventArgs e)
        {
            GameSettings.UpdateInterval = (int)nub_UpdateInterval.Value;
        }
    }
}
