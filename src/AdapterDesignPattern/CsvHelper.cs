using System.Text;

namespace AdapterDesignPattern;

public class CsvHelper
{
    private char Delimiter { get; set; }

    public CsvHelper(char delimiter)
    {
        Delimiter = delimiter;
    }

    public string GenerateCsv(List<object> rows)
    {
        if (rows == null) return string.Empty;

        var objectType = rows.FirstOrDefault()!.GetType();
        var headers = objectType.GetProperties().Select(x => x.Name).ToList();

        var stringBuilder = new StringBuilder();
        stringBuilder.AppendLine(string.Join(Delimiter, headers));

        foreach (var row in rows)
        {
            var values = objectType.GetProperties().Select(prop => prop.GetValue(row)).ToList();
            stringBuilder.AppendLine(string.Join(Delimiter, values));
        }

        return stringBuilder.ToString();
    }
}