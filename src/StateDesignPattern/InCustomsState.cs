namespace StateDesignPattern;

public class InCustomsState : ShipmentState
{
    public override void CustomsCleared(Shipment shipment)
    {
        Console.WriteLine("Customs clearance procedures have been completed.");
    
        shipment.MoveTo(new CustomsClearedState());
    }
    
    public override string ToString() => nameof(InCustomsState);
}