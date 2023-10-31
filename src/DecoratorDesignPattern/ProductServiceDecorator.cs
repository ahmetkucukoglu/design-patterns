namespace DecoratorDesignPattern;

public abstract class ProductServiceDecorator : IProductService
{
    protected IProductService ProductService { get; }

    protected ProductServiceDecorator(IProductService productService)
    {
        ProductService = productService;
    }

    public abstract List<Product> GetProducts();
}