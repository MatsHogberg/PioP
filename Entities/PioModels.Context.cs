﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entities
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PIOEntities : DbContext
    {
        public PIOEntities()
            : base("name=PIOEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<carrerpath> carrerpath { get; set; }
        public DbSet<comment> comment { get; set; }
        public DbSet<customer> customer { get; set; }
        public DbSet<meeting> meeting { get; set; }
        public DbSet<meetingtype> meetingtype { get; set; }
        public DbSet<onquality> onquality { get; set; }
        public DbSet<ontime> ontime { get; set; }
        public DbSet<person> person { get; set; }
        public DbSet<project> project { get; set; }
        public DbSet<room> room { get; set; }
        public DbSet<site> site { get; set; }
    }
}
