using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAT_Booking.Data.Interfaces
{
    public interface IDateTrackingBy
    {
     
        [Display(Name = "Created By")]    
        [StringLength(50, ErrorMessage = "{0} up to {1} characters")]
        public string? Create_Date_By { get; set; }

        [Display(Name = "Updated By")]   
        [StringLength(50, ErrorMessage = "{0} up to {1} characters")]
        public string? Last_Modified_Date_By { get; set; }

    }
}
