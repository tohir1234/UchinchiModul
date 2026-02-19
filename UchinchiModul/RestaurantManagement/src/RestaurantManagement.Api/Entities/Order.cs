namespace RestaurantManagement.Api.Entities;


public class Order
{
    public Guid Id { get; set; }
    public Customer Customer { get; set; }  // Kim buyurtma berdi
    public Staff Staff { get; set; }        // Kim qabul qildi
    public List<Food> Foods { get; set; }   // Nimalar buyurtma qilingan
    public decimal TotalPrice { get; set; }  //Jami summa
}
    
