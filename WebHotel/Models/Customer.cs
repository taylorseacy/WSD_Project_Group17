using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebHotel.Models
{
    public class Customer
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public String Email { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 2)]
        [RegularExpression(@"^[A-Za-z '-]*$")]
        public String Surname { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 2)]
        [RegularExpression(@"^[A-Za-z '-]*$")]
        public String GivenName { get; set; }

        [Required]
        [RegularExpression(@"\d{4}$")]
        public String Postcode { get; set; }

       // public ICollection<Booking> { get; set; }
}
}
