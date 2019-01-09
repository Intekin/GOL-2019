using DatabaseCL;
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
    public partial class Form1 : Form
    {
        Class1 c = new Class1();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btn_StartNewGame_Click(object sender, EventArgs e)
        {
            c.TestDb();
        }
    }
}
    
    
