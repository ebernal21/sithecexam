using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SithecExamErickBernal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SithecExamErickBernal.Data
{
    public class DatabaseContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public DatabaseContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }
        public DbSet<HumanModel> Humans { get; set; }
    }
}
