using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> Cats = new MyDictionary<int, string>();
            Cats.Add(3, "Persian");
            Cats.Add(5, "British Short Hair");
            Cats.Add(1, "Scottish Fold");
            Cats.Add(2, "Lion");
            Cats.Add(4, "Tiger");

           
        }
    }
}
