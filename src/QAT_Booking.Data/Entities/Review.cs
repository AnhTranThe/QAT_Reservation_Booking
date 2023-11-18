using Azure.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using QAT_Booking.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAT_Booking.Data.Entities
{
    public class Review: IDateTracking, IDateTrackingBy
    {
        public int? Id { get; set; }
        public string? Comment { get; set; }
        public int? Rating { get; set; }
        public bool? Active { get; set; }
        public int Room_Booking_Id {  get; set; }
        public virtual Room_Booking? Room_Booking { get; set; }
        public int? Guest_Id { get; set; }
        public virtual Guest? Guest { get; set; }


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
