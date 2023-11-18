using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAT_Booking.Data.Enums
{
    public enum EBookingStatus
    {
        [Description("Confirmed")]
        Confirmed,
        [Description("Pending")]
        Pending,
        [Description("Cancelled")]
        Cancelled

    }
}
