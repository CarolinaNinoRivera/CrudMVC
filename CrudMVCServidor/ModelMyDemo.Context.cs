﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CrudMVCServidor
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BDProyectoIEntities : DbContext
    {
        public BDProyectoIEntities()
            : base("name=BDProyectoIEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Calificaciones> Calificaciones { get; set; }
        public virtual DbSet<Cursos> Cursos { get; set; }
        public virtual DbSet<EstudiantesEntity> EstudiantesEntities { get; set; }
        public virtual DbSet<Materias> Materias { get; set; }
        public virtual DbSet<Matriculas> Matriculas { get; set; }
        public virtual DbSet<Profesores> Profesores { get; set; }
        public virtual DbSet<UsuariosEntity> Usuarios { get; set; }
    }
}
