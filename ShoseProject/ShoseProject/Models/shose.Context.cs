﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShoseProject.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class shoseShopDBEntities : DbContext
    {
        public shoseShopDBEntities()
            : base("name=shoseShopDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<tbl_logsale> tbl_logsale { get; set; }
        public DbSet<tbl_typeColour> tbl_typeColour { get; set; }
        public DbSet<tbl_typestyle> tbl_typestyle { get; set; }
        public DbSet<tbl_detail> tbl_detail { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<tbl_login> tbl_login { get; set; }
    }
}
