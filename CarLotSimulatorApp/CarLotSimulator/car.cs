using System;

namespace CarLotSimulator;

public class Car
{
    //new default constructor
    public Car()
    {
        CarLot.numberOfCars++;
    }

    //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
    //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
    //The methods should take one string parameter: the respective noise property

    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string EngineNoise { get; set; }
    public string HonkNoise { get; set; }
    public bool IsDriveable { get; set; }

    public void MakeEngineNoise(string engineNoise)
    {
        EngineNoise = engineNoise;
        Console.WriteLine($"{Year} {Make} {Model} has an engine noise that sounds like {EngineNoise}.");
    } 

    public void MakeHonkNoise(string honkNoise)
    {
        HonkNoise = honkNoise;
        Console.WriteLine($"{Year} {Make} {Model} has a horn noise that sounds like {HonkNoise}.");
    }

}
