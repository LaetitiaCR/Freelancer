using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationFreelancer.Models
{
    public class Job
    {

        [Column("job_id")]
        [Key]
        public int JobId { get; set; }


        [Required]
        [MaxLength(10)]
        public char JobState { get; set; }


        [Required]
        [MaxLength(100)]
        public string JobTitle { get; set; }


        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime JobStart { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime JobEnd { get; set; }



        [MaxLength(1000)]
        //text
        public string JobDescription { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
