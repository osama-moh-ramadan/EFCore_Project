using EFCore_Project.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EFCore_Project.Data;

public class AppDbContext:DbContext
{
    public DbSet<Admin> Admins { get; set; }
    public DbSet<Assignment> Assignments { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Certificate> Certificates { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Enrollment> Enrollments { get; set; }
    public DbSet<Instructor> Instructors { get; set; }
    public DbSet<Lesson> Lessons { get; set; }
    public DbSet<LessonProgress> LessonProgresses { get; set; }
    public DbSet<Module> Modules { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<Quiz> Quizzes { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<StudentAssignment> StudentAssignments { get; set; }
    public DbSet<User> Users { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        var configr = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();
        var constrg = configr.GetSection("ConnectionString").Value;
        optionsBuilder.UseSqlServer(constrg);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}