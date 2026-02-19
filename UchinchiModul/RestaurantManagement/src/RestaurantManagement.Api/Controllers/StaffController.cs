using Microsoft.AspNetCore.Mvc;
using RestaurantManagement.Api.Dtos;
using RestaurantManagement.Api.Interfaces;

namespace RestaurantManagement.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StaffController : ControllerBase
    {

        private readonly IStaffService _service;

        public StaffController(IStaffService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAll());
        }

        [HttpPost]
        public IActionResult Create(StaffCreateDto dto)
        {
            _service.Create(dto);
            return Ok("Staff created");
        }


    }
}
