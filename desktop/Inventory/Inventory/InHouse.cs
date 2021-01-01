using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class InHouse : Part
    {

        public int MachineID;
        //
        //In-House Part Constructor//
        //
        public InHouse(int id, string name, decimal price, int inventory, int min, int max, int machineId) : 
            base( id, name, price, inventory, min, max)
        {
            MachineID = machineId;
        }

    }
}
