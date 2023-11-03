using StateDesignPattern;

var shipmentTr = new Shipment(Guid.NewGuid(), "TR", "Istanbul");
shipmentTr.ToInTransit();
shipmentTr.ToInCustoms();
shipmentTr.ToCustomsCleared();
shipmentTr.ToOutForDelivery();
shipmentTr.ToNotDelivered();
shipmentTr.ToDelivered();
		
Console.WriteLine("-----------------------------------------------------------------");
		
var shipmentRu = new Shipment(Guid.NewGuid(), "RU", "Istanbul");
shipmentRu.ToInTransit();
shipmentRu.ToInCustoms();
shipmentRu.ToCustomsCleared();
shipmentRu.ToOutForDelivery();
shipmentRu.ToNotDelivered();
shipmentRu.ToDelivered();