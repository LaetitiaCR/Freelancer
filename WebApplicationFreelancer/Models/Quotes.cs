using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationFreelancer.Models
{
    public class Quotes
    {
        [Column("quote_id")]
        [Key]

        public int quoteId { get; set; }


        [Required]
        [StringLength(10)]
        public char quote_state { get; set; }



        [Required]
        public DateTime quote_date { get; set; }

        public int quote_amount { get; set; }
        public DateTime quote_final_date { get; set; }


        public int quote_final_amount { get; set; }
    }
}
