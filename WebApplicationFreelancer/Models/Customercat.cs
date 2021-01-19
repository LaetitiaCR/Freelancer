using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationFreelancer.Models
{
    [Table("Customercats")]
    public class Customercat
    {

        [Column("customercat_id")]
        [Key]
        public int CustomercatId { get; set; }

        [Required]
        //[MaxLength(50)]
        [StringLength(50, ErrorMessage = "Le nom du la catégorie client ne peut excéder 50 caractères.")]
        public string CustomercatName { get; set; }


        [MaxLength(5000)]
        public string CustomercatDescription { get; set; }
    }
}
