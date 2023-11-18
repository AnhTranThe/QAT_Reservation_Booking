using Microsoft.AspNetCore.Mvc;
using QAT_Booking.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAT_Booking.Data.Entities
{
    public class Guest:IDateTracking, IDateTrackingBy
    {
        public int Id { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Field first name is required")]
        public string? First_Name { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Field last name is required")]
        public string? Last_Name { get; set; }
        [Display(Name = "Full Name")]
        public string? Full_Name { set; get; }
        public string? Full_Name_Search { get; set; }

        [Display(Name = "Date login")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime? Last_Login { get; set; }
        [Display(Name = "Date of birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? Dob { get; set; }
        [Display(Name = "Gender")]
        [MaxLength(10)]
        public string? Gender { set; get; }
        [Phone]
        public string? Phone_Number { get; set; }

        public string? National { get; set; }

        public decimal? Avg_Rating { get; set; } = 0;
        public long? Num_Of_Rating { get; set; } = 0;

        public long ? Sum_Reviews {  get; set; } = 0;


        //************************  relationship ********************************
        
        [DataType(DataType.Upload)]
        [FileExtensions(Extensions = "png,jpg,jpeg,gif")]
        [BindProperty]
        public string? Avatar_Image_Path { get; set; }
        public virtual ICollection<Image>? Images { get; set; }


        public Guid User_Id { get; set; }
        public virtual User? User { get; set; }
        [Display(Name = "Created Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Create_Date { get; set; } = DateTime.Now;
        [Display(Name = "Updated Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? Last_Modified_Date { get; set; }
        [Display(Name = "Created By")]
        [StringLength(50, ErrorMessage = "{0} up to {1} characters")]
        public string? Create_Date_By { get; set; }

        [Display(Name = "Updated By")]
        [StringLength(50, ErrorMessage = "{0} up to {1} characters")]
        public string? Last_Modified_Date_By { get; set; }

        [Display(Name = "Date login")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime? LastLogin { get; set; }
        public virtual ICollection<Booking>? Bookings { get; set; }
        public virtual ICollection<Review>? Reviews { get; set; }


    }
}
