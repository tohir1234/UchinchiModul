using RestaurantManagement.Api.Dtos;
using RestaurantManagement.Api.Entities;
using RestaurantManagement.Api.Interfaces;

namespace RestaurantManagement.Api
{
    public class CustomerService : ICustomerService
    {
        private readonly List<Customer> customers = new();
        public void Create(CustomerCreateDto dto)
        {
            var customer = new Customer
            {
                CustomerId = Guid.NewGuid(),
                FullName = dto.FullName,
                PhoneNumber = dto.PhoneNumber,
            };
            customers.Add(customer);
        }

        public List<CustomerGetDto> GetAll()
        {
            return customers.Select(x => new CustomerGetDto
            {
                Id = x.CustomerId,
                FullName = x.FullName,
                PhoneNumber = x.PhoneNumber,

            }).ToList();
        }
    }
}
