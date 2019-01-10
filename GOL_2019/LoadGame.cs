using DatabaseCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOL_2019
{
    class LoadGame
    {
        public List<int[,]> Load()
        {

            List<GOL> gdata = new List<GOL>();
            List<int[,]> genList = new List<int[,]>();

            gdata = DbManager.LoadFromDb();

            foreach (GOL data in gdata)
            {

            }
            string[] temp = gdata[0].DOA.Split(',');



            return genList;
        }
    }
}
