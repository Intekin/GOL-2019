using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOL_2019
{
    public static class GameSettings
    {       
        public static GAMEMODE GameMode { get; set; } = GAMEMODE.Standard;

        //Set default as 100;
        public static int Width { get; set; } = 120;
        public static int Height { get; set; } = 80;
        public static int InitialCellsAlive { get; set; } = 50;
        public static bool ShowDead { get; set; } = false;
    }
}
