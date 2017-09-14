
using System;
using System.Collections.Generic;

namespace ConsoleEnviroment
{
    public class StockGrabber: Subject
    {
        private List<Observer> observers;

        private double ibmPrice;
        private double aaplPrice;
        private double googPrice;

        public StockGrabber()
        {
            observers = new List<Observer>();
        }
        public void register(Observer newObserver)
        {
            observers.Add(newObserver);
        }

        public void unregister(Observer deleteObserver)
        {
            int observerIndex = observers.IndexOf(deleteObserver);

            Console.WriteLine("Observer " + (observerIndex + 1) + " deleted");

            observers.RemoveAt(observerIndex);
        }

        public void notifyObserver()
        {
            foreach (Observer observer in observers)
            {
                observer.update(ibmPrice, aaplPrice, googPrice);
            }
        }

        public void setIBMPrice(double newIBMPrice)
        {
            this.ibmPrice = newIBMPrice;
            notifyObserver();
        }

        public void setAPPLPrice(double newAPPLPrice)
        {
            this.aaplPrice = newAPPLPrice;
            notifyObserver();
        }

        public void setGOOGPrice(double newGOOGPrice)
        {
            this.googPrice = newGOOGPrice;
            notifyObserver();
        }
    }
}
