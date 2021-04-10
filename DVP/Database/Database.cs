using DVP.Models;
using Microsoft.EntityFrameworkCore;

namespace DVP.Database
{
    public class Database : Microsoft.EntityFrameworkCore.DbContext
    {
        public Database(DbContextOptions<Database> options)
       : base(options)
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

    }

        
}
