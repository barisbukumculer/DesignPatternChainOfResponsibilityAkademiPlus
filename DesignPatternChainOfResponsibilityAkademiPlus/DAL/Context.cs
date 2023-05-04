using Microsoft.EntityFrameworkCore;

namespace DesignPatternChainOfResponsibilityAkademiPlus.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-5SF4DGP\\SQLEXPRESS;initial catalog=AkademiPlusChainOfRespDb;integrated security=true");
        }

        public DbSet<CustomerProcess> CustomerProcesses { get; set; }
    }
}
