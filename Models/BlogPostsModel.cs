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
    public class BlogPostsModel
    {
        [Key]
        public int PostId { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Psots Name")]
        public string PostsName { get; set; }



      


        [Required]
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Blogs Title")]
        public string BlogTitle { get; set; }



        [Required]
        [Column(TypeName = "text")]
        [Display(Name = "Description")]
        public string BlogDescription { get; set; }


       


        [Required]
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Blogs Rating")]
        public string BlogsRating { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Authors Name")]
        public string AuthorsName { get; set; }

        [Required]
        [Column(TypeName = "Posted time")]
        [Display(Name = "Blogs Post Time")]
        public DateTime PostedTime { get; set; }








        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Image Name")]
        public string ImageName { get; set; }


        [NotMapped]
        [Display(Name = "Upload Images")]
        public IFormFile ImageFile { get; set; }
    }
}
