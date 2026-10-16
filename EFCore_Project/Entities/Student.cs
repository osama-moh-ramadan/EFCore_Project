namespace EFCore_Project.Entities;

public class Student : User
{
    public List<Enrollment> Enrollments { get; set; }
    public List<LessonProgress> LessonProgresses { get; set; }
    public List<Certificate> Certificates { get; set; }
}