using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WbDbServer.Models
{
    internal class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AreaId { get; set; }
        public int TypeId { get; set; }

        public Hotel(int id, string name, int areaId, int typeId)
        {
            Id = id;
            Name = name;
            AreaId = areaId;
            TypeId = typeId;
        }
        public Hotel( string name, int areaId, int typeId)
        {
            Name = name;
            AreaId = areaId;
            TypeId = typeId;
        }
    }
}
