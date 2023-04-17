using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_System_Writer
{
    internal class Bids
    {
        private int id;
        private string bid;
        public string description;

        public Bids(int number, string name, string desc)
        {
            id = number;
            bid = name;
            description = desc;
        }
    }
}
