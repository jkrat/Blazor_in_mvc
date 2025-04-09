namespace Blazor_in_mvc.Models;

public class VehicleViewModel
{
    public VehicleViewModel()
    { }

    public int Id { get; set; }
    public string? Name { get; set; }
    public VehicleStatus Status { get; set; }
    public int Mileage { get; set; }
}

public enum VehicleStatus
{
    Pending,
    Shop,
    Available,
    Sold,
}
