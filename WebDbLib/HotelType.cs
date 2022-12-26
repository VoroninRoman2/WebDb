using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDbLib
{
    internal class HotelType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }

        public HotelType(int id, string name)
        {
            Id = id;
            TypeName = name;
        }
        public HotelType(string name)
        {
            TypeName = name;
        }
    }
}
