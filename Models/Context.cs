using Microsoft.EntityFrameworkCore;
using Proyecto_Final.Models.Entities;

namespace Proyecto_Final.Models
{
    public class Context : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        //public DbSet<Producto> Productos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=NAHU; Initial Catalog=PNT1_Final_DB; Integrated Security=true; Encrypt=true; Trustservercertificate=true");
        }
    }
}
