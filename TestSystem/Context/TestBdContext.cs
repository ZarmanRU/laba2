using Microsoft.EntityFrameworkCore;
using TestSystem.Models;

namespace TestSystem.Context
{
    public class TestBdContext : DbContext
    {
        public TestBdContext(DbContextOptions<TestBdContext> options):base(options) 
        {

        }
        public DbSet<Test> Tests { get; set; }
    }

}
