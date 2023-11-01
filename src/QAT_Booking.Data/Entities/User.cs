using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAT_Booking.Data.Entities
{
    public class User: IdentityUser<Guid>
    {
        [Display(Name = "User Status")]
        [StringLength(10, ErrorMessage = "{0} up to {1} characters")]
        public string? User_Status { get; set; }
        [Display(Name = "Description User")]
        [StringLength(50, ErrorMessage = "{0} up to {1} characters")]
        public string? User_Status_Description { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Please enter the correct password format")]
        [StringLength(100, ErrorMessage = "{0} at least {2} maximum {1} character length", MinimumLength = 8)]
        [RegularExpression("^(?=[A-Za-z0-9@#$%^&+!=]+$)^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[@#$%^&+!=])(?=.{8,}).*$", ErrorMessage = "Mật khẩu phải có từ 8 kí tự trở lên với ít nhất 1 chữ hoa, 1 số, 1 kí tự đặc biệt")]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu")]
        public string? Password { get; set; }

        [NotMapped]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "Please check password and confirm password field !")]
        public string? ConfirmPassword { get; set; }
        [Display(Name = "Note")]
        public string? Note { get; set; }

        public virtual Agent? Agent { get; set; }
        public virtual Guest? Guest { get; set; }
        public virtual Employee? Employee { get; set; }

    }
}
