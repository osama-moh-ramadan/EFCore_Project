namespace EFCore_Project.Entities;

public class Certificate
{
    public int CertificateId { get; set; }
    public DateOnly DateOfCreation { get; set; }
    public int CourseId { get; set; }
    public int StudentId { get; set; }
}