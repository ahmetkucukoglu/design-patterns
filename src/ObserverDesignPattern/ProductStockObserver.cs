namespace ObserverDesignPattern;

public class ProductStockObserver : IProductObserver
{
    public void Update(ProductObserverArgs args)
    {
        if (args.PreviousPrice.GetValueOrDefault() > 0 || args.NewStock == 0) return;

        //TODO Inject a service and get users who subscribe to the product.
        Console.WriteLine($"The product is in stock. Stock : {args.NewStock}");
    }
}