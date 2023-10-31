namespace DecoratorDesignPattern;

public class LogProductService : ProductServiceDecorator
{
    public LogProductService(IProductService productService) : base(productService)
    {
    }

    public override List<Product> GetProducts()
    {
        Console.WriteLine("Request logged");

        return ProductService.GetProducts();
    }
}