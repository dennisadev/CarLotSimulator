using System;
using System.Collections.Generic;

namespace CarLotSimulator;

public class CarLot
{
    
    public List<Car> ParkingLot { get; set;} = new List<Car>();

    public void CheckCars()
    {
        foreach (var spot in ParkingLot)
        {
            Console.WriteLine($"{spot.Year} {spot.Make} {spot.Model}");
        }
    }

    public static int numberOfCars;
}
