#nullable disable
using Microsoft.EntityFrameworkCore;
using ThanksCardServer2.Tables;

namespace ThanksCardServer2.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Belongs> Belongs { get; set; }
        public DbSet<ThanksCard> ThanksCards { get; set; }
        public DbSet<Title> Titles { get; set; }    
        public DbSet<Template> Templates { get; set; }
        public DbSet<Reply> Replies { get; set; }
    }
}

