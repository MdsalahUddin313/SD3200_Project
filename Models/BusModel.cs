using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using Microsoft.AspNetCore.Http;

namespace SDProject03.Models
{
    public class BusModel
    {
        [Key]
        public int BusId { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Bus Name")]
        public string BusName { get; set; }



        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Bus Company Name")]
        public string BusCompanyName { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Bus Title")]
        public string BusTitle { get; set; }



        [Required]
        [Column(TypeName = "text")]
        [Display(Name = "Description")]
        public string BusDescription { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(10000)")]
        [Display(Name = "Bus Map")]
        public string BusMap { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Bus Rating")]
        public string BusRating { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Bus Seattype")]
        public string BusSeatType { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Bus Seat Price")]
        public string BusSeatPrice { get; set; }


        [Required]
        [Column(TypeName = "datetime")]
        [Display(Name = "Bus departuretime")]
        public DateTime DepartureTime { get; set; }



        [Required]
        [Column(TypeName = "nvarchar(100000)")]
        [Display(Name = "Bus Departure Location")]
        public string BusDepartureLocation { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(100000)")]
        [Display(Name = "Bus Arrival Location")]
        public string BusArrivalLocation { get; set; }


        [Required]
        [Column(TypeName = "datetime")]
        [Display(Name = "Bus Arrival time")]
        public DateTime ArrivalTime { get; set; }




        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Image Name")]
        public string ImageName { get; set; }


        [NotMapped]
        [Display(Name = "Upload Images")]
        public IFormFile ImageFile { get; set; }

    }
}
