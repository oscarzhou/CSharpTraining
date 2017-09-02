using System;

namespace ConsoleEnviroment
{
    public class MyBook:Book
    {
        public int price;

        public MyBook(String t, String a, int p):base(t, a)
        {
            
            this.price = p;
        }

        public override void display()
        {
            Console.WriteLine("Title:{0}", base.title);
            Console.WriteLine("Author:{0}", base.author);
            Console.WriteLine("Price:{0}", this.price);
        }
    }
}
