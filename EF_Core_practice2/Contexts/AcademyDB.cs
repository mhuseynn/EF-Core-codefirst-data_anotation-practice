using EF_Core_practice2.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
namespace EF_Core_practice2.Contexts;

public class AcademyDB: DbContext
{

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string Constr = "Data Source=DESKTOP-R8Q6LD3\\SQLEXPRESS;Initial Catalog=AcademyDB;Integrated Security=False;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
        optionsBuilder.UseSqlServer(Constr);

        
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Curator>()
            .Property(p => p.Name)
            .HasDefaultValue("Bosdur");


        modelBuilder.Entity<Curator>()
            .Property(p => p.Surname)
            .HasDefaultValue("Bosdur");
            
        modelBuilder.Entity<Department>()
            .Property(p => p.Name)
            .HasDefaultValue("Bosdur");

        modelBuilder.Entity<Department>()
         .Property(p => p.Financing)
         .HasDefaultValue(1);



        modelBuilder.Entity<Faculty>()
         .Property(p => p.Name)
         .HasDefaultValue("Bos");


        
        modelBuilder.Entity<Student>().Property(p => p.Name)
         .HasDefaultValue("Bos");

        modelBuilder.Entity<Student>().Property(p => p.Surname)
         .HasDefaultValue("Bos");

       
        modelBuilder.Entity<Subject>().Property(p => p.Name)
         .HasDefaultValue("Bos");


        modelBuilder.Entity<Teacher>().Property(p => p.Name)
         .HasDefaultValue("Bos");

        modelBuilder.Entity<Teacher>().Property(p => p.Surname)
         .HasDefaultValue("Bos");

        modelBuilder.Entity<Teacher>().Property(p => p.Salary)
         .HasDefaultValue(1);

        base.OnModelCreating(modelBuilder);
    }



    public DbSet<Curator> Curators { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Faculty> Faculties { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<GroupCurator> GroupsCurators { get; set; }
    public DbSet<GroupLecture> GroupsLectures { get; set; }
    public DbSet<GroupStudent> GroupsStudents { get; set; }
    public DbSet<Lecture> Lectures { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
}
