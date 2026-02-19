using Microsoft.AspNetCore.Mvc;
using RestaurantManagement.Api.Dtos;
using RestaurantManagement.Api.Interfaces;

namespace RestaurantManagement.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {

        private readonly ICustomerService _service;

        public CustomerController(ICustomerService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAll());
        }



        [HttpPost]
        public IActionResult Create(CustomerCreateDto dto)
        {
            _service.Create(dto);
            return Ok("Customer created");
        }


    }
}
