using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASTROBIT_BACKEND.Entidades;

namespace ASTROBIT_BACKEND
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options):base(options)
        {

        }

        public DbSet<Usuario> USUARIO { get; set; }
        public DbSet<UsuarioMoeda> UsuarioMoeda { get; set; }
        public DbSet<Moeda> Moeda { get; set; }

    }
}
