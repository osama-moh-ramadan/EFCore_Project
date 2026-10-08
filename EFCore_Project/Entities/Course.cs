using Azure.Core.Serialization;

namespace EFCore_Project.Entities;

public class Course
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public double Hours { get; set; }
    public Course PreRequired{ get; set; }
    public Instructor InstructorId { get; set; }
    public Category CategoryId { get; set; }
}