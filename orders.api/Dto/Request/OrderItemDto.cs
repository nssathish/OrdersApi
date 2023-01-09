using System.ComponentModel.DataAnnotations;

namespace Orders.Api.Dto.Request;

public class OrderItemDto
{
    [Required]
    public string? Name { get; set; }

    [Required]
    public int Quantity { get; set; }
}