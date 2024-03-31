using Microsoft.EntityFrameworkCore;
using WebSurok.Data.Entities;

namespace WebSurok.Data
{
    public class MyAppContext : DbContext
    {
        public MyAppContext(DbContextOptions<MyAppContext> options) 
            :base(options)
        {
            
        }
        public DbSet<CategoryEntity> Categories { get; set; }
    }
}
