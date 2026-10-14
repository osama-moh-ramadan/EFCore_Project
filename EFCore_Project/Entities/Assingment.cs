namespace EFCore_Project.Entities;

public class Assignment
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal MaxGrade { get; set; }
    public DateTime Deadline { get; set; }
    
    public int CourseId { get; set; }
    public int InstructorId { get; set; }
    public List<StudentSubmission> StudentSubmissions { get; set; } = new();
}