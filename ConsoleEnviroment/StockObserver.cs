
using System;

namespace ConsoleEnviroment
{
    // Represents each Observer that is monitoring changes in the subject
    public class StockObserver:Observer
    {
        private double ibmPrice;
        private double applPrice;
        private double googPrice;

        // Static used as a counter
        private static int observerIDTracker = 0;

        // Used to track the observers
        private int observerID;

        // Will hold reference to the StockGrabber object
        private Subject stockGrabber;

        public StockObserver(Subject stockGrabber)
        {
            /*
             * Store the reference to the stockGrabber object so
             * I can make calls to its methods
             */
            this.stockGrabber = stockGrabber;

            // Assign an observer ID and increment the static counter
            this.observerID = ++observerIDTracker;

            // Message notifies user of new observer
            Console.WriteLine("New Observer " + this.observerID);

            // Add the observer to the Subjects List
            stockGrabber.Register(this);
        }

        public void Update(double ibmPrice, double applPrice, double googPrice)
        {
            this.ibmPrice = ibmPrice;
            this.applPrice = applPrice;
            this.googPrice = googPrice;

            printThePrices();
        }

        public void printThePrices()
        {
            Console.WriteLine(observerID + " IBM: " + ibmPrice +
                              ", AAPL: " + applPrice + ", GOOG: " + googPrice + "\n");
        }
    }
}
