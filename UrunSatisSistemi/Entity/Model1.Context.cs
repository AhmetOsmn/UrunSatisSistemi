﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UrunSatisSistemi.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class USSEntities : DbContext
    {
        public USSEntities()
            : base("name=USSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Kategoriler> Kategoriler { get; set; }
        public virtual DbSet<Musteriler> Musteriler { get; set; }
        public virtual DbSet<Personeller> Personeller { get; set; }
        public virtual DbSet<Satislar> Satislar { get; set; }
        public virtual DbSet<Urunler> Urunler { get; set; }
        public virtual DbSet<Adminler> Adminler { get; set; }
    }
}
