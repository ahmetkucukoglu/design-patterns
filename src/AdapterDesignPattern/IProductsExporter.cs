namespace AdapterDesignPattern;

public interface IProductsExporter
{
    string Export(List<Product> products);
}