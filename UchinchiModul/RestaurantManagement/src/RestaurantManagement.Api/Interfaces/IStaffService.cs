using RestaurantManagement.Api.Dtos;

namespace RestaurantManagement.Api.Interfaces
{
    public interface IStaffService
    {
        List<StaffGetDto> GetAll();
        void Create(StaffCreateDto dto);

    }
}
