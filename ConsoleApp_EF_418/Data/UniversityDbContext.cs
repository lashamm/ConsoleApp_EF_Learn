using ConsoleApp_EF_418.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp_EF_418.Data
{
    internal class UniversityDbContext : DbContext
    {
        // ცხრილი
        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Faculty> Faculties { get; set; }

        //public DbSet<Lecturer> Lecturers { get; set; }

        // რა სერვერს უკავშირდება? ბაზის სახელი?
        // connection string
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=University;Trusted_Connection=True;ConnectRetryCount=0");
        }
    }
}
