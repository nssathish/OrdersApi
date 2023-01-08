namespace Orders.Api.Entities;

public class OrderBilling
{
    public Guid OrderId { get; set; }
    public Guid OrderItemId { get; set; }
    public double Charges { get; set; }
    public string? AddressLine1 { get; set; }
    public string? AddressLine2 { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Zip { get; set; }
}