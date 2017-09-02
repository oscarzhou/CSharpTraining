
namespace ConsoleEnviroment
{
    class Student: Person
    {
        private string firstName;
        public Student(int initialAge, string firstName) : base(initialAge)
        {
            this.firstName = firstName;
        }

        
    }
}
