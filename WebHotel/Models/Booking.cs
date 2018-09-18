using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebHotel.Models
{
    public class Booking
    {
        public int ID { get; set; }
        public int RoomID { get; set; }
        public String CustomerEmail { get; set; }

        public DateTime checkIn { get; set; }

        public DateTime checkOut { get; set; }

        public Decimal Cost { get; set; }

        public Room TheRoom { get; set; }

        public Customer TheCustomer { get; set; }
    }
}
