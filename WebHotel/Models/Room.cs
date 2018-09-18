using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebHotel.Models
{
    public class Room
    { 
        public int ID { get; set; }

        [Required]
        [RegularExpression(@"^")]
        public String Level { get; set; }

        [RegularExpression(@"^[1-3]\d$")]
        public int BedCount { get; set; }

        [DataType(DataType.Currency)]
        [Range(50, 300)]
        public Decimal Price { get; set; }

        //public ICollection<Booking> { get; set; }
    }
}
