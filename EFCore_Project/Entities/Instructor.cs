namespace EFCore_Project.Entities;

public class Instructor:User
{
    public int Id { get; set; }
    public Role Role 
    {   get;
        set { Role = Role.Instructor; }
    }
}