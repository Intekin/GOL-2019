using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOL_2019
{
    class GameSettings
    {
        public enum GAMEMODE { Standard, Extended};
        private int cellNumber = 8;
        private GAMEMODE gameMode = GAMEMODE.Standard;

        public GAMEMODE GameMode
        {
            get { return gameMode; }
            set { gameMode = value; }
        }


        public int NumberOfCells
        {
            get { return cellNumber; }
            set { cellNumber = value; }
        }

    }
}
