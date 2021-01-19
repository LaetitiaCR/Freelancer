using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationFreelancer.Models
{
    [Table("Customers")]
    public class Customer
    {
        [Column("customer_id")]
        [Key]
        public int CustomerId { get; set; }


        [Required]
        [StringLength(100, ErrorMessage = "Le nom du client ne peut excéder 100 caractères.")]
        //[MaxLength(100)]
        public string CustomerName { get; set; }

        [Required]
        //[MaxLength(255)]
        [StringLength(255, ErrorMessage = "Le mail du client ne peut excéder 255 caractères.")]
        public string CustomerEmail { get; set; }


        public int CustomercatId { get; set; }

        //model Customercat.cs et table source Customercats
       // public virtual ICollection<Customercat> Customercats { get; set; }
        

    }
}
