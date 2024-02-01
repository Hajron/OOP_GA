public class Car : Vehicle
{
    public int Seats { get; set; }

    public Car(string plateNumber, string brand, string model, int yearModel, int seats)
        : base(plateNumber, brand, model, yearModel)
    {
        Seats = seats;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Antall seter: {Seats}");
    }

    public static Car CreateCar()
    {
        Console.WriteLine("Skiltnummer: ");
        var plateNumber = Console.ReadLine();
        Console.WriteLine("Merke: ");
        var brand = Console.ReadLine();
        Console.WriteLine("Modell: ");
        var model = Console.ReadLine();
        Console.WriteLine("Årsmodell: ");
        var yearModel = int.Parse(Console.ReadLine());
        Console.WriteLine("Antall seter: ");
        int seats = int.Parse(Console.ReadLine());

        return new Car(plateNumber, brand, model, yearModel, seats);
    }
}