﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Coding_Tech.Models.CTDbModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class fontDbContext : DbContext
    {
        public fontDbContext()
            : base("name=fontDbContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblBuilding> tblBuildings { get; set; }
        public virtual DbSet<tblCity> tblCities { get; set; }
        public virtual DbSet<tblCountry> tblCountries { get; set; }
        public virtual DbSet<tblCustomer> tblCustomers { get; set; }
        public virtual DbSet<tblFloor> tblFloors { get; set; }
        public virtual DbSet<tblInterest> tblInterests { get; set; }
        public virtual DbSet<tblShop> tblShops { get; set; }
        public virtual DbSet<tblUser> tblUsers { get; set; }
    }
}
