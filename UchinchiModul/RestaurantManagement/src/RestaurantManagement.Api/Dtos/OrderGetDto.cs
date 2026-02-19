namespace RestaurantManagement.Api.Dtos;

public class OrderGetDto
{
    public Guid Id { get; set; }
    public string CustomerName { get; set; }
    public string StaffName { get; set; }
    public List<string> FoodNames { get; set; }
    public decimal TotalPrice { get; set; }
}
