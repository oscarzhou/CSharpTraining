
namespace ConsoleEnviroment
{
    /*
     * This interface handles adding, deleting and updating
     * all observers
     */
    public interface Subject
    {
        void Register(Observer o);

        void Unregister(Observer o);

        void NotifyObserver();
    }
}
