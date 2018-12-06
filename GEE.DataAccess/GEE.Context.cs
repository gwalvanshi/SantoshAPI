﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GEE.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GEEDbContext : DbContext
    {
        public GEEDbContext()
            : base("name=GEEDbContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AcademicYear> AcademicYears { get; set; }
        public virtual DbSet<AdmissionDetail> AdmissionDetails { get; set; }
        public virtual DbSet<AdmissionDocumentList> AdmissionDocumentLists { get; set; }
        public virtual DbSet<Application> Applications { get; set; }
        public virtual DbSet<CandidateDetail> CandidateDetails { get; set; }
        public virtual DbSet<CastCategory> CastCategories { get; set; }
        public virtual DbSet<ClassMaster> ClassMasters { get; set; }
        public virtual DbSet<Designation> Designations { get; set; }
        public virtual DbSet<DocumentSubmission> DocumentSubmissions { get; set; }
        public virtual DbSet<Enquiry> Enquiries { get; set; }
        public virtual DbSet<EnquiryType> EnquiryTypes { get; set; }
        public virtual DbSet<GroupMaster> GroupMasters { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<LoginTrack> LoginTracks { get; set; }
        public virtual DbSet<MarketingSource> MarketingSources { get; set; }
        public virtual DbSet<Qualificaton> Qualificatons { get; set; }
        public virtual DbSet<Registration> Registrations { get; set; }
        public virtual DbSet<Religion> Religions { get; set; }
        public virtual DbSet<SchoolMaster> SchoolMasters { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<UserMaster> UserMasters { get; set; }
        public virtual DbSet<tblSize> tblSizes { get; set; }
        public virtual DbSet<TestTable> TestTables { get; set; }
        public virtual DbSet<tblUnit> tblUnits { get; set; }
    }
}
