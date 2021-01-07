using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationFreelancer.Models
{
    public class CustomersCats
    {
        [Column("customerCat_id")]
        [Key]

        public int customerCatId { get; set; }


        [Required]
        [StringLength(50)]
        public string customerCat_name { get; set; }

  
        public string customerCat_description { get; set; }
    }
}
