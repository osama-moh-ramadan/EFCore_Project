namespace EFCore_Project.Entities;

public class Assignment
{
    public int Id { get; set; }
    public DateTime Deadline { get; set; }
    public string Feedback { get; set; }
    public Course CourseId { get; set; }
    public Instructor InstructorId { get; set; }
}