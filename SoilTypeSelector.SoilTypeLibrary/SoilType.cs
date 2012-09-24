﻿namespace SoilTypeSelector.SoilTypeLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SoilType
    {
        public string Name { get; set; }
        public TernaryCoordinate[] Coordinates { get; set; }
    }
}
