using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_test_room.Game.Models
{
    public class Player
    {
        public string Name { get; set; }
        public int Insight { get; set; }
        public int Prowess { get; set; }
        public int Resolve {  get; set; }
        public List<string> Inventory { get; set; }
    }

    
}
