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
    public class TrainModel
    {
        [Key]
        public int TrainId { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Train Name")]
        public string TrainName { get; set; }


        
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Train Company Name")]
        public string TrainCompanyName { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Train Title")]
        public string TrainTitle { get; set; }



        [Required]
        [Column(TypeName = "text")]
        [Display(Name = "Description")]
        public string TrainDescription { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(10000)")]
        [Display(Name = "Train Map")]
        public string TrainMap { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Train Rating")]
        public string TrainRating { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Train Seattype")]
        public string TrainSeatType { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Train Seat Price")]
        public string TrainSeatPrice { get; set; }


        [Required]
        [Column(TypeName = "Departure time")]
        [Display(Name = "Train Rating")]
        public DateTime DepartureTime { get; set; }



        [Required]
        [Column(TypeName = "nvarchar(100000)")]
        [Display(Name = "Train Departure Location")]
        public string TrainDepartureLocation { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(100000)")]
        [Display(Name = "Train Arrival Location")]
        public string TrainArrivalLocation { get; set; }


        [Required]
        [Column(TypeName = "Arrival Time")]
        [Display(Name = "Train Arrival Time")]
        public DateTime ArrivalTime { get; set; }




        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Image Name")]
        public string ImageName { get; set; }


        [NotMapped]
        [Display(Name = "Upload Images")]
        public IFormFile ImageFile { get; set; }


    }
}

/*
 
companyId int ,
departureLocationId int not null,
trains_images varchar(100) not null,
arrivalLocationId int not null,
duration varchar(25) not null,
departTime datetime,
arrivalTime datetime,
economySeats varchar(25) not null,
bussinessSeats int not null,
PremiumSeats int not null,
descriptions text,
trainStatus varchar not null,
trainImage varchar(1000)
 
 */