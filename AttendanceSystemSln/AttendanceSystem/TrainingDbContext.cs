using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem
{
    public class TrainingDbContext : DbContext
    {
        private readonly string _ConnectionString; 
        private readonly string _AssemblyName; 
        public TrainingDbContext()
        {
            _ConnectionString = @"Server = DESKTOP-K32T5PF; Database = AttendanceSystem; Integrated Security = true;";
            _AssemblyName = Assembly.GetExecutingAssembly().GetName().Name;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_ConnectionString, m => m.MigrationsAssembly(_AssemblyName));
            }
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AttendanceSheet>().ToTable("AttendanceSheets");
            modelBuilder.Entity<AttendanceSheet>().HasKey(cs => new { cs.CourseID, cs.StudentID });

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> courses { get; set; }
    }
}
