using Orders.Api.Dto.Request;
using Orders.Api.Dto.Response;
using Orders.Api.Repositories;

namespace Orders.Api.Service;

public interface IOrderService
{
    Task<OrderResponseDto> GetOrderByIdAsync(long id, CancellationToken cancellationToken);
    Task<OrderResponseDto> CreateOrderAsync(OrderRequestDto orderRequest, CancellationToken cancellationToken);
}
public class OrderService : IOrderService
{
    private readonly IOrderRepository _orderRepository;
    public OrderService(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public async Task<OrderResponseDto> CreateOrderAsync(OrderRequestDto orderRequest, CancellationToken cancellationToken)
    {
        return await _orderRepository.CreateOrderAsync(orderRequest, cancellationToken);
    }

    public async Task<OrderResponseDto> GetOrderByIdAsync(long id, CancellationToken cancellationToken)
    {
        return await _orderRepository.GetOrderByIdAsync(id, cancellationToken);
    }
}