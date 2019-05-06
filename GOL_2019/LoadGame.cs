
using DatabaseCL;
using System.Collections.Generic;
using System.ComponentModel;

namespace GOL_2019
{
    //class LoadGame
    //{
    //    public static BindingList<GameData> LoadAll()
    //    {
    //        List<GOL> golData = new List<GOL>();
    //        BindingList<GameData> gameData = new BindingList<GameData>();

    //        golData = DbManager.LoadFromDb();

    //        foreach (GOL data in golData)
    //        {
    //            GameData loadData = new GameData();
    //            string[] tempGenerations = data.DOA.Split(',');
    //            List<Cell[,]> tempList = new List<Cell[,]>();

    //            foreach (string s in tempGenerations)
    //            {
    //                if (!(s == ""))
    //                {
    //                    Cell counter;
    //                    char[] temp = s.ToCharArray();
    //                    Cell[,] tempArray = new Cell[8, 8];
    //                    for (int y = 0; y < 8; y++)
    //                        for (int x = 0; x < 8; x++)
    //                        {
    //                            tempArray[x, y] = temp[counter] - 48;
    //                            counter++;
    //                        }

    //                    tempList.Add(tempArray);
    //                }
    //            }

    //            loadData.Generations = tempList;
    //            loadData.Name = data.Name;
    //            loadData.ID = (int)data.GOL_Id;

    //            gameData.Add(loadData);
    //        }
    //        return gameData;
    //    }
    //}
}
