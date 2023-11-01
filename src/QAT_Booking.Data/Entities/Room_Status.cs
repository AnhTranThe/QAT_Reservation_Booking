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
    public class Room_Status

    {
        public int? Id { get; set; }
        public virtual ICollection<Room>? Rooms { get; set; }

    }
}
