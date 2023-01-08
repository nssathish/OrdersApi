namespace Orders.Api.Entities;

public class OrderItem
{
    public Guid OrderId { get; set; }
    public Guid OrderItemId { get; set; }
    public string? Name { get; set; }
    public int Quantity { get; set; }
}