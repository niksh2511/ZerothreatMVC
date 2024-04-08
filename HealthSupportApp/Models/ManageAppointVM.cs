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
    
    public partial class ManageAppointVM
    {
        public int Id { get; set; }
        public Nullable<int> SatCapacity { get; set; }
        public Nullable<int> SunCapacity { get; set; }
        public Nullable<int> MonCapacity { get; set; }
        public Nullable<int> TueCapacity { get; set; }
        public Nullable<int> WedCapacity { get; set; }
        public Nullable<int> ThuCapacity { get; set; }
        public Nullable<int> FriCapacity { get; set; }
        public Nullable<int> SatAvailableAppoint { get; set; }
        public Nullable<int> SunAvailableAppoint { get; set; }
        public Nullable<int> MonAvailableAppoint { get; set; }
        public Nullable<int> TueAvailableAppoint { get; set; }
        public Nullable<int> WedAvailableAppoint { get; set; }
        public Nullable<int> ThuAvailableAppoint { get; set; }
        public Nullable<int> FriAvailableAppoint { get; set; }
        public Nullable<bool> OnlineAppoint { get; set; }
        public Nullable<int> UsedAppoint { get; set; }
        public Nullable<int> TotalAvailableAppoint { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public Nullable<int> MedicalId { get; set; }
        public Nullable<int> DoctorChamberId { get; set; }
        public int OrderId { get; set; }
        public Nullable<int> AppointAmount { get; set; }
        public Nullable<int> RemainingAppoint { get; set; }
        public Nullable<int> TotalAppoint { get; set; }
        public Nullable<System.DateTime> ExpireDate { get; set; }
        public Nullable<bool> Expired { get; set; }
        public string Status { get; set; }
    }
}
