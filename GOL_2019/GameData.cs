﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOL_2019
{
    class GameData
    {
        private string name;
        private List<int[,]> generations;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<int[,]> Generations
        {
            get { return generations; }
            set { generations = value; }
        }
    }
}
