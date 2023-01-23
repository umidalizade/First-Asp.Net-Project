using Microsoft.EntityFrameworkCore;

namespace FirsttApi.DataAccessLayer
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-U70A4ID\\SQLEXPRESS;database=CoreBlogApiDb; integrated security=true;");
        }

        public DbSet<Worker> Workers { get; set; }
    }
}
