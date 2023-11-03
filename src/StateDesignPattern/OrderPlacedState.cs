namespace StateDesignPattern;

public class OrderPlacedState : ShipmentState
{
    public override void InTransit(Shipment shipment)
    {
        if (shipment.FromCountry == "TR")
        {
            Console.WriteLine(GetInvalidMessage(nameof(InTransit), shipment.State));
            return;
        }

        Console.WriteLine("The cargo has been loaded onto the ship.");

        shipment.MoveTo(new InTransitState());
    }

    public override void OutForDelivery(Shipment shipment)
    {
        if (shipment.FromCountry != "TR")
        {
            Console.WriteLine(GetInvalidMessage(nameof(OutForDelivery), shipment.State));
            return;
        }

        Console.WriteLine("The cargo is out for delivery.");

        shipment.MoveTo(new OutForDeliveryState());
    }

    public override string ToString() => nameof(OrderPlacedState);
}