namespace Orders.Api.Entities;

public class OrderPayment
{
    public Guid Id { get; set; }
    public Guid OrderItemId { get; set; }
    public string? Method { get; set; }
    public DateTime Payment_Date { get; set; }
    public string? Confirmation_Number { get; set; }
}