﻿
var vehicleService = new VehicleService();

while (true)
{
    Console.WriteLine("1. Legg til bil!");
    Console.WriteLine("2. Legg til lastebil!");
    Console.WriteLine("3. Legg til Motorsykkel!");
    Console.WriteLine("4. Vis alle kjøretøy!");
    Console.WriteLine("5. Avslutt!");

    var choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            vehicleService.AddVehicle(Car.CreateCar());
            break;
        case "2":
            vehicleService.AddVehicle(Truck.CreateTruck());
            break;
        case "3":
            vehicleService.AddVehicle(Motorcycle.CreateMotorcycle());
            break;
        case "4":
            vehicleService.ShowVehicles();
            break;
        case "5":
            return;
        default:
            Console.WriteLine("Ugyldig valg, prøv igjen!");
            break;
    }
}



