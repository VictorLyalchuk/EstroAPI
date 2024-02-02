using Core.DTOs.Information;
using Core.DTOs.Site;
using Core.Entities.Site;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderControllers : Controller
    {
        private readonly IOrderService _order;
        public OrderControllers(IOrderService order)
        {
            _order = order;
        }
        [HttpPost("CreateOrder")]
        public async Task<IActionResult> CreateProduct(OrderCreateDTO orderCreateDTO)
        {
            await _order.CreateAsync(orderCreateDTO);
            return Ok();
        }
    }
}
