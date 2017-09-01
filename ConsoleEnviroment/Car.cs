
using System;

namespace CSharpTraining
{
    class Car
    {
        private int maxSpeed = 100;
        private int minSpeed = 0;
        private double weight = 4079;
        private bool isTheCarOn = false;
        private char condition = 'A';
        private String nameOfCar = "Lucy";

        private double maxFuel = 16;
        private double currentFuel = 8;
        private double mpg = 26.4;
        private int numberOfPeopleInCar = 1;

        public Car(int customMaxSpeed, double customWeight, bool customIsTheCarOn)
        {
            maxSpeed = customMaxSpeed;
            weight = customWeight;
            isTheCarOn = customIsTheCarOn;
        }




        public void printVariables()
        {
            Console.WriteLine("This is the maxSpeed " + maxSpeed);
            Console.WriteLine(minSpeed);
            Console.WriteLine(weight);
            Console.WriteLine(isTheCarOn);
            Console.WriteLine(condition);
            Console.WriteLine(nameOfCar);
            Console.WriteLine(numberOfPeopleInCar);
        }

        public void wreckCar()
        {
            condition = 'C';
        }

        public void upgradeMinSpeed()
        {
            minSpeed = maxSpeed;
            maxSpeed = maxSpeed + 1;
        }

        public void getIn()
        {
            numberOfPeopleInCar = numberOfPeopleInCar + 1;
            
        }

        public void getOut()
        {
            numberOfPeopleInCar--;
        }

        public double howManyMilesTillOutOfGas()
        {
            return currentFuel * mpg;
        }

        public double maxMilesPerFillUp()
        {
            return maxFuel * mpg;
        }
    }
}
