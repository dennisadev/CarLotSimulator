using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var carLotOne = new CarLot();
            
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var carOne = new Car();
            carOne.Year = 2025;
            carOne.Make = "Ford";
            carOne.Model = "F-150";
            carOne.EngineNoise = "Vroom";
            carOne.HonkNoise = "Beep Beep";
            carOne.IsDriveable = true;

            carOne.MakeEngineNoise("Vroom");
            carOne.MakeHonkNoise("Beep Beep");
            carLotOne.ParkingLot.Add(carOne);

            var carTwo = new Car();
            carTwo.Year = 2025;
            carTwo.Make = "GMC";
            carTwo.Model = "Sierra";
            carTwo.EngineNoise = "rumble";
            carTwo.HonkNoise = "Beep Beep";
            carTwo.IsDriveable = true;

            carTwo.MakeEngineNoise("rumble");
            carTwo.MakeHonkNoise("Beep Beep");
            carLotOne.ParkingLot.Add(carTwo);

            var carThree = new Car();
            carThree.Year = 2025;
            carThree.Make = "Dodge";
            carThree.Model = "Ram";
            carThree.EngineNoise = "chug";
            carThree.HonkNoise = "Beep Beep";
            carThree.IsDriveable = true;

            carThree.MakeEngineNoise("chug");
            carThree.MakeHonkNoise("Beep Beep");
            carLotOne.ParkingLot.Add(carThree);

            Console.WriteLine("Car Lot:");
            carLotOne.CheckCars();

            Console.WriteLine($"Total Number of Cars:{CarLot.numberOfCars}");

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
