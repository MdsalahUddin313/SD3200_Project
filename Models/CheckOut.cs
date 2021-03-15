using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SDProject03.Models
{
    public class CheckOut
    {
        [Key]
        public int Id { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Enter Name")]
        public string Name { get; set; }



        [Required]
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Email")]
        public string Email { get; set; }



        [Required]
        [Column(TypeName = "nvarchar(12)")]
        [Display(Name = "Card No")]
        public string CardNo { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(3)")]
        [Display(Name = "Card Pin")]
        public string CardPin { get; set; }




        [Required]
        [Column(TypeName = "datetime")]
        [Display(Name = "ExpireDate")]
        public DateTime ExpireDate { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Total Amount")]
        public string PaymentAmount { get; set; }



    }
}
