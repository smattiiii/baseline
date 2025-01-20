using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OS_GJ_Tutoring.Models;

namespace OS_GJ_Tutoring.Data
{
    public class OS_GJ_TutoringContext : DbContext
    {
        public OS_GJ_TutoringContext (DbContextOptions<OS_GJ_TutoringContext> options)
            : base(options)
        {
        }

        public DbSet<OS_GJ_Tutoring.Models.SessionsDB> SessionsDB { get; set; } = default!;
        public DbSet<OS_GJ_Tutoring.Models.CoursesDB> CoursesDB { get; set; } = default!;
        public DbSet<OS_GJ_Tutoring.Models.BookDB> BookDB { get; set; } = default!;
        public DbSet<OS_GJ_Tutoring.Models.StayDB> StayDB { get; set; } = default!;
    }
}
