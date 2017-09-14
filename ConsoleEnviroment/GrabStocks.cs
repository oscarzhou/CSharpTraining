
using System;

namespace ConsoleEnviroment
{
    public class GrabStocks
    {
        public static void Main2(string[] args)
        {
            StockGrabber stockGrabber = new StockGrabber();

            StockObserver observer1 = new StockObserver(stockGrabber);

            stockGrabber.setIBMPrice(197.00);
            stockGrabber.setAPPLPrice(677.60);
            stockGrabber.setGOOGPrice(676.40);
            
            
            StockObserver observer2 = new StockObserver(stockGrabber);

            stockGrabber.setIBMPrice(197.00);
            stockGrabber.setAPPLPrice(677.60);
            stockGrabber.setGOOGPrice(676.40);

            stockGrabber.Unregister(observer1);

            stockGrabber.setIBMPrice(197.00);
            stockGrabber.setAPPLPrice(677.60);
            stockGrabber.setGOOGPrice(676.40);


            Console.ReadKey();

        }
    }
}
