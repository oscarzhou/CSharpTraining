
namespace ConsoleEnviroment
{
    public class GrabStocks
    {
        public static void main(string[] args)
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

            stockGrabber.unregister(observer1);

            stockGrabber.setIBMPrice(197.00);
            stockGrabber.setAPPLPrice(677.60);
            stockGrabber.setGOOGPrice(676.40);

        }
    }
}
