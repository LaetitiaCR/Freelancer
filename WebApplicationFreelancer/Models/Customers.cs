using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationFreelancer.Models
{
    public class Customers
    {
        [Column("customer_id")]
        [Key]
       
        public int customerId { get; set; }


        [Required]
        [StringLength(100)]
        public string customer_name { get; set; }

        [Required]
        [StringLength(255, MinimumLength = 3)]
        
        public string customer_email { get; set; }



    }
}
