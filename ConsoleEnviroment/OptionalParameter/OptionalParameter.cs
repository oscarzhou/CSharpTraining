using System;

namespace ConsoleEnviroment.OptionalParameter
{
    class OptionalParameter
    {
        public void QueryStudent(string stuName, string className = "Computer A", int age = 20)
        {
            Console.WriteLine("Your query condition is student name={0}, class name={1}, age={2}", stuName, className, age);
        }
    }
}
