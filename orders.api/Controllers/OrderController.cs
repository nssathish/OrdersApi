using Microsoft.AspNetCore.Mvc;
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
        return Ok(await orderService.GetOrderByIdAsync(id, cancellationToken));
    }
}