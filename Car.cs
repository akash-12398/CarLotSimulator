﻿using System;
namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
        }

        public Car(int year, string make, string model, string enginenoise, string honknoise, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = enginenoise;
            HonkNoise = honknoise;
            IsDriveable = isDriveable;
         }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine(engineNoise);
        }

        public void honkNoise(string honknoise)
        {
            Console.WriteLine(EngineNoise);

        }






    }
}
