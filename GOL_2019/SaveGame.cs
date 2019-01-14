using System;
using System.ComponentModel;
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
                string saveString = "";

                foreach (int[,] array in data.Generations)
                {
                    string temp = "";
                    for (int y = 0; y < 8; y++)
                        for (int x = 0; x < 8; x++)
                        {
                            temp += array[x, y];
                        }
                    saveString += temp + ",";
                }

                try
                {
                    if (saveString == "") saveString = "Error";
                    DbManager.SaveToDb(data.ID, data.Name, saveString);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
