using AdapterDesignPattern;

var exporters = new Dictionary<ExportTypes, IProductsExporter>
{
    { ExportTypes.Json, new JsonProductsExporter() },
    { ExportTypes.Xml, new XmlProductsExporter() },
    { ExportTypes.Csv, new CsvProductsExporterAdapter(new CsvHelper(';')) }
};

Console.WriteLine("Please select one:");

Console.WriteLine(
    exporters
        .Select((e, i) => $"{i + 1}. {e.Key}")
        .Aggregate((x, y) => x + Environment.NewLine + y));

var key = Console.ReadLine()!;

var hasKey = exporters.TryGetValue(Enum.Parse<ExportTypes>(key), out var productExporter);

if (!hasKey) return;

var products = new List<Product>
{
    new()
    {
        Title = "MacBook Pro 14 inch",
        Description = "It's now even more capable, thanks to the new M3 chip."
    },
    new()
    {
        Title = "MacBook Pro 16 inch",
        Description = "It's now even more capable, thanks to the new M3 chip."
    }
};

var data = productExporter.Export(products);

Console.WriteLine(data);