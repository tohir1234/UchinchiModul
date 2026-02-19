namespace RestaurantManagement.Api.Dtos;

public class FoodGetDto
{
    public Guid FoodId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}
