namespace StrategyDesignPattern;

public class WalletStrategy : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine("Paying with wallet");
    }
}