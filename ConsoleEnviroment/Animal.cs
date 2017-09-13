
using System;

namespace ConsoleEnviroment
{
    public class Animal
    {



        private string name;
        private double height;
        private int weight;
        private string favFood;
        private double speed;
        private String sound;


        /*
            Instead of using an interface in a traditional way
         *  we use an instance variable that is a subclass
         *  of the Flys interface.
         *  
         *  Animal doesn't care what flyingType does, it just
         *  knows the behavior is available to its subclass
         *  
         *  This is known as Composition : Instead of inheriting
         *  an ability through inheritance the class is composed
         *  with Objects with the right ability
         *  
         *  Composition allows you to change the capabilities of 
         *  objects at run time!
         */
        public Flys flyingType;
        
        public void setName(string newName)
        {
            name = newName;
        }

        public string getName()
        {
            return name;
        }

        public void setHeight(double newHeight)
        {
            height = newHeight;
        }

        public double getHeight()
        {
            return height;
        }

        public void setWeight(int newWeight)
        {
            if (newWeight > 0)
            {
                weight = newWeight;
            }
            else
            {
                Console.WriteLine("Weight must be bigger than 0");
            }
        }

        public double getWeight()
        {
            return weight;
        }

        public void setFavFood(string newFavFood)
        {
            favFood = newFavFood;

        }

        public string getFavFood()
        {
            return favFood;
        }

        public void setSpeed(double newSpeed)
        {
            speed = newSpeed;

        }

        public double getSpeed()
        {
            return speed;
            
        }

        public void setSound(string newSound)
        {
            sound = newSound;
        }

        public string getSound()
        {
            return sound;
        }

        public string tryToFly()
        {
            return flyingType.fly();
        }

        public void setFlyingAbility(Flys newFlyType)
        {
            flyingType = newFlyType;
        }
    }
}


