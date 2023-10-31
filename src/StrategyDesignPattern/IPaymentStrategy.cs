namespace StrategyDesignPattern;

public interface IPaymentStrategy
{
    void Pay(decimal amount);
}