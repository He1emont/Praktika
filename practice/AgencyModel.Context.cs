﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace practice
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AgencyEntities : DbContext
    {
        public AgencyEntities()
            : base("name=AgencyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Anket> Anket { get; set; }
        public virtual DbSet<Astrol> Astrol { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Mened> Mened { get; set; }
        public virtual DbSet<Para> Para { get; set; }
        public virtual DbSet<Pol> Pol { get; set; }
        public virtual DbSet<Psixo> Psixo { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Test_astrol> Test_astrol { get; set; }
        public virtual DbSet<Test_psixo> Test_psixo { get; set; }
    }
}
