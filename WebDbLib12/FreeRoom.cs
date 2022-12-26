using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDbLib
{
    public class FreeRooms
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        public int RoomNumber { get; set; }
        public int Price { get; set; }
        public FreeRooms(int id, int hotelId, int rooms, int price)
        {
            Id = id;
            HotelId = hotelId;
            RoomNumber = rooms;
            Price = price;
        }
        public FreeRooms(int hotelId, int rooms, int price)
        {
            HotelId = hotelId;
            RoomNumber = rooms;
            Price = price;
        }

    }
}
