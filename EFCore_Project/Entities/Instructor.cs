namespace EFCore_Project.Entities;

public class Instructor:User
{    public string Bio { get; set; } = string.Empty;
    public string Expertise { get; set; } = string.Empty;
    public List<Course> Courses { get; set; }
    public List<Assignment> Assignments { get; set; }
}