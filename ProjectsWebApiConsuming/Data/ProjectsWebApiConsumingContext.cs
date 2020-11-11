using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjectsWebApiConsuming.Models
{
    public class ProjectsWebApiConsumingContext : DbContext
    {
        public ProjectsWebApiConsumingContext (DbContextOptions<ProjectsWebApiConsumingContext> options)
            : base(options)
        {
        }

        public DbSet<ProjectsWebApiConsuming.Models.Project> Project { get; set; }
    }
}
