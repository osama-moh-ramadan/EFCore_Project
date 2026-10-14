namespace EFCore_Project.Entities;

public class Payment
{
    public int Id { get; set; }
    public bool IsDone { get; set; }
    public decimal Amount { get; set; }
    public DateTime PaymentDate { get; set; }
    public string  PaymentMethod { get; set; }
}