public class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Sidevogn: {(HasSidecar ? "Ja" : "Nei")}");
    }
    
    public static Motorcycle CreateMotorcycle()
    {
        Console.WriteLine("Skiltnummer: ");
        var plateNumber = Console.ReadLine();
        Console.WriteLine("Merke: ");
        var brand = Console.ReadLine();
        Console.WriteLine("Modell: ");
        var model = Console.ReadLine();
        Console.WriteLine("Årsmodell: ");
        var yearModel = int.Parse(Console.ReadLine());
        Console.WriteLine("Sidevogn? (Ja/nei): ");
        bool sideCar = Console.ReadLine().ToLower() == "ja";

        return new Motorcycle()
        {
            PlateNumber = plateNumber,
            Brand = brand,
            Model = model,
            YearModel = yearModel,
            HasSidecar = sideCar
        };
    }
}