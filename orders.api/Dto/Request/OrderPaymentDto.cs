namespace Orders.Api.Dto.Request;

public class OrderPaymentDto
{
    public string? Method { get; set; }
    public DateTime Payment_Date { get; set; }
}