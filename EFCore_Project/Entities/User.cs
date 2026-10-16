namespace EFCore_Project.Entities;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string HashPassword { get; set; }
    public Role Role { get; set; }
    public bool IsDeleted { get; set; }
}
    public enum Role
    {
        Student,
        Instructor,
        Admin
    }
