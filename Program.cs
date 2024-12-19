/* DESIGN A PARKING SYSTEM:
 
    * Data structure for parking sizes
    * 3 spaces (carType): big, medium, small (1, 2, 3) with fixed number of slots for each size
    * Car can only park in a parking space of its carType
    * If no space available, return false, else park in that size space and return true.
    * ParkingSystem class
    * bool addCar(int carType) method:
        * checks whether parking space of carType is available
 
 */

using System;
using System.Collections.Generic;

public class ParkingSystem
{
    public static void Main(string[] args)
    {
        //initialization/calling parkingsystem method with set spaces
        ParkingSystem parkingSystem = new ParkingSystem(2, 2, 2);

        //test cases
        Console.WriteLine(parkingSystem.AddCar(1)); // true
        Console.WriteLine(parkingSystem.AddCar(2)); // true
        Console.WriteLine(parkingSystem.AddCar(3)); // true
        Console.WriteLine(parkingSystem.AddCar(1)); // true
        Console.WriteLine(parkingSystem.AddCar(1)); // false
        Console.WriteLine(parkingSystem.AddCar(2)); // true
        Console.WriteLine(parkingSystem.AddCar(2)); // false
        Console.WriteLine(parkingSystem.AddCar(3)); // true
        Console.WriteLine(parkingSystem.AddCar(3)); // false
    }

    //Create dictionary
    private Dictionary<int, int> parkingSlots;

    //Constructor
    public ParkingSystem(int big, int medium, int small)
    {
        //Initialize dictionary
        parkingSlots = new Dictionary<int, int>
        {
            { 1, big },
            { 2, medium },
            { 3, small }
        };
    }

    //AddCar method using a switch statement
    public bool AddCar(int carType)
    {
        //while loop
        while (parkingSlots[carType] > 0)
        {
            //decrement spaces if true
            parkingSlots[carType]--;
            return true;
        }
        return false;//if no slots are available or if it's the wrong carType
    }
}
