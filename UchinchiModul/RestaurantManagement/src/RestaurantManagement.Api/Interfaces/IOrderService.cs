using RestaurantManagement.Api.Dtos;

namespace RestaurantManagement.Api.Interfaces
{
    public interface IOrderService
    {
        void Create(OrderCreateDto dto);
        List<OrderGetDto> GetAll();
        OrderGetDto GetById(Guid id);
        void Delete(Guid id);
    }
}
