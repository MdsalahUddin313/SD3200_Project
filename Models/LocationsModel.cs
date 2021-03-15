using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SDProject03.Models
{
    public class LocationsModel
    {
        [Key]
        public int LocationId { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Location Name")]
        public string LocationName { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Location Title")]
        public string LocationTitle { get; set; }



        [Required]
        [Column(TypeName = "text")]
        [Display(Name = "Description")]
        public string LocationDescription { get; set; }


        [Required]
        [Column(TypeName = "text")]
        [Display(Name = "Location Map")]
        public string LocationMap { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Location Rating")]
        public string LocationRating { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Image Name")]
        public string ImageName { get; set; }


        [NotMapped]
        [Display(Name = "Upload Images")]
        public IFormFile ImageFile { get; set; }

    }
}
