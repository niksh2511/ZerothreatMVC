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
    
    public partial class MedicalEmergency
    {
        public int Id { get; set; }
        public string TwentyFourService { get; set; }
        public string EmergencyService { get; set; }
        public string AmbulanceService { get; set; }
        public Nullable<int> SeatCapacity { get; set; }
        public string EmergencyPhoneNo { get; set; }
        public string EmergencyPhoneNo2 { get; set; }
        public string AmbulancePhoneNo { get; set; }
        public string AmbulancePhoneNo2 { get; set; }
        public Nullable<int> MedicalId { get; set; }
    
        public virtual MedicalAccount MedicalAccount { get; set; }
    }
}
