public class Truck : Vehicle
{
    public int LoadCapacity { get; set; }

    public Truck(string plateNumber, string brand, string model, int yearModel, int loadCapacity)
        : base(plateNumber, brand, model, yearModel)
    {
        LoadCapacity = loadCapacity;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Lastekapasitet: {LoadCapacity}");
    }

    public static Truck CreateTruck()
    {
        Console.WriteLine("Skiltnummer: ");
        var plateNumber = Console.ReadLine();
        Console.WriteLine("Merke: ");
        var brand = Console.ReadLine();
        Console.WriteLine("Modell: ");
        var model = Console.ReadLine();
        Console.WriteLine("Årsmodell: ");
        var yearModel = int.Parse(Console.ReadLine());
        Console.WriteLine("Lastekapasitet: ");
        var loadCapacity = int.Parse(Console.ReadLine());

        return new Truck(plateNumber, brand, model, yearModel, loadCapacity);
    }
}