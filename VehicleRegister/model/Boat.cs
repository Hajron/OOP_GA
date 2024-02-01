
public class Boat : Vehicle
{
    public string RegNumber { get; set; }
    public string Length { get; set; }
    public string Width { get; set; }
    public string Horsepower { get; set; }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Registrerings nummer: {RegNumber}");
        Console.WriteLine($"Lengde: {Length}");
        Console.WriteLine($"Bredde: {Width}");
        Console.WriteLine($"Hestekrefter: {Horsepower}");
    }

    public static Boat CreateBoat()
    {
        Console.WriteLine("Registrerings nummer: ");
        var regNumber = Console.ReadLine();
        Console.WriteLine("Merke: ");
        var brand = Console.ReadLine();
        Console.WriteLine("Modell: ");
        var model = Console.ReadLine();
        Console.WriteLine("Årsmodell: ");
        var yearModel = int.Parse(Console.ReadLine());
        Console.WriteLine("Lengde: ");
        var length = Console.ReadLine();
        Console.WriteLine("Bredde: ");
        var width = Console.ReadLine();
        Console.WriteLine("Hestekrefter: ");
        var horsePower = Console.ReadLine();

        return new Boat
        {
            RegNumber = regNumber,
            Brand = brand,
            Model = model,
            YearModel = yearModel,
            Length = length,
            Width = width,
            Horsepower = horsePower,
        };

    }
}
