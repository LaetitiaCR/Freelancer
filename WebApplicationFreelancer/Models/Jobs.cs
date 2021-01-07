using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationFreelancer.Models
{
    public class Jobs
    {
        [Column("job_id")]
        [Key]

        public int jobId { get; set; }


        [Required]
        [StringLength(10)]
        public char job_state { get; set; }


        [Required]
        [StringLength(100)]
        public string job_title { get; set; }

        [Required]
        public DateTime job_start { get; set; }

       
        public DateTime job_end { get; set; }


        public string job_description { get; set; }
    }
}
