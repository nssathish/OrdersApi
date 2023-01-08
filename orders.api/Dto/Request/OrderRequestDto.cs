using System.ComponentModel.DataAnnotations;

namespace Orders.Api.Dto.Request;

public class OrderRequestDto
{
    [Required]
    public Guid CustomerId { get; set; } = Guid.NewGuid();

    [Required]
    public string? Status { get; set; }

    [Required]
    public OrderItem[]? Items { get; set; }

    [Required]
    public double SubTotal { get; set; }

    [Required]
    public double Tax { get; set; }

    [Required]
    public double Total { get; set; }

    [Required]
    public OrderShipment? shipment { get; set; }
}

public class OrderItem
{
    [Required]
    public string? Name { get; set; }

    [Required]
    public int Quantity { get; set; }
}

public class OrderShipment
{
    [Required]
    public double Charges { get; set; }

    [Required]
    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    [Required]
    public string? City { get; set; }

    [Required]
    public string? State { get; set; }

    [Required]
    public string? Zip { get; set; }
}