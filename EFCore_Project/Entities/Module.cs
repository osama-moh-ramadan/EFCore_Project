namespace EFCore_Project.Entities;

public class Module
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int OrderIndex { get; set; }
    public Course Course { get; set; }
    public int CourseId { get; set; }
    public List<Lesson> Lessons { get; set; }
}