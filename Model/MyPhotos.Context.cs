﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyPhotos.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MyPhotosContainer : DbContext
    {
        public MyPhotosContainer()
            : base("name=MyPhotosContainer")
        {
 
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Multimedia> Multimedia { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Photo> Photos { get; set; }
    }
}
