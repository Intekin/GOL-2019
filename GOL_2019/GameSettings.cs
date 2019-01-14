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

        public GAMEMODE GameMode { get; set; } = GAMEMODE.Standard;

        public int NumberOfCellsX { get; set; } = 8;
        public int NumberOfCellsY { get; set; } = 8;
    }
}
