namespace Orders.Api.Entities;

public class Order
{
    public Guid? CustomerId { get; set; }
    public string? Status { get; set; }
    public OrderItem[]? Items { get; set; }
    public double SubTotal { get; set; }
    public double Tax { get; set; }
    public double Total { get; set; }
    public OrderShipment? shipment { get; set; }
}