﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SampleProject_DataAccess.DataModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HTATollDataEntities : DbContext
    {
        public HTATollDataEntities()
            : base("name=HTATollDataEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Daily_Fleet_File_Details> Daily_Fleet_File_Details { get; set; }
        public virtual DbSet<Daily_Fleet_File_Header> Daily_Fleet_File_Header { get; set; }
        public virtual DbSet<Error_Acknowledgement_Details> Error_Acknowledgement_Details { get; set; }
        public virtual DbSet<Error_Acknowledgement_Header> Error_Acknowledgement_Header { get; set; }
        public virtual DbSet<Error_Notes> Error_Notes { get; set; }
        public virtual DbSet<Vehicle_Upload_File_Details> Vehicle_Upload_File_Details { get; set; }
        public virtual DbSet<Vehicle_Upload_File_Header> Vehicle_Upload_File_Header { get; set; }
        public virtual DbSet<Error_Status> Error_Status { get; set; }
    }
}
