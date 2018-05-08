using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IT.Models;

namespace IT.Models
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<IT.Models.About> About { get; set; }

        public DbSet<IT.Models.Gallery> Gallery { get; set; }

        public DbSet<IT.Models.News> News { get; set; }
    }
}
