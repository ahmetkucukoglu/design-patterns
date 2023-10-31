namespace ObserverDesignPattern;

public class ProductPriceObserver : IProductObserver
{
    public void Update(ProductObserverArgs args)
    {
        if (args.NewPrice.GetValueOrDefault() >= args.PreviousPrice.GetValueOrDefault()) return;

        //TODO Inject a service and get users who subscribe to the product.
        Console.WriteLine($"The product price dropped. {args.PreviousPrice} -> {args.NewPrice}");
    }
}