//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HealthSupportApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ForgetPasswordVerification
    {
        public int Id { get; set; }
        public string LoginId { get; set; }
        public string ContactPersonMobileNo { get; set; }
        public Nullable<int> VerificationCode { get; set; }
    }
}
