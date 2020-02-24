using ImdbData.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImdbData.Contexts
{
    public class ImdbContext : DbContext
    {
        public DbSet<Cast> Cast { get; set; }
        public DbSet<CastRole> CastRole { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<MovieCastRoleMapping> MovieCastRoleMapping { get; set; }


        public ImdbContext() : base("name=ImdbDbContext")
        {

        }
    }
}
