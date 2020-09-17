using Microsoft.EntityFrameworkCore;
using TesteLogiin.DataModel;

namespace TesteLogiin.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }
        public DataContext()
        {
                
        }
        public DbSet<DataForGrid> DataForGrids { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<DataForGrid>().ToTable("DataForGrid").HasKey(c => new { c.Id });


        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\\mssqllocaldb;Database=aspnet-TesteLogiin-DEE18744-B767-4332-9FF2-1D4A762DE163;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

    }
}
