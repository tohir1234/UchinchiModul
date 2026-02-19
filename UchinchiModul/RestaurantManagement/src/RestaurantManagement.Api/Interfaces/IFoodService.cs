using RestaurantManagement.Api.Dtos;

namespace RestaurantManagement.Api.Interfaces
{
    public interface IFoodService
    {
        List<FoodGetDto> GetAll();
        FoodGetDto GetById(Guid id);
        void Create(FoodCreateDto dto);
        void Delete(Guid id);

    }
}
