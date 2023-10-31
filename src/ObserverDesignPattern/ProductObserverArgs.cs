namespace ObserverDesignPattern;

public record ProductObserverArgs
{
    public int Id { get; set; }
    public int? PreviousStock { get; init; }
    public int? NewStock { get; init; }
    public decimal? PreviousPrice { get; init; }
    public decimal? NewPrice { get; init; }
}