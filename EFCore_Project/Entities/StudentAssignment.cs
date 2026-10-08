namespace EFCore_Project.Entities;

public class StudentAssignment
{
    public int Id { get; set; }
    public DateOnly DoneAt { get; set; }
    public string Content { get; set; }
    public double Grade { get; set; }
    public Student StudentId { get; set; }
    public Assignment AssignmentId { get; set; }
}