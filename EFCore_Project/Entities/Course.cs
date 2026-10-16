using Azure.Core.Serialization;

namespace EFCore_Project.Entities;

public class Course
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Hours { get; set; }
    public int? PreRequiredCourseId{ get; set; }
    public Course PreRequiredCourse { get; set; } = null!;
    public int? InstructorId { get; set; }
    public Instructor Instructor { get; set; }
    public int? CategoryId { get; set; }
    public Category? Category { get; set; }
    public List<Module> Modules { get; set; }
    public List<Assignment>? Assignments { get; set; }
    public List<Quiz> Quizzes { get; set; }
    public List<Enrollment> Enrollments { get; set; }
    public List<Certificate>? Certificates { get; set; }

}