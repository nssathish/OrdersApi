using System.ComponentModel.DataAnnotations;

namespace Orders.Api.Dto.Request;

public class OrderShipmentDto
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
