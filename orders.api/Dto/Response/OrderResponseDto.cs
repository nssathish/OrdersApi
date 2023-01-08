namespace Orders.Api.Dto.Response;

public class OrderResponseDto
{
    public long Id { get; set; }
    public string? Status { get; set; }
    public string? CustomerId { get; set; }
    public OrderItem[]? Items { get; set; }
    public double SubTotal { get; set; }
    public double Tax { get; set; }
    public double ShippingCharges { get; set; }
    public double Total { get; set; }
}

public class OrderItem
{

}