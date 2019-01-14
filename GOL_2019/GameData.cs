using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOL_2019
{
    class GameData
    {
        public string Name { get; set; }
        public List<int[,]> Generations { get; set; }
        public int ID { get; set; }

        // List<GameData> for the Listbox will now by default just show the name
        public override string ToString () { return Name; }

    }
}
