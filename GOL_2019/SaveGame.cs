using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseCL;

namespace GOL_2019
{
    class SaveGame
    {
        public static void SaveAll(BindingList<GameData> gameDatas)
        {
            foreach (GameData data in gameDatas)
            {
                string temp = "";
                foreach (int[,] array in data.Generations)
                {
                    for (int y = 0; y < 8; y++)
                        for (int x = 0; x < 8; x++)
                        {
                            temp += array[x, y];
                        }
                    temp += ",";
                }

                try
                {
                    if (temp == "") temp = "Error";
                    DbManager.SaveToDb(data.ID, data.Name, temp);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        public static void SaveCurrent()
        {

        }
    }
}
