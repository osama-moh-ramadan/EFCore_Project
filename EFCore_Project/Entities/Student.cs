namespace EFCore_Project.Entities;

public class Student:User
{
    public int  Id { get; set; }

    public Role Role
    {
        get;
        set { Role = Role.Student; }
    }
    public User userId { get; set; }
}