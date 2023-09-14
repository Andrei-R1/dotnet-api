using FoodApp.Contracts.Food;
using FoodApp.Models;
using FoodApp.Services.Foods;
using Microsoft.AspNetCore.Mvc;

namespace FoodApp.Controllers;

[ApiController]
[Route("[controller]")]

public class FoodsController : ControllerBase
{
  private readonly IFoodService _foodService;
    public FoodsController(IFoodService foodService)
    {
        _foodService = foodService;
    }

    [HttpPost]
  public IActionResult CreateFood(CreateFoodRequest request)
  {
    var food = new Food(
      Guid.NewGuid(),
      request.Name,
      request.Description,
      request.StartDateTime,
      request.EndDateTime,
      DateTime.UtcNow,
      request.Savory,
      request.Sweet
    );
    _foodService.CreateFood(food);
    var response = new FoodResponse(
      food.Id,
      food.Name,
      food.Description,
      food.StartDateTime,
      food.EndDateTime,
      food.LastModifiedDateTime,
      food.Savory,
      food.Sweet
    );
    return CreatedAtAction(
      actionName: nameof(GetFood),
      routeValues: new { id = food.Id },
      value: response
    );
  }

  [HttpGet("{id:guid}")]
  public IActionResult GetFood(Guid id)
  {
    Food food = _foodService.GetFood(id);
    var response = new FoodResponse(
      food.Id,
      food.Name,
      food.Description,
      food.StartDateTime,
      food.EndDateTime,
      food.LastModifiedDateTime,
      food.Savory,
      food.Sweet
    );
    return Ok(response);
  }

  [HttpPut("{id:guid}")]
  public IActionResult UpsertFood(Guid id, UpsertFoodRequest request)
  {
    var food = new Food(
      id,
      request.Name,
      request.Description,
      request.StartDateTime,
      request.EndDateTime,
      DateTime.UtcNow,
      request.Savory,
      request.Sweet
    );
    _foodService.UpsertFood(food);
    return NoContent();
  }

  [HttpDelete("{id:guid}")]
  public IActionResult DeleteFood(Guid id)
  {
    _foodService.DeleteFood(id);
    return NoContent();
  }
}