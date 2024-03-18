using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Entities
{
    public class CompanyDbContext : DbContext
    {
        private string _connectionString = "Server=(localdb)\\mssqllocaldb;Database=EmployeeManagementDb;Trusted_Connection=True;";
        public DbSet<Company> Companys { get; set; }
        public DbSet<Address> Addresss { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Duty> Duties { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>()
                .Property(c => c.Id)
                .IsRequired(true);

            modelBuilder.Entity<Company>()
                .Property(c => c.Name)
                .IsRequired(true)
                .HasMaxLength(30);

            modelBuilder.Entity<Company>()
                .Property(c => c.Description)
                .IsRequired(false)
                .HasMaxLength(200);

            modelBuilder.Entity<Company>()
                .Property(c => c.ContactEmail)
                .IsRequired(true)
                .HasMaxLength(50);

            modelBuilder.Entity<Company>()
                .Property(c => c.AddressId)
                .IsRequired(true);

            modelBuilder.Entity<Company>()
                .HasOne(c => c.Address)
                .WithOne(a => a.Company)
                .HasForeignKey<Address>(a => a.CompanyId)
                .IsRequired();

            modelBuilder.Entity<Address>()
                .Property(a => a.Id)
                .IsRequired(true);

            modelBuilder.Entity<Address>()
                .Property(a => a.City)
                .IsRequired(false)
                .HasMaxLength(30);

            modelBuilder.Entity<Address>()
                .Property(a => a.Street)
                .IsRequired(false)
                .HasMaxLength(30);

            modelBuilder.Entity<Address>()
                .Property(a => a.PostalCode)
                .IsRequired(true)
                .HasMaxLength(20);

            modelBuilder.Entity<Address>()
                .Property(a => a.CompanyId)
                .IsRequired(true);

            modelBuilder.Entity<Address>()
                .HasOne(a => a.Company)
                .WithOne(c => c.Address)
                .HasForeignKey<Company>(c => c.AddressId)
                .IsRequired();

            modelBuilder.Entity<Employee>()
                .Property(e => e.Id)
                .IsRequired(true);

            modelBuilder.Entity<Employee>()
                .Property(e => e.FirstName)
                .IsRequired(true)
                .HasMaxLength(30);

            modelBuilder.Entity<Employee>()
                .Property(e => e.LastName)
                .IsRequired(true)
                .HasMaxLength(30);

            modelBuilder.Entity<Employee>()
                .Property(e => e.JobPosition)
                .IsRequired(true);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Salary)
                .IsRequired(true)
                .HasMaxLength(10);

            modelBuilder.Entity<Employee>()
                .Property(e => e.CompanyId)
                .IsRequired(true);

            modelBuilder.Entity<Duty>()
                .Property(d => d.Id)
                .IsRequired(true);

            modelBuilder.Entity<Duty>()
                .Property(d => d.Title)
                .IsRequired(true)
                .HasMaxLength(50);

            modelBuilder.Entity<Duty>()
                .Property(d => d.Description)
                .IsRequired(false)
                .HasMaxLength(200);

            modelBuilder.Entity<Duty>()
                .Property(d => d.Prioryty)
                .IsRequired(true);

            modelBuilder.Entity<Duty>()
                .Property(d => d.EmployeeId)
                .IsRequired(true);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
