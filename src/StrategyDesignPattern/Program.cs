using StrategyDesignPattern;

Console.WriteLine(
    Enum.GetValues<PaymentMethods>()
        .Select((e, i) => $"{i + 1}. {e.ToString()}")
        .Aggregate((x, y) => x + Environment.NewLine + y));

var key = Console.ReadLine()!;

var hasPaymentMethod = Enum.TryParse<PaymentMethods>(key, out var paymentMethod);

if (!hasPaymentMethod) return;

var cart = new Cart
{
    TotalPrice = 1453M
};

switch (paymentMethod)
{
    case PaymentMethods.CreditCard:
    {
        Console.Write("Card Number : ");
        var cardNumber = Console.ReadLine();

        if (string.IsNullOrEmpty(cardNumber)) return;

        Console.Write("Full Name : ");
        var fullName = Console.ReadLine();

        if (string.IsNullOrEmpty(fullName)) return;

        Console.Write("Expiry Date : ");
        var expiryDate = Console.ReadLine();

        if (string.IsNullOrEmpty(expiryDate)) return;

        Console.Write("Cvc : ");
        var cvc = Console.ReadLine();

        if (string.IsNullOrEmpty(cvc)) return;

        cart.SetPaymentStrategy(new CreditCardStrategy(cardNumber, fullName, expiryDate, cvc));
        break;
    }
    case PaymentMethods.Wallet:
        cart.SetPaymentStrategy(new WalletStrategy());
        break;
    default:
        throw new ArgumentOutOfRangeException();
}

cart.Pay();