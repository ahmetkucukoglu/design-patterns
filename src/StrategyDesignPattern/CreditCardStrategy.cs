namespace StrategyDesignPattern;

public class CreditCardStrategy : IPaymentStrategy
{
    private string CardNumber { get; set; }
    private string FullName { get; set; }
    private string ExpiryDate { get; set; }
    private string Cvc { get; set; }

    public CreditCardStrategy(string cardNumber, string fullName, string expiryDate, string cvc)
    {
        CardNumber = cardNumber;
        FullName = fullName;
        ExpiryDate = expiryDate;
        Cvc = cvc;
    }

    public void Pay(decimal amount)
    {
        Console.WriteLine("Paying with credit card");
    }
}