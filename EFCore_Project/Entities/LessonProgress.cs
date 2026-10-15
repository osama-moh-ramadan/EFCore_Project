namespace EFCore_Project.Entities;

public class LessonProgress
{
    public int Id { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime CompletedAt{get; set;}
    public int StudentId { get; set; }
    public Student Student { get; set; }
    public int LessonId { get; set; }
    public Lesson Lesson { get; set; } = null!;
}