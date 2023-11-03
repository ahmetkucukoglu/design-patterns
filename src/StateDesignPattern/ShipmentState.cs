namespace StateDesignPattern;

public abstract class ShipmentState
{
    public virtual void InTransit(Shipment shipment)
    {
        Console.WriteLine(GetInvalidMessage(nameof(InTransit), shipment.State));
    }

    public virtual void InCustoms(Shipment shipment)
    {
        Console.WriteLine(GetInvalidMessage(nameof(InCustoms), shipment.State));
    }

    public virtual void CustomsCleared(Shipment shipment)
    {
        Console.WriteLine(GetInvalidMessage(nameof(CustomsCleared), shipment.State));
    }

    public virtual void OutForDelivery(Shipment shipment)
    {
        Console.WriteLine(GetInvalidMessage(nameof(OutForDelivery), shipment.State));
    }

    public virtual void Delivered(Shipment shipment)
    {
        Console.WriteLine(GetInvalidMessage(nameof(Delivered), shipment.State));
    }

    public virtual void NotDelivered(Shipment shipment)
    {
        Console.WriteLine(GetInvalidMessage(nameof(NotDelivered), shipment.State));
    }

    protected string GetInvalidMessage(string newState, ShipmentState currentState) =>
        $"{newState} cannot be performed in {currentState.GetType().Name}.";
}