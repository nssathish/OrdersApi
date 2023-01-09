using System.ComponentModel.DataAnnotations;

namespace Orders.Api.Dto.Request;

public class OrderRequestDto
{
    [Required]
    public Guid CustomerId { get; set; } = Guid.NewGuid();

    [Required]
    public string? Status { get; set; }

    [Required]
    public OrderItemDto[]? Items { get; set; }

    [Required]
    public double SubTotal { get; set; }

    [Required]
    public double Tax { get; set; }

    [Required]
    public double Total { get; set; }

    [Required]
    public OrderShipmentDto? Shipment { get; set; }

    [Required]
    public OrderBillingDto? Billing { get; set; }

    [Required]
    public OrderPaymentDto? Payment { get; set; }
}