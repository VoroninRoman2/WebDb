using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDbLib
{
    public class HotelType
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public HotelType(int id, string name)
        {
            Id = id;
            Type = name;
        }
        public HotelType(string name)
        {
            Type = name;
        }
    }
}
