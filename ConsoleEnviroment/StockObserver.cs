
using System;

namespace ConsoleEnviroment
{
    public class StockObserver:Observer
    {
        private double ibmPrice;
        private double applPrice;
        private double googPrice;

        private static int observerIDTracker = 0;

        private int observerID;

        private Subject stockGrabber;

        public StockObserver(Subject stockGrabber)
        {
            this.stockGrabber = stockGrabber;

            this.observerID = ++observerIDTracker;

            Console.WriteLine("New Observer " + this.observerID);

            stockGrabber.register(this);
        }

        public void update(double ibmPrice, double aaplPrice, double googPrice)
        {
            this.ibmPrice = ibmPrice;
            this.applPrice = applPrice;
            this.googPrice = googPrice;

            printThePrices();
        }

        public void printThePrices()
        {
            Console.WriteLine(observerID + "\nIBM: " + ibmPrice +
                              "\nAAPL: " + applPrice + "\nGOOG: " + googPrice + "\n");
        }
    }
}
