
namespace ConsoleEnviroment
{
    /*
     * The Observers update method is called when the Subject changes
     */
    public interface Observer
    {
        new void Update(double ibmPrice, double aaplPrice, double googPrice);
    }
} 
