namespace RestaurantManagement.Api.Dtos;


public class CustomerGetDto
{
    public Guid Id { get; set; }
    public string FullName { get; set; }
    public string PhoneNumber { get; set; }
}
