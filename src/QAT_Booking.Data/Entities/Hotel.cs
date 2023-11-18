using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAT_Booking.Data.Entities
{
    public class Hotel
    {
        public int Id { get; set; }
        [Display(Name = "Hotel Name")]
        [Required(ErrorMessage = "Field Hotel name is required")]
        public string? Hotel_Name { get; set; }
        public string? Hotel_Name_Search { get; set; }
        [Display(Name = "Address Hotel")]
        [Required(ErrorMessage = "Field Address Hotel is required")]
        public string? Address { get; set; }
        [Required(ErrorMessage = "Field Province is required")]
        [StringLength(100, ErrorMessage = "{0} up to {1} characters")]
        public string? Province { get; set; }
        [StringLength(100, ErrorMessage = "{0} up to {1} characters")]
        [Required(ErrorMessage = "Field District is required")]
        public string? District { get; set; }
        [StringLength(100, ErrorMessage = "{0} up to {1} characters")]
        [Required(ErrorMessage = "Field Ward is required")]
        public string? Sub_District { get; set; }
       
        [Phone]
        public string? Phone_Number { get; set; }
        [EmailAddress]
        public string? Mail_Address { get; set; }
 
        public virtual ICollection<Image>? Images { get; set; }
        public virtual ICollection<Booking>? Bookings { get; set; }
        public virtual ICollection<Room>? Rooms { get; set; }




    }
}
