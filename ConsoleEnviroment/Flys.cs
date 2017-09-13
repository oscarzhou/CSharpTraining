
namespace ConsoleEnviroment
{
    public interface Flys
    {
        string fly();
    }

    public class ItFlys : Flys
    {
        public string fly()
        {
            return "Flying high";
        }
    }

    public class CantFly : Flys
    {
        public string fly()
        {
            return "I can't fly";
        }
    }
}
