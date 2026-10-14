namespace EFCore_Project.Entities;

public class Question
{
    public int Id { get; set; }
    public string Text { get; set; }
    public string CorrectAnswer { get; set; }
    public string? Options { get; set; }
    public int QuizId { get; set; }
    public Quiz Quiz { get; set; }

    public enum Type
    {
        MCQ,
        TrueFalse
    }
}