namespace EFCore_Project.Entities;

public class Enrollment
{
    public int Id { get; set; }
    public int CourseId { get; set; }
    public int StudentId { get; set; }
    public int? PaymentId { get; set; }
    public Payment Payment { get; set; } = null!;
    public DateOnly ExpireDate { get; set; }
    public EnrollmentStatus Status { get; set; }
    public Course Course { get; set; }
    public Student Student { get; set; }
}
    public enum EnrollmentStatus
    {
        Inprogress,
        Completed,
        HavenotEnrolled
    }
