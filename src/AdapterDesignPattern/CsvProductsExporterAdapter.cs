namespace AdapterDesignPattern;

public class CsvProductsExporterAdapter : IProductsExporter
{
    private CsvHelper CsvHelper { get; set; }

    public CsvProductsExporterAdapter(CsvHelper csvHelper)
    {
        CsvHelper = csvHelper;
    }

    public string Export(List<Product> data)
    {
        return CsvHelper.GenerateCsv(data.Cast<object>().ToList());
    }
}