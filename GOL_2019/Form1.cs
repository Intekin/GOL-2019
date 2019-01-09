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
    GameLogic gameLogic;

    public Form1()
    {
        InitializeComponent();
    }

    private void btn_StartNewGame_Click(object sender, EventArgs e)
    {
      gameLogic = new GameLogic();
      
      // Load gameLogic.GameGrid into GameGrid (DataGridView control)

    }

    private void btn_NextGeneration_Click(object sender, EventArgs e)
    {
      // Calling Iterate() updates gameLogic.GameGrid which contains the new generation.
      gameLogic.Iterate();
    }
  }
}
    
    
