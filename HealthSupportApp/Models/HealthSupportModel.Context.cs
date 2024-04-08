﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HealthSupportDBEntities : DbContext
    {
        public HealthSupportDBEntities()
            : base("name=HealthSupportDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AssignedDoctor> AssignedDoctors { get; set; }
        public virtual DbSet<BookAppointment> BookAppointments { get; set; }
        public virtual DbSet<DiagnosticService> DiagnosticServices { get; set; }
        public virtual DbSet<DoctorAppointOrder> DoctorAppointOrders { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<DoctorsChamber> DoctorsChambers { get; set; }
        public virtual DbSet<DoctorsSpeciality> DoctorsSpecialities { get; set; }
        public virtual DbSet<ForgetPasswordVerification> ForgetPasswordVerifications { get; set; }
        public virtual DbSet<ForumComment> ForumComments { get; set; }
        public virtual DbSet<ForumPost> ForumPosts { get; set; }
        public virtual DbSet<HospitalService> HospitalServices { get; set; }
        public virtual DbSet<MainAdmin> MainAdmins { get; set; }
        public virtual DbSet<ManageAppointment> ManageAppointments { get; set; }
        public virtual DbSet<MedicalAccount> MedicalAccounts { get; set; }
        public virtual DbSet<MedicalConsultant> MedicalConsultants { get; set; }
        public virtual DbSet<MedicalEmergency> MedicalEmergencies { get; set; }
        public virtual DbSet<MedicalFacility> MedicalFacilities { get; set; }
        public virtual DbSet<OtherMedicalService> OtherMedicalServices { get; set; }
        public virtual DbSet<TopicCategory> TopicCategories { get; set; }
        public virtual DbSet<UserAccount> UserAccounts { get; set; }
        public virtual DbSet<ChambersAppointOrder> ChambersAppointOrders { get; set; }
        public virtual DbSet<CommentsVM> CommentsVMs { get; set; }
        public virtual DbSet<DoctorChamberOrder> DoctorChamberOrders { get; set; }
        public virtual DbSet<DoctorChambersAppointOrder> DoctorChambersAppointOrders { get; set; }
        public virtual DbSet<ForumPostsVM> ForumPostsVMs { get; set; }
        public virtual DbSet<ManageAppointVM> ManageAppointVMs { get; set; }
        public virtual DbSet<ViewDoctorChamber> ViewDoctorChambers { get; set; }
        public virtual DbSet<ViewDoctor> ViewDoctors { get; set; }
    }
}