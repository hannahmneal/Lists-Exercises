using System;
using System.Collections.Generic;

namespace ch_4_planet_and_spaceships_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){"Mercury", "Mars"};

// 1. Add() Jupiter and Saturn at the end of the list.

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

// 2. Create another List that contains that last two planet of our solar system.

            List<string> smallPlanets = new List<string>(){"Uranus", "Neptune"};

// Combine the two lists by using AddRange().

            planetList.AddRange(smallPlanets);

            // foreach(string planet in planetList) {
            //      Console.WriteLine(planet);
            // }

// Use Insert() to add Earth, and Venus in the correct order.

    planetList.Insert(1, "Venus");
    planetList.Insert(2, "Earth");

    // foreach(string planet in planetList) {
    //     Console.WriteLine(planet);
    // }


// Use Add() again to add Pluto to the end of the list.

planetList.Add("Pluto?");

// foreach(string planet in planetList) {
//     Console.WriteLine(planet);
// }
// Console Result: Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune, Pluto?

// Now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets into a new list called rockyPlanets. The rocky planets will remain in the original planets list.

    // Rocky planets are: Mercury, Venus, Earth, Mars
    // Microsoft Docs example: dinosaurs.GetRange(2, 3).ToArray();

    string[] rockyPlanets = planetList.GetRange(0,4).ToArray();
    // When the range is (0, 3), the planets returned are Mercury, Venus, Earth. Why? The method has no problem grabbing Mercury at 0, why can't it grab Mars at 3?

    // foreach(string planet in rockyPlanets) {
    //     Console.WriteLine(planet);
    // }
    // Console Result: Mercury, Venus, Earth, Mars

// Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the Remove() method to eliminate it from the end of planetList.

    planetList.RemoveAt(8);


    // foreach(string planet in rockyPlanets) {
    //     Console.WriteLine(planet);
    // }
    // Console result: Mercury, Venus, Earth, Mars

    // foreach(string planet in planetList) {
    //     Console.WriteLine(planet);
    // }
    //Console result: Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune

//====================================================================================

//1. Use the following code to create a list of random numbers. Each number will be between 0 and 9.

    Random random = new Random();
    List<int> numbers = new List<int> {
        random.Next(10),
        random.Next(10),
        random.Next(10),
        random.Next(10),
        random.Next(10),
    };

    // 2. Use a for loop to iterate over all numbers between 0 and numbers.Count - 1.

    int first = numbers[0];
    Console.WriteLine($"first: {first}");
    // Console result: first: 6
    // Running again gives: first: 9
    // It's providing random numbers for my index.

    // 3. Inside the body of the for loop determine if the current loop index is contained inside of the numbers list. Print a message to the console indicating whether the index is in the list.

    for(int n=0; n <= numbers.Count-1; n++) {
        Console.WriteLine($"numbers[{n}]: {numbers[n]}");
    }
    //Console result:
        //     first: 6
        // numbers[0]: 6
        // numbers[1]: 5
        // numbers[2]: 8
        // numbers[3]: 9


        }
    }
}
