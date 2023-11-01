using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAT_Booking.Data.Enums
{
    public enum EInvoiceStatus
    {
        [Description("Unpaid")] //  The invoice has been generated but not paid yet. The guest or the responsible party is expected to settle the bill.
        Unpaid,
        [Description("Paid")] // The invoice has been paid in full. The financial transaction is complete.
        Paid,
        [Description("Overdue")] //The payment is past the due date, and the invoice is considered overdue.
        Overdue,
        [Description("Void")] // The invoice has been canceled and is no longer valid. This status is typically used when an error was made, and a new invoice needs to be generated.
        Void,
        [Description("Refund")] // : A refund has been processed for a portion or the full amount of the invoice.
        Refund 

    }
}
