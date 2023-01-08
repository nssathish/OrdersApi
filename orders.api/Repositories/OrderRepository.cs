using Orders.Api.Dto.Request;
using Orders.Api.Dto.Response;

namespace Orders.Api.Repositories;

public interface IOrderRepository
{
    Task<OrderResponseDto> GetOrderByIdAsync(long id, CancellationToken cancellationToken);
    Task<OrderResponseDto> CreateOrderAsync(OrderRequestDto orderRequest, CancellationToken cancellationToken);
}

public class OrderRepository : IOrderRepository
{
    public async Task<OrderResponseDto> CreateOrderAsync(OrderRequestDto orderRequest, CancellationToken cancellationToken)
    {
        return await Task.Run(() => new OrderResponseDto());
    }

    public async Task<OrderResponseDto> GetOrderByIdAsync(long id, CancellationToken cancellationToken)
    {
        return await Task.Run(() => new OrderResponseDto());
    }
}