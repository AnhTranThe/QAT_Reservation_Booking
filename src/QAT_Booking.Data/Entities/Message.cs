using Azure.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using QAT_Booking.Data.Enums;
using QAT_Booking.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAT_Booking.Data.Entities
{
    public class Message
    {
        public int? Id { get; set; }

        public int? SenderId { get; set; }
        [StringLength(50, ErrorMessage = "{0} up to {1} characters")]
        public string? SenderRole { get; set; } //Role of the sender: 'agent', 'guest', or 'employee'
        public int? ReceiverId { get; set; }
        [StringLength(50, ErrorMessage = "{0} up to {1} characters")]
        public string? ReceiverRole { get; set; } ////Role of the receiver: 'agent', 'guest', or 'employee'
        public string? Message_Text { get; set; }
        [Display(Name = "Time Stamp")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime? Time_Stamp { get; set; }
        public bool Is_Read { get; set; } = false;
        

    }
}
