using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAT_Booking.Data.Enums
{
    public enum EUploadStatus
    {
        [Description("Delete")]
        Delete = -1,
        [Description("InActive")]
        InActive = 0,
        [Description("Active")]
        Active = 1,
    }
}
