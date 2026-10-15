namespace EFCore_Project.Entities;

public class Lesson
{
    public int Id { get; set; }
    public string Name{ get; set; }
    public int ModuleId { get; set; }
    public LessonType Type { get; set; }  // Video, Article, PDF
    public string ContentUrl { get; set; } = string.Empty;
    public int DurationMinutes { get; set; }
    public int OrderIndex { get; set; }
    public Module Module { get; set; } = null!;
    public List<LessonProgress>? LessonProgresses { get; set; }
}public enum  LessonType
{
    Video,PDF,Article
}