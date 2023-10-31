namespace StrategyDesignPattern;

public class Cart
{
    public decimal TotalPrice { get; set; }
    private IPaymentStrategy PaymentStrategy { get; set; }

    public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
    {
        PaymentStrategy = paymentStrategy;
    }

    public void Pay()
    {
        PaymentStrategy.Pay(TotalPrice);
    }
}