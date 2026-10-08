namespace EFCore_Project.Entities;

public class Question
{
    public int Id { get; set; }
    public string Text { get; set; }
    public char CorrectAnswer { get; set; }
    public Quiz QuizId { get; set; }

    public enum Type
    {
        MCQ,
        TrueFalse
    }
}