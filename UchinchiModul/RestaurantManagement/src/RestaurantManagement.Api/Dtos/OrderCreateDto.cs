namespace RestaurantManagement.Api.Dtos;

public class OrderCreateDto
{
    public Guid CustomerId { get; set; }
    public Guid StaffId { get; set; }
    public List<Guid> FoodIds { get; set; }
}
