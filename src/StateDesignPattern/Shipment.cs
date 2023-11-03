namespace StateDesignPattern;

public class Shipment
{
    public Guid OrderId { get; private set; }
    public string FromCountry { get; private set; }
    public string To { get; private set; }
    public ShipmentState State { get; private set; }
    public int DeliveryAttempts { get; internal set; }

    public Shipment(Guid orderId, string fromCountry, string to)
    {
        OrderId = orderId;
        FromCountry = fromCountry;
        To = to;
        State = new OrderPlacedState();
    }

    public void MoveTo(ShipmentState state)
    {
        State = state;
    }

    public void ToInTransit()
    {
        State.InTransit(this);
    }

    public void ToInCustoms()
    {
        State.InCustoms(this);
    }

    public void ToCustomsCleared()
    {
        State.CustomsCleared(this);
    }

    public void ToOutForDelivery()
    {
        State.OutForDelivery(this);
    }

    public void ToDelivered()
    {
        State.Delivered(this);
    }

    public void ToNotDelivered()
    {
        State.NotDelivered(this);
    }
}