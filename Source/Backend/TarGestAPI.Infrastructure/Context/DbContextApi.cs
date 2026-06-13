using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarGestAPI.Infrastructure.Context
{
    public class DbContextApi: DbContext
    {
        public DbContextApi(DbContextOptions options): base(options)
        {
            
        }

        public DbSet<Task> Tasks;

    }
}
