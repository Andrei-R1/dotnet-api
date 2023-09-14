using FoodApp.Models;

namespace FoodApp.Services.Foods;

public interface IFoodService
{
    void CreateFood(Food food);
    void DeleteFood(Guid id);
    Food GetFood(Guid id);
    void UpsertFood(Food food);
}