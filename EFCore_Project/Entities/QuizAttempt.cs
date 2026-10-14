using System.Runtime.InteropServices.JavaScript;
using System.Security.AccessControl;

namespace EFCore_Project.Entities;

public class QuizAttempt
{
    public int Id { get; set; }
    public DateTime  StartedAt { get; set; }
    public DateTime? SubmittedAt { get; set; }
    public decimal Score { get; set; }
    public int QuizId { get; set; }
    public Quiz Quiz { get; set; }
    public int StudentId { get; set; }
    public Student Student { get; set; }
}