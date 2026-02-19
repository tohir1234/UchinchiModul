using RestaurantManagement.Api.Dtos;
using RestaurantManagement.Api.Entities;
using RestaurantManagement.Api.Interfaces;

namespace RestaurantManagement.Api.Services
{
    public class OrderService : IOrderService
    {
        
            private readonly List<Order> orders = new List<Order>();
            private readonly List<Customer> customers;
            private readonly List<Staff> staffs;
            private readonly List<Food> foods;

            public OrderService(
                List<Customer> customers,
                List<Staff> staffs,
                List<Food> foods)
            {
                customers = customers;
                staffs = staffs;
                foods = foods;
            }

            // ➕ CREATE
            public void Create(OrderCreateDto dto)
            {
                Customer customer = null;
                foreach (var c in customers)
                {
                    if (c.CustomerId == dto.CustomerId)
                    {
                        customer = c;
                        break;
                    }
                }

                if (customer == null)
                    throw new Exception("Customer topilmadi");

                Staff staff = null;
                foreach (var s in staffs)
                {
                    if (s.StaffId == dto.StaffId)
                    {
                        staff = s;
                        break;
                    }
                }

                if (staff == null)
                    throw new Exception("Staff topilmadi");

                List<Food> selectedFoods = new List<Food>();
                decimal total = 0;

                foreach (var foodId in dto.FoodIds)
                {
                    foreach (var f in foods)
                    {
                        if (f.FoodId == foodId)
                        {
                            selectedFoods.Add(f);
                            total += f.Price;
                            break;
                        }
                    }
                }

                Order order = new Order();
                order.Id = Guid.NewGuid();
                order.Customer = customer;
                order.Staff = staff;
                order.Foods = selectedFoods;
                order.TotalPrice = total;

                orders.Add(order);
            }

            // 📋 GET ALL
            public List<OrderGetDto> GetAll()
            {
                List<OrderGetDto> result = new List<OrderGetDto>();

                foreach (var o in orders)
                {
                    List<string> foodNames = new List<string>();

                    foreach (var f in o.Foods)
                    {
                        foodNames.Add(f.Name);
                    }

                    OrderGetDto dto = new OrderGetDto();
                    dto.Id = o.Id;
                    dto.CustomerName = o.Customer.FullName;
                    dto.StaffName = o.Staff.FullName;
                    dto.FoodNames = foodNames;
                    dto.TotalPrice = o.TotalPrice;

                    result.Add(dto);
                }

                return result;
            }

            // 🔍 GET BY ID
            public OrderGetDto GetById(Guid id)
            {
                foreach (var o in orders)
                {
                    if (o.Id == id)
                    {
                        List<string> foodNames = new List<string>();

                        foreach (var f in o.Foods)
                        {
                            foodNames.Add(f.Name);
                        }

                        OrderGetDto dto = new OrderGetDto();
                        dto.Id = o.Id;
                        dto.CustomerName = o.Customer.FullName;
                        dto.StaffName = o.Staff.FullName;
                        dto.FoodNames = foodNames;
                        dto.TotalPrice = o.TotalPrice;

                        return dto;
                    }
                }

                throw new Exception("Order topilmadi");
            }

            // ❌ DELETE
            public void Delete(Guid id)
            {
                Order toRemove = null;

                foreach (var o in orders)
                {
                    if (o.Id == id)
                    {
                        toRemove = o;
                        break;
                    }
                }

                if (toRemove == null)
                    throw new Exception("Order topilmadi");

                orders.Remove(toRemove);
            }
        



    }
}
