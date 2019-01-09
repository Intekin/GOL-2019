using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOL_2019
{
    class SaveGame
    {
        public void Save(List<int[,]> gameToSave)
        {
            foreach(int[,] array in gameToSave){
                string temp ="";
                for(int y= 0; y < 8; y++)
                    for(int x = 0; x < 8; x++)
                    {
                        temp += array[x, y];
                    }
                temp += ",";
            }
            //Send to Database_CL
        }
    }
}
