using CadastrodeUsuario.Modelo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace CadastrodeUsuario
{


    public class Contexto : DbContext
    {
        public Contexto() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("meuBd");
        }
        public DbSet<Usuario> Usuarios { get; set; }

    }

}