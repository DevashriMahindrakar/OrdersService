using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/orders")]
public class OrdersController : ControllerBase
{
    [HttpGet]
    [Authorize]
    public IActionResult GetOrders() => Ok(new[] { "Order1", "Order2" });

    [HttpPost]
    [Authorize(Roles = "User")]
    public IActionResult CreateOrder([FromBody] string order) => Ok($"Order {order} created");
}