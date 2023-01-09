namespace Orders.Api.Dto.Response;

public class OrderItemResponseDto
{
    public Guid Id { get; set; }
    public Guid OrderId { get; set; }
    public string? Name { get; set; }
    public int Quantity { get; set; }
    public DateTime Created { get; set; }
    public string? CreatedBy { get; set; }
    public string? LastmodifiedBy { get; set; }
    public DateTime? Lastmodified { get; set; }
    public DateTime? Deleted { get; set; }
    public string? DeletedBy { get; set; }
}