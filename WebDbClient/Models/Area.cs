using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WbDbServer.Models
{
    internal class Area
    {
        public int Id { get; set; }
        public string AreaName { get; set; }

        public Area(int id, string name)
        {
            Id = id;
            AreaName = name;
        }
        public Area( string name)
        {
            AreaName = name;
        }
    }
}
