using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class netcentricprojectDBContext : DbContext
    {
        public netcentricprojectDBContext(DbContextOptions<netcentricprojectDBContext> dbContextOptions) : base(dbContextOptions)
        {
            DbContextOptions = dbContextOptions;
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Marks> Markss{ get; set; }

        public DbSet<Subject> Subjects { get; set; }

        public DbSet<MarksModels> MarksModels { get; set; }
        public DbContextOptions<netcentricprojectDBContext> DbContextOptions { get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MarksModels>().HasNoKey();
        }

        //add all the tables from database like student table
    }
}
