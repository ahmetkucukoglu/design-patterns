namespace ObserverDesignPattern;

public class Product : ObservableProduct
{
    public int Id { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }

    public void UpdateStock(int stock)
    {
        var previousStock = Stock;
        Stock = stock;

        Notify(new ProductObserverArgs
        {
            Id = Id,
            PreviousStock = previousStock,
            NewStock = stock
        });
    }

    public void UpdatePrice(decimal price)
    {
        var previousPrice = Price;
        Price = price;

        Notify(new ProductObserverArgs
        {
            Id = Id,
            PreviousPrice = previousPrice,
            NewPrice = price
        });
    }
}