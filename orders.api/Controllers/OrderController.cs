using Microsoft.AspNetCore.Mvc;
using Orders.Api.Dto.Request;
using Orders.Api.Dto.Response;
using Orders.Api.Service;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;

namespace Orders.Api.Controllers;

[ApiController]
[Route("api/v1/orders")]
public class OrdersController : ControllerBase
{
    private readonly ILogger<OrdersController> _logger;
    private readonly IOrderService _orderService;

    public OrdersController(IOrderService orderService, ILogger<OrdersController> logger)
    {
        _logger = logger;
        _orderService = orderService;
    }

    [HttpGet]
    [Route("{id}")]
    [SwaggerOperation("Get order by id", "Get the order for the user by id")]
    public async Task<ActionResult<OrderResponseDto>> Get([Required] long id, CancellationToken cancellationToken)
    {
        return Ok(await _orderService.GetOrderByIdAsync(id, cancellationToken));
    }

    [HttpPost]
    [SwaggerOperation("Create an order", "Create an order for the user transaction")]
    public async Task<ActionResult<OrderResponseDto>> CreateOrderAsync([FromBody][Required] OrderRequestDto orderRequest, CancellationToken cancellationToken)
    {
        return Ok(await _orderService.CreateOrderAsync(orderRequest, cancellationToken));
    }
}