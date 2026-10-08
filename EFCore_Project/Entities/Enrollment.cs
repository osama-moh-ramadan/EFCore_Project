namespace EFCore_Project.Entities;

public class Enrollment
{
    public Course CourseId { get; set; }
    public Student StudentId { get; set; }
    public Payment PaymentId { get; set; }
    public DateOnly ExpireDate { get; set; }
    public enum Status
    {
        Inprogress,
        Completed,
        HavenotEnrolled
    }
}