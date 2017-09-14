
using System;
using System.Collections.Generic;

namespace ConsoleEnviroment
{
    // Uses the Subject interface to update all Observers
    public class StockGrabber: Subject
    {
        private List<Observer> observers;

        private double ibmPrice;
        private double aaplPrice;
        private double googPrice;

        public StockGrabber()
        {
            // Creates an List to hold all observers
            observers = new List<Observer>();
        }
        public void Register(Observer newObserver)
        {
            observers.Add(newObserver);
        }

        public void Unregister(Observer deleteObserver)
        {
            // Get the index of the observer to delete
            int observerIndex = observers.IndexOf(deleteObserver);

            // Print out message (Have to increment index to match)
            Console.WriteLine("Observer " + (observerIndex + 1) + " deleted");

            // Removes observer from the List
            observers.RemoveAt(observerIndex);
        }

        public void NotifyObserver()
        {
            // cycle through all observers and notifies them of price changes

            foreach (Observer observer in observers)
            {
                observer.Update(ibmPrice, aaplPrice, googPrice);
            }
        }

        public void setIBMPrice(double newIBMPrice)
        {
            this.ibmPrice = newIBMPrice;
            NotifyObserver();
        }

        public void setAPPLPrice(double newAPPLPrice)
        {
            this.aaplPrice = newAPPLPrice;
            NotifyObserver();
        }

        public void setGOOGPrice(double newGOOGPrice)
        {
            this.googPrice = newGOOGPrice;
            NotifyObserver();
        }
    }
}
