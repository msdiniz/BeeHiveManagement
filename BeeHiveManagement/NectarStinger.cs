using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHiveManagement
{
    class NectarStinger : Worker, INectarCollector,
    IStingPatrol
    {

        public int Nectar { get; set; }

        public void FindFlowers() {
        }
        public void GatherNectar() {
        }
        public void ReturnToHive() {

        }
    }
}
