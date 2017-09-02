using System;

namespace ConsoleEnviroment
{
    public abstract class Book
    {
        protected String title;
        protected String author;

        public Book(String t, String a)
        {
            title = t;
            author = a;
        }

        public abstract void display();
    }
}
