using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern.ObserverDP.DAL
{
    public class Context:IdentityDbContext<AppUser, AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB; initial catalog=DesignPatternObserver; integrated security=true;");
        }
        public DbSet<Discount>? Discounts { get; set; }
        public DbSet<WelcomeMessage>? WelcomeMessages { get; set; }
        public DbSet<UserProcess>? UserProcesses { get; set; }
    }
}
