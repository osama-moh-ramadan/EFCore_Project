namespace EFCore_Project.Entities;

public class Module
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Course CourseId { get; set; }
}