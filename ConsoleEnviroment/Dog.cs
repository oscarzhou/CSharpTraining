using System;

namespace ConsoleEnviroment
{
    public class Dog: Animal
    {
        public void digHole()
        {
            Console.WriteLine("Dug a hole");
        }

        public Dog():base()
        {
            
            setSound("Bark");

            /*
             * We set the Flys interface polymorphically
             * This sets the behavior as a non-flying Animal
             
             */

            flyingType = new CantFly();
            

        }
    }
}
