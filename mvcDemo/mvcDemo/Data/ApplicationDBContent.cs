using Microsoft.EntityFrameworkCore;
using mvcDemo.Models;

namespace mvcDemo.Data
{ 

     public class ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : DbContext(options)
    {

        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
