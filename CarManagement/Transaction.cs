namespace CarManagement;

public class Transaction
{
    public Guid Code { get; set; }
    public string Type { get; set; }
    public double Amount { get; set; }

    public Transaction(string type,double amount)
    {
        Code=Guid.NewGuid();
        Type=type;
        Amount=amount;
    }
}
