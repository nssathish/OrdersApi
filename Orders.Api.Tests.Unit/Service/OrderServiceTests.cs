using Moq;
using Xunit;
using FluentAssertions;
using Orders.Api.Repositories;
using Orders.Api.Dto.Request;
using Orders.Api.Dto.Response;
using Orders.Api.Service;

namespace Orders.Api.Tests.Unit.Service;

public class OrderServiceTests
{
    private readonly Mock<IOrderRepository> _orderRepositoryMock;
    private readonly IOrderService _orderService;

    public OrderServiceTests()
    {
        _orderRepositoryMock = new Mock<IOrderRepository>();
        _orderService = new OrderService(_orderRepositoryMock.Object);
    }
    [Fact]
    public async Task OrderService_CreateOrder_Valid_Request()
    {
        // Given
        var customerId = new Guid();
        OrderRequestDto request = new()
        {
            CustomerId = customerId,
            Status = "Active",
            Items = new OrderItemDto[] {
                new OrderItemDto() {
                    Name = "Test item 1",
                    Quantity = 1
                },
                new OrderItemDto() {
                    Name = "Test item 2",
                    Quantity = 1
                },
            },
            SubTotal = 10.5,
            Tax = 5.6,
            Total = 16.1,
            Shipment = new OrderShipmentDto()
            {
                Charges = 2.1,
                AddressLine1 = "No.0, Test street",
                AddressLine2 = "Test Avenue",
                City = "TestCity",
                State = "TestState",
                Zip = "0123"
            },
            Billing = new OrderBillingDto()
            {
                Charges = 2.1,
                AddressLine1 = "No.0, Test billing street",
                AddressLine2 = "Test billing Avenue",
                City = "TestBillingCity",
                State = "TestBillingState",
                Zip = "01234"
            },
            Payment = new OrderPaymentDto()
            {
                Method = "CreditCard",
                Payment_Date = DateTime.Now
            }
        };
        var orderId = Guid.NewGuid();
        OrderResponseDto orderResponse = new()
        {
            Created = DateTime.Now,
            CreatedBy = "TestUser",
            CustomerId = customerId.ToString(),
            Deleted = null,
            DeletedBy = null,
            Id = Guid.NewGuid(),
            Items = new OrderItemResponseDto[] {
                new OrderItemResponseDto() {
                    Id = Guid.NewGuid(),
                    Created = DateTime.Now,
                    CreatedBy = "TestUser",
                    Deleted = null,
                    DeletedBy = null,
                    Lastmodified = null,
                    LastmodifiedBy = null,
                    Name = "Test Item 1",
                    OrderId = orderId,
                    Quantity = 1,
                },
                new OrderItemResponseDto() {
                    Id = Guid.NewGuid(),
                    Created = DateTime.Now,
                    CreatedBy = "TestUser",
                    Deleted = null,
                    DeletedBy = null,
                    Lastmodified = null,
                    LastmodifiedBy = null,
                    Name = "Test Item 2",
                    OrderId = orderId,
                    Quantity = 1,
                }
            },
            ShippingCharges = 2.1,
            Lastmodified = null,
            LastmodifiedBy = null,
            Status = "Active",
            SubTotal = 10.5,
            Tax = 5.6,
            Total = 16.1
        };
        // When
        _orderRepositoryMock.Setup(x => x.CreateOrderAsync(request, CancellationToken.None))
                            .ReturnsAsync(orderResponse);
        // Then
        var response = await _orderService.CreateOrderAsync(request, CancellationToken.None);

        response.CustomerId.Should().Be(customerId.ToString());
    }
}