using System.Xml;
using System.Xml.Serialization;

namespace AdapterDesignPattern;

public class XmlProductsExporter : IProductsExporter
{
    public string Export(List<Product> products)
    {
        var xmlSerializer = new XmlSerializer(products.GetType());

        using var stringWriter = new StringWriter();
        using var xmlWriter = new XmlTextWriter(stringWriter) { Formatting = Formatting.Indented };
        xmlSerializer.Serialize(xmlWriter, products);

        return stringWriter.ToString();
    }
}