namespace StateDesignPattern;

public class CustomsClearedState : ShipmentState
{
    public override void OutForDelivery(Shipment shipment)
    {
        Console.WriteLine("The cargo is out for delivery.");

        shipment.MoveTo(new OutForDeliveryState());
    }
    
    public override string ToString() => nameof(CustomsClearedState);
}