﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthSupportApp.Models.DoctorModel
{
    public class ChangePassword
    {
        public int DoctorId { get; set; }
        [Required(ErrorMessage = "Please insert your old password.")]
        [StringLength(50, ErrorMessage = "Maximum limit exceeded.")]
        public string OldPassword { get; set; }
        [Required(ErrorMessage = "Please insert your new password.")]
        [StringLength(50, ErrorMessage = "Maximum limit exceeded.")]
        public string NewPassword { get; set; }
        [Required(ErrorMessage = "Confirm your new password.")]
        [Compare("NewPassword", ErrorMessage ="Password not matched.")]
        public string ConfirmPassword { get; set; }
        public string DoctorLoginId { get; set; }
        public bool PasswordVerified { get; set; }
    }
}