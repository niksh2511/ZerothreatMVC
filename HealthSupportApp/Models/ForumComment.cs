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
    
    public partial class ForumComment
    {
        public int CommentId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public Nullable<int> MedicalId { get; set; }
        public Nullable<int> ForumPostId { get; set; }
        public string Comment { get; set; }
    
        public virtual ForumPost ForumPost { get; set; }
    }
}
