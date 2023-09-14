using FoodApp.Models;

namespace FoodApp.Services.Foods;

public class FoodService : IFoodService
{
  private static readonly Dictionary<Guid, Food> _foods = new();
  public void CreateFood(Food food)
  {
    _foods.Add(food.Id, food);
  }

  public void DeleteFood(Guid id)
  {
    _foods.Remove(id);
  }

    public Food GetFood(Guid id)
  {
    return _foods[id];
  }

  public void UpsertFood(Food food)
  {
    _foods[food.Id] = food;
  }
}
