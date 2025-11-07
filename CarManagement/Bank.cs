namespace CarManagement;

public class Bank
{
    public double Balance { get; set; }
    public List<Transaction> transactions = new List<Transaction>();

    public void Deposit(double amount, string type)
    {
        if (amount < 0 || amount == 0)
        {
            Console.WriteLine("Amount cannot be negative or zero");
            return;
        }
        Balance += amount;
        transactions.Add(new Transaction(type, amount));
    }

    public void WithDraw(double amount, string type)
    {
        if (amount < 0)
        {
            Console.WriteLine("Amount cannot be negative");
            return;
        }
        else if (amount > Balance)
        {
            Console.WriteLine("Balance not enough");
            return;
        }

        Balance -= amount;
        transactions.Add(new Transaction(type, amount));
    }

    public void ShowTransactions()
    {
        if (transactions.Count == 0)
        {
            Console.WriteLine("No transaction");
            return;
        }
        Console.WriteLine("Transactions: ");
        foreach (Transaction transaction in transactions)
        {
            Console.WriteLine($"Code: {transaction.Code} Type: {transaction.Type} Amount: {transaction.Amount} AZN");
            Console.WriteLine();
        }
    }

}
