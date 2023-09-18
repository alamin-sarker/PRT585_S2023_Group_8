using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using _2DataAccessLayer.Context.Models;

namespace _2DataAccessLayer.Context
{
    public class AuthDbContext : IdentityDbContext
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
        {

        }

        public DbSet<Person> People { get; set; }
        public DbSet<Movie> Movies { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Unit> Units { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<StudentRegistration> StudentRegistrations { get; set; }
        public DbSet<StaffRegistration> StaffRegistrations { get; set; }

    }
}