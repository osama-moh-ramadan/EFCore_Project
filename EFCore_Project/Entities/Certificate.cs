namespace EFCore_Project.Entities;

public class Certificate
{
    public int CertificateId { get; set; }
    public DateOnly DateOfCreation { get; set; }
    public Course CourseId { get; set; }
    public Student StudentId { get; set; }
}