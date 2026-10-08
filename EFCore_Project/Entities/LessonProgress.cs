namespace EFCore_Project.Entities;

public class LessonProgress
{
    public int Id { get; set; }
    public bool IsDone { get; set; }
    public DateTime CompletedOn{get; set;}
    public Student StudentId { get; set; }
    public Lesson LessonId { get; set; }
}