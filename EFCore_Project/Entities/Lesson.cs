namespace EFCore_Project.Entities;

public class Lesson
{
    public int Id { get; set; }
    public string Name{ get; set; }
    public Module ModuleId { get; set; }
}