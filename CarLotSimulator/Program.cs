using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property            


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var lot = new CarLot();

            //var list = new List<Car>();
           


            var camry = new Car();

            camry.Make = "Toyota";
            camry.Model = "Camry";
            camry.EngineNoise = "vroom";
            camry.Year = 2015;
            camry.HonkNoise = "beep";
            camry.IsDriveable = true;

            lot.Cars.Add(camry);



            var rinkucar = new Car()
            {
                Make = "Tesla",
                Model = "Cyber Truck",
                EngineNoise = "Ding",
                Year = 2019,
                HonkNoise = "song",
                IsDriveable = false
            };


            lot.Cars.Add(rinkucar);


            var akashCar = new Car (2013, "Nissan","Rogue","vroom","varuga", false);



            lot.Cars.Add(akashCar);



            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make:{car.Make} Model:{car.Model}");

            }
            


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
