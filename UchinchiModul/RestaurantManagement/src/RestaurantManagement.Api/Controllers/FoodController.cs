using Microsoft.AspNetCore.Mvc;
using RestaurantManagement.Api.Dtos;
using RestaurantManagement.Api.Interfaces;

namespace RestaurantManagement.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FoodController : ControllerBase
    {
        private readonly IFoodService _service;

    public FoodController(IFoodService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_service.GetAll());
    }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            return Ok(_service.GetById(id));
        }

        [HttpPost]
        public IActionResult Create(FoodCreateDto dto)
        {
            _service.Create(dto);
            return Ok("Created");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _service.Delete(id);
            return Ok("Deleted");
        }

    }
}
