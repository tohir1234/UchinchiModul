namespace RestaurantManagement.Api.Entities;


public class Food
{
    public Guid FoodId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}
