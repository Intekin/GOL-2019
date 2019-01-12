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
        private int cellNumbersX = 8;
        private int cellNumbersY = 8;
        private GAMEMODE gameMode = GAMEMODE.Standard;

        public GAMEMODE GameMode
        {
            get { return gameMode; }
            set { gameMode = value; }
        }

        public int NumberOfCellsX
        {
            get { return cellNumbersX; }
            set { cellNumbersX = value; }
        }

        public int NumberOfCellsY
        {
            get { return cellNumbersY; }
            set { cellNumbersY = value; }
        }

    }
}
