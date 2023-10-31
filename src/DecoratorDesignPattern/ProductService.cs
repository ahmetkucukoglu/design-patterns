namespace DecoratorDesignPattern;

public class ProductService : IProductService
{
    public List<Product> GetProducts()
    {
        Console.WriteLine("Products fetched");

        return Enumerable.Empty<Product>().ToList();
    }
}