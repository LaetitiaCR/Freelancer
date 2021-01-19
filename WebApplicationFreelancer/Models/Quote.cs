using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationFreelancer.Models
{
    [Table("Quotes")]
    public class Quote
    {
        [Column("quote_id")]
        [Key]
        public int QuoteId { get; set; }

        //[Required]
        [MaxLength(10)]
        public string QuoteState { get; set; }


        //[Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime QuoteDate { get; set; }
        public int QuoteAmount { get; set; }



        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime QuoteFinalDate { get; set; }


        public int QuoteFinalAmount { get; set; }


        public int JobId { get; set; }

        //public virtual ICollection<Job> Jobs { get; set; }
    }
}
