﻿using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public Reptile() 
        {
            IsAlive = true;
            LegCount = 4;
            LandSeaAir = "Land";
            Age = 0;
        }
        public bool IsColdBlooded { get; set; }
        public bool IsScary { get; set; }
        public string Habitat { get; set; }
        public bool CanGrowTail { get; set; }
    }
}
