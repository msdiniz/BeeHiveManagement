﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHiveManagement
{
    interface INectarCollector
    {
        void FindFlowers();
        void GatherNectar();
        void ReturnToHive();
    }
}
