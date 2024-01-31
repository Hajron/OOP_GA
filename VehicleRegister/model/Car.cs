
using System.Collections;

public class Car : Vehicle
{
   public int Seats { get; set; }

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

      return new Car
      {
         PlateNumber = plateNumber,
         Brand = brand,
         Model = model,
         YearModel = yearModel,
         Seats = seats
      };
   }
}