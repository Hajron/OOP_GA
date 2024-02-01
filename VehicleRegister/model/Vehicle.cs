
public abstract class Vehicle
{
    public string PlateNumber { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public int YearModel { get; set; }

    protected Vehicle(string plateNumber, string brand, string model, int yearModel)
    {
        PlateNumber = plateNumber;
        Brand = brand;
        Model = model;
        YearModel = yearModel;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("_______________________________________________________");
        Console.WriteLine($"Kjøretøy: {PlateNumber}, {Brand}, {Model}, {YearModel}");
    }
}
