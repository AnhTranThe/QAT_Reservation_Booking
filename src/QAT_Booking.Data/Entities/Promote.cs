using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAT_Booking.Data.Entities
{
    public class Promote
    {
        public int Id { get; set; }
        public string? Promote_Code {  get; set; }
        [Range(0, 100)]
        public int? Discount_Percent { get; set; }
        public DateTime? Start_Date { get; set; }= DateTime.Now;
        public DateTime? End_Date { get;set; }
        public bool Active { get; set; } = true;
        public virtual ICollection<Invoice_Guests>? Invoice_Guests { get; set; }


    }
}
