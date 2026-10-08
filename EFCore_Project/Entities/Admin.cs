namespace EFCore_Project.Entities;

public class Admin : User
{
    public int Id { get; set; }

    public Role Role
    {
        get;
        set { Role = Role.Admin; }
    }
}
