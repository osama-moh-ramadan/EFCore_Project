namespace EFCore_Project.Entities;

public class Quiz
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int PassScore { get; set; }
    public int Duration { get; set; }
    public int CourseId { get; set; }
    public Course Course { get; set; }
    public List<Question> Questions { get; set; }
    public List<QuizAttempt> QuizAttempts { get; set; }
}