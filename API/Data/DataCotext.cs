using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataCotext : DbContext
    {
        public DataCotext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<AppUser> Users { get; set; }
    }
}