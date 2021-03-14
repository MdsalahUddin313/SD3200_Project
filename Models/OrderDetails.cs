using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SDProject03.Models
{
    public class OrderDetails
    {
        public int Id { get; set; }
        [Display (Name ="Order")]

        public int OrderId { get; set; }
        [Display(Name = "Hotels")]

        public int HotelsId { get; set; }


        [ForeignKey ("OrderId")]
        public Order Order { get; set; }

        [ForeignKey("HotelsId")]
        public HotelsModel Hotel { get; set; }
    }
}
