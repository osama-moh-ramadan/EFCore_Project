using Azure.Core.Serialization;

namespace EFCore_Project.Entities;

public class Course
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public double Hours { get; set; }
    public int? PreRequiredCourseId{ get; set; }
    public Course PreRequiredCourse { get; set; } = null!;
    public List<Module> Modules { get; set; }
}