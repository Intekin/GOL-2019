using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseCL;

namespace GOL_2019
{
    class SaveGame
    {
        public static void Save(string gameName, List<int[,]> gameToSave)
        {
            string temp = "";
            foreach (int[,] array in gameToSave){
                for(int y= 0; y < 8; y++)
                    for(int x = 0; x < 8; x++)
                    {
                        temp += array[x, y];
                    }
                temp += ",";
            }

            try
            {
                if (temp == "") temp = "Error";
                Class1.SaveToDb(gameName, temp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
