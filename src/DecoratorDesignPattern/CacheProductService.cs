namespace DecoratorDesignPattern;

public class CacheProductService : ProductServiceDecorator
{
    public CacheProductService(IProductService productService) : base(productService)
    {
    }

    public override List<Product> GetProducts()
    {
        Console.WriteLine("Products cached");

        return ProductService.GetProducts();
    }
}