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
    public class Agent:IDateTracking, IDateTrackingBy
    {

        public int Id { get; set; }
        public string? Company_Name { get; set; }
        public string? Company_Address { get; set; }
        public string? Company_Introduction { get; set; }
        [Phone]
        public string? Phone_Number { get; set; }
        public int? ViewCount { set; get; }
        [Display(Name = "Date login")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime? LastLogin { get; set; }
       
        public Guid UserId { get; set; }
        public virtual User? User { get; set; }


    
        [DataType(DataType.Upload)]
        [FileExtensions(Extensions = "png,jpg,jpeg,gif")]
        [BindProperty]
        public string? Avatar_Image_Path { get; set; }


        public virtual ICollection<Image>? Images { get; set; }


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





    }
}
