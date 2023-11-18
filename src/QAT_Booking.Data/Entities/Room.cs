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
    public class Room
    {
        public int? Id { get; set; }
        [StringLength(255, ErrorMessage = "{0} up to {1} characters")]
        [Required(ErrorMessage = "Field Room Name is required")]
        public string? Room_Name { get; set; }
        [StringLength(255, ErrorMessage = "{0} up to {1} characters")]
        public string? Room_Name_Search { get; set; }
        public int? Room_Number { get; set; }
        public int? Floor {  get; set; }
        public int? Hotel_Id { get; set; }
        public virtual Hotel? Hotel { get; set; }
        public int? Room_Type_Id { get; set; }
        public virtual Room_Type? Room_Type { get; set;}
        public int? Room_Status_Id { get; set; }
        public virtual Room_Status? Room_Status {  set; get; }
        public virtual ICollection<Room_Booking>? Room_Bookings { get; set; }






    }
}
