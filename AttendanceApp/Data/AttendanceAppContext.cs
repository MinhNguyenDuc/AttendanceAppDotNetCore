using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AttendanceApp.Models;

namespace AttendanceApp.Models
{
    public class AttendanceAppContext : DbContext
    {
        public AttendanceAppContext (DbContextOptions<AttendanceAppContext> options)
            : base(options)
        {
        }

        public DbSet<AttendanceApp.Models.Student> Student { get; set; }

        public DbSet<AttendanceApp.Models.Subject> Subject { get; set; }

        public DbSet<AttendanceApp.Models.Mark> Mark { get; set; }
    }
}
