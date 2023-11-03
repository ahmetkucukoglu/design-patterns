namespace StateDesignPattern;

public class OutForDeliveryState : ShipmentState
{
    public override void Delivered(Shipment shipment)
    {
        Console.WriteLine("The cargo has been delivered.");

        shipment.MoveTo(new DeliveredState());
    }

    public override void NotDelivered(Shipment shipment)
    {
        if (shipment.DeliveryAttempts < 1)
        {
            shipment.DeliveryAttempts++;
            Console.WriteLine("The cargo could not be delivered. We will attempt delivery again.");
            return;
        }

        Console.WriteLine("The cargo could not be delivered. The return process has been initiated.");

        shipment.MoveTo(new NotDeliveredState());
    }
    
    public override string ToString() => nameof(OutForDeliveryState);
}