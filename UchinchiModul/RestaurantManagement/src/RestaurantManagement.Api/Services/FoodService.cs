using RestaurantManagement.Api.Dtos;
using RestaurantManagement.Api.Entities;
using RestaurantManagement.Api.Interfaces;

namespace RestaurantManagement.Api.Services
{
    public class FoodService : IFoodService
    {
        private readonly List<Food> foods = new();
        public void Create(FoodCreateDto dto)
        {
            var food = new Food
            {
                FoodId = Guid.NewGuid(),
                Name = dto.Name,
                Price = dto.Price,

            };
            foods .Add(food);
           
        }

        public void Delete(Guid id)
        {
            var food = foods.FirstOrDefault(x => x.FoodId == id);
            if (food == null)
                throw new Exception("Food not found");
            foods.Remove(food);
        }

        public List<FoodGetDto> GetAll()
        {
            return foods.Select(x => new FoodGetDto
            {
                FoodId = x.FoodId,
                Name = x.Name,
                Price = x.Price,
            }).ToList();
        }

        public FoodGetDto GetById(Guid id)
        {
            var food =foods.FirstOrDefault(x=>x.FoodId==id);
            if (food == null)
                throw new Exception("Food not found");
            return new FoodGetDto
            {
                FoodId = food.FoodId,
                Name = food.Name,
                Price = food.Price,
            };
        }
    }
}
