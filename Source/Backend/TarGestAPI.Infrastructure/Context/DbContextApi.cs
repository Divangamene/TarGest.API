using Microsoft.EntityFrameworkCore;
using TarGestAPI.Domain.Entities;

namespace TarGestAPI.Infrastructure.Context
{
    public class DbContextApi: DbContext
    {
        public DbContextApi(DbContextOptions options): base(options)
        {
            
        }

        public DbSet<Tasks>  Tasks { get; set; } 

    }
}
