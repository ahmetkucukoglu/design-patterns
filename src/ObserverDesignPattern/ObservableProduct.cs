namespace ObserverDesignPattern;

public class ObservableProduct
{
    private List<IProductObserver> Observers { get; set; } = new();

    public void Attach(IProductObserver observer)
    {
        Observers.Add(observer);
    }

    public void Detach(IProductObserver observer)
    {
        Observers.Remove(observer);
    }

    protected void Notify(ProductObserverArgs args)
    {
        foreach (var observer in Observers)
        {
            observer.Update(args);
        }
    }
}