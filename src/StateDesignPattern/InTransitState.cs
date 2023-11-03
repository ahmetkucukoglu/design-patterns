namespace StateDesignPattern;

public class InTransitState : ShipmentState
{
    public override void InCustoms(Shipment shipment)
    {
        Console.WriteLine("The cargo has arrived at customs.");

        shipment.MoveTo(new InCustomsState());
    }
    
    public override string ToString() => nameof(InTransitState);
}