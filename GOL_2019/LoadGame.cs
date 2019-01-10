using DatabaseCL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOL_2019
{
    class LoadGame
    {
        public static BindingList<GameData> Load()
        {

            List<GOL> golData = new List<GOL>();
            BindingList<GameData> gameData = new BindingList<GameData>();

            golData = DbManager.LoadFromDb();

            foreach (GOL data in golData)
            {
                GameData loadData = new GameData();
                string[] tempGenerations = data.DOA.Split(',');
                List<int[,]> tempList = new List<int[,]>();

                foreach (string s in tempGenerations) {
                    if (!(s == ""))
                    {
                        int counter = 0;
                        char[] temp = s.ToCharArray();
                        int[,] tempArray = new int[8, 8];
                        for (int y = 0; y < 8; y++)
                            for (int x = 0; x < 8; x++)
                            {
                                tempArray[x, y] = (int)temp[counter] - 48;
                                counter++;
                            }

                        tempList.Add(tempArray);
                    }
                }

                loadData.Generations = tempList;
                loadData.Name = data.Name;
                loadData.ID = (int)data.GOL_Id;

                gameData.Add(loadData);
            }
            return gameData;
        }
    }
}
