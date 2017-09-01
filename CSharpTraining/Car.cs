
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

        public void printVariables()
        {
            Console.WriteLine(maxSpeed);
            Console.WriteLine(minSpeed);
            Console.WriteLine(weight);
            Console.WriteLine(isTheCarOn);
            Console.WriteLine(condition);
           
        }
    }
}
