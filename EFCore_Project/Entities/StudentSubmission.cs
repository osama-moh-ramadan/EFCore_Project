namespace EFCore_Project.Entities;

public class StudentSubmission
{
    public int Id { get; set; }
    public DateOnly DoneAt { get; set; }
    public string Content { get; set; }
    public decimal? Grade { get; set; }
    public int StudentId { get; set; }
    public int AssignmentId { get; set; }
    public string? Feedback { get; set; }
    public Student Student { get; set; }
    public Assignment Assignment { get; set; }
}