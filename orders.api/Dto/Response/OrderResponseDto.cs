namespace Orders.Api.Dto.Response;

public class OrderResponseDto
{
    public Guid Id { get; set; }
    public string? Status { get; set; }
    public string? CustomerId { get; set; }
    public OrderItemResponseDto[]? Items { get; set; }
    public double SubTotal { get; set; }
    public double Tax { get; set; }
    public double ShippingCharges { get; set; }
    public double Total { get; set; }
    public DateTime Created { get; set; }
    public string? CreatedBy { get; set; }
    public string? LastmodifiedBy { get; set; }
    public DateTime? Lastmodified { get; set; }
    public DateTime? Deleted { get; set; }
    public string? DeletedBy { get; set; }
}