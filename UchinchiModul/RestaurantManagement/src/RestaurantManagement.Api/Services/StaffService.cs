using RestaurantManagement.Api.Dtos;
using RestaurantManagement.Api.Entities;
using RestaurantManagement.Api.Interfaces;

namespace RestaurantManagement.Api.Services;

public class StaffService : IStaffService
{
    private readonly List<Staff> staffs = new();
    public void Create(StaffCreateDto dto)
    {
        var staff = new Staff
        {
            StaffId = Guid.NewGuid(),
            FullName = dto.FullName,
            Position = dto.Position
        };
        staffs.Add(staff);
    }

    public List<StaffGetDto> GetAll()
    {
       return staffs.Select(x=>new StaffGetDto
       {
           Id=x.StaffId,
           FullName=x.FullName,
           Position = x.Position
       }).ToList();
    }
}
