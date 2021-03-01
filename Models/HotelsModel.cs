using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;
using System.ComponentModel;
using Microsoft.AspNetCore.Http;

namespace SDProject03.Models
{
    public class HotelsModel
    {



        [Key]
        public int HotelsId { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Hotels Name")]
        public string HotelsName { get; set; }



        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Hotels Company Name")]
        public string HotelsCompanyName { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Hotels Title")]
        public string HotelsTitle { get; set; }



        [Required]
        [Column(TypeName = "text")]
        [Display(Name = "Description")]
        public string HotelsDescription { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(10000)")]
        [Display(Name = "Hotels Map")]
        public string HotelsMap { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Hotels Rating")]
        public string HotelsRating { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Hotels roomtype")]
        public string HotelsRoomtype { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Hotels Room Price")]
        public string HotelsSeatPrice { get; set; }


        [Required]
        [Column(TypeName = "CheckIn time")]
        [Display(Name = "Hotels Checkin")]
        public DateTime CheckIn { get; set; }




        [Required]
        [Column(TypeName = "Check Out Time")]
        [Display(Name = "Hotels Arrival Time")]
        public DateTime CheckoutTime { get; set; }




        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Image Name")]
        public string ImageName { get; set; }


        [NotMapped]
        [Display(Name = "Upload Images")]
        public IFormFile ImageFile { get; set; }


    }
}


/*
 hotelId int IDENTITY(1,1) PRIMARY KEY,
 CompanyId  int not null,
locationId int not null,
hotelName varchar(25) not null,
HotelAddress varchar(25) not null,
pincode varchar(25) not null,
landmark varchar(25) not null,
hoteldescription text,
hotel_image varchar(50) not null,
 
 */