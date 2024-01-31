
public class VehicleService
{
    private List<Vehicle> vehicles = new List<Vehicle>();
    //List<Car> cars = new List<Car>();
    //List<Truck> trucks = new List<Truck>();

    public void AddVehicle(Vehicle vehicle)
    {
        vehicles.Add(vehicle);
    }

    public void ShowVehicles()
    {
        foreach (Vehicle vehicle in vehicles)
        {
            vehicle.DisplayInfo();
        }
    }
}
