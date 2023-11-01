using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using QAT_Booking.Data.Enums;
using QAT_Booking.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAT_Booking.Data.Entities
{
    public class Booking: IDateTracking, IDateTrackingBy
    {
        
        public int Id { get; set; }
        public int Guest_Id { get; set; }
        public virtual Guest? Guest { get; set; }
        public int Hotel_Id { get; set; }
        public virtual Hotel? Hotel { get; set; }
        public int Employee_Id { get; set; }
        public virtual Employee? Employee { get; set; }
   
        public DateTime? Start_Date { get; set; } 
        public DateTime? End_Date { get; set; }
        
        public EBookingStatus? Booking_Status { get; set; }
        public string? Booking_Status_Desc { get; set; }

        public int? Adult_Count { get; set; }
        public int? Child_Count { get; set; }
     
      

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

        public virtual ICollection<Room_Booking>? Room_Bookings { get; set; }
        public virtual ICollection<Invoice_Guests>? Invoice_Guests { get; set; }









    }
}
