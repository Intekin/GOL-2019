using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOL_2019
{
    public static class GameSettings
    {
        public enum GAMEMODE { Standard, Extended};

        public static GAMEMODE GameMode { get; set; } = GAMEMODE.Standard;

        public static int Width { get; set; } = 8;
        public static int Height { get; set; } = 8;
    }
}
