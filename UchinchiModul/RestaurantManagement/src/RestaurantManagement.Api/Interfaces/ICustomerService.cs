using RestaurantManagement.Api.Dtos;

namespace RestaurantManagement.Api.Interfaces
{
    public interface ICustomerService
    {
        List<CustomerGetDto> GetAll();
        void Create(CustomerCreateDto dto);

    }
}
