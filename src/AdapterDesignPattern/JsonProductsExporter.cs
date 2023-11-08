using System.Text.Json;

namespace AdapterDesignPattern;

public class JsonProductsExporter : IProductsExporter
{
    public string Export(List<Product> products)
    {
        return JsonSerializer.Serialize(products);
    }
}