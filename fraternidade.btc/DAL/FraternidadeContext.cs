using fraternidade.btc.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace fraternidade.btc.DAL
{
    public class fraternidadeDBContext : DbContext
    {
        public DbSet<EnderecoBitcoin> EnderecosBitcoin { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Usuario>().HasMany(u => u.EnderecosBitcoin);           
        }

        public static fraternidadeDBContext Create()
        {
            return new fraternidadeDBContext();
        }
    }
}