﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PetApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class PetAppContext : DbContext
    {
        public PetAppContext()
            : base("name=PetAppContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<ClientesxMascotas> ClientesxMascotas { get; set; }
        public virtual DbSet<Mascota> Mascota { get; set; }
        public virtual DbSet<Pesos> Pesos { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<Vacunas> Vacunas { get; set; }
    
        public virtual ObjectResult<Nullable<int>> sp_Login(Nullable<int> option, string email, string password)
        {
            var optionParameter = option.HasValue ?
                new ObjectParameter("Option", option) :
                new ObjectParameter("Option", typeof(int));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_Login", optionParameter, emailParameter, passwordParameter);
        }
    }
}
