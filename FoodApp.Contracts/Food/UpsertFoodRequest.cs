namespace FoodApp.Contracts.Food
{
  public record UpsertFoodRequest(
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    List<string> Savory,
    List<string> Sweet
  );
}