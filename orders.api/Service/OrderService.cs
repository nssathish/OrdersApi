using Orders.Api.Dto.Response;

namespace Orders.Api.Service;

public interface IOrderService
{
    Task<OrderResponseDto> GetOrderByIdAsync(long id, CancellationToken cancellationToken);
}
public class OrderService : IOrderService
{
    public async Task<OrderResponseDto> GetOrderByIdAsync(long id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}