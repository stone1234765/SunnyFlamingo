﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Models.Selectors
{
    public class HeadphonesSelector : ComputerAccessoriesSelector
    {
        public string[] Types { get; set; }
        public string[] WirelessTypes { get; set; }
        public string[] ConnectorTypes { get; set; }
    }
}
