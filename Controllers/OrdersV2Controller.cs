using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[ApiVersion("2.0")]
[Route("api/v{version:apiVersion}/orders")]
public class OrdersV2Controller : ControllerBase
{
    [HttpGet]
    [Authorize]
    public IActionResult GetOrders() => Ok(new[] { "Order1", "Order2" });

    [HttpPost]
    [Authorize(Roles = "User")]
    public IActionResult CreateOrder([FromBody] string order) => Ok($"Order {order} created");
}