
namespace ConsoleEnviroment
{
    public class Bird:Animal
    {
        public Bird() : base()
        {
            setSound("Tweet");

            flyingType = new ItFlys();
        }
    }
}
