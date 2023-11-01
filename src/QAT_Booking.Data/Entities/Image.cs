using QAT_Booking.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAT_Booking.Data.Entities
{
    public class Image: IDateTracking, IDateTrackingBy
    {
        public int Id { get; set; }
        [Display(Name = "File Name")]
        public string? File_Name { get; set; }
        [Display(Name = "File Path")]
        public string? File_Path { get; set; }
        [Display(Name = "File Size")]
        public long File_Size { get; set; }
        [Display(Name = "File Status")]
        [StringLength(10, ErrorMessage = "{0} up to {1} characters")]
        public string? File_Status { get; set; }
        [Display(Name = "Description User")]
        [StringLength(50, ErrorMessage = "{0} up to {1} characters")]
        public string? File_Status_Description { get; set; }
        public bool Is_Default { get; set; }
        [StringLength(50, ErrorMessage = "{0} up to {1} characters")]
        public string? File_Belong {get; set; }
        public int Sort_Order { get; set; }
        [Display(Name = "Created Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Create_Date { get; set; }
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

        //************************  relationship ********************************
        public virtual Guest? Guest { set; get; }
        public int? Guest_Id { set; get; }
        public virtual Agent? Agent { set; get; }
        public int? Agent_Id { set; get; }
        public virtual Employee? Employee { set; get; }
        public int? Employee_Id { set; get; }
        public virtual Hotel? Hotel { set; get; }
        public int? Hotel_Id { set; get; }






    }
}
