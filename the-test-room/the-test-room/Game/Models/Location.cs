using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_test_room.Game.Models
{
    internal class Location
    {
        private string Id {  get; set; }
        private string Name { get; set; }
        private string Description { get; set; }
        private string Status { get; set; }
        private List<string> NPCs { get; set; }
    }
}
