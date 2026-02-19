namespace RestaurantManagement.Api.Entities;


public class Customer
{
    public Guid CustomerId { get; set; }
    public string FullName { get; set; }
    public string PhoneNumber { get; set; }

}
