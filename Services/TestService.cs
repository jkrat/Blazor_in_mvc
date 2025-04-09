using Blazor_in_mvc.Models;

namespace Blazor_in_mvc.Services;

public interface ITestService
{
    VehicleViewModel GetData(int Id);
}


public class TestService : ITestService
{
    private readonly ILogger<TestService> _logger;

    public TestService(ILogger<TestService> logger)
    {
        _logger = logger;
    }

    public VehicleViewModel GetData(int id)
    {
        _logger.LogInformation("Get data for vehicle {Id}", id);

        var model = CreateRandom(id);

        return model;
    }

    private static VehicleViewModel CreateRandom(int id)
    {
        string[] names = { "Ford", "Kia", "Honda" };

        var random = new Random();
        int randomIndex = random.Next(0, 3); // Generates a random number between 0 and 2

        var statuses = Enum.GetValues<VehicleStatus>();
        var randomStatus = statuses[random.Next(statuses.Length)]; // Randomly pick a VehicleStatus value

        var model = new VehicleViewModel
        {
            Id = id,
            Name = names[randomIndex],
            Status = randomStatus,
            Mileage = (randomIndex + 1) * 20000 - id * 77,
        };

        return model;
    }
}
