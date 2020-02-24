using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOL_2019.Utility
{
    public enum CELL_STATE { Empty, Dead, Alive }

    public class Cell
    {
        public CELL_STATE State;
        public CELL_STATE NextState;

        public Cell()
        {
            State = CELL_STATE.Empty;
        }

        public Cell(CELL_STATE state)
        {
            State = state;
        }

        public void ToggleState()
        {
            State = NextState;
        }
    }
}
