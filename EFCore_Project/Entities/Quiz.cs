namespace EFCore_Project.Entities;

public class Quiz
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int PassScore { get; set; }
    public double Duration { get; set; }
    public Course CourseId { get; set; }
    public List<Question> Questions { get; set; }
}