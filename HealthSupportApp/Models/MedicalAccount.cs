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
    
    public partial class MedicalAccount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MedicalAccount()
        {
            this.AssignedDoctors = new HashSet<AssignedDoctor>();
            this.DiagnosticServices = new HashSet<DiagnosticService>();
            this.ForumPosts = new HashSet<ForumPost>();
            this.HospitalServices = new HashSet<HospitalService>();
            this.MedicalConsultants = new HashSet<MedicalConsultant>();
            this.MedicalFacilities = new HashSet<MedicalFacility>();
            this.MedicalEmergencies = new HashSet<MedicalEmergency>();
            this.OtherMedicalServices = new HashSet<OtherMedicalService>();
        }
    
        public int MedicalId { get; set; }
        public string Role { get; set; }
        public string MedicalType { get; set; }
        public string MedicalName { get; set; }
        public string ContactPersonName { get; set; }
        public string ContactPersonPosition { get; set; }
        public string ContactPersonPhoneNo { get; set; }
        public string MedicalEmail { get; set; }
        public string MedicalContact1 { get; set; }
        public string MedicalContact2 { get; set; }
        public string Address { get; set; }
        public string Area { get; set; }
        public string City { get; set; }
        public string AmbulanceService { get; set; }
        public string AmbulanceContact { get; set; }
        public string Password { get; set; }
        public bool IsEmailVerified { get; set; }
        public System.Guid ActivationCode { get; set; }
        public string Status { get; set; }
        public string AccountCreatedDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssignedDoctor> AssignedDoctors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiagnosticService> DiagnosticServices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ForumPost> ForumPosts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HospitalService> HospitalServices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedicalConsultant> MedicalConsultants { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedicalFacility> MedicalFacilities { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedicalEmergency> MedicalEmergencies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OtherMedicalService> OtherMedicalServices { get; set; }
    }
}
