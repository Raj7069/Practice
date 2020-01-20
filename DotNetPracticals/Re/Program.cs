using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Re
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name, Country;
            Console.WriteLine("Please, Enter your Name:-");
            Name = Console.ReadLine();
            Console.WriteLine("Please, Enter your Country:-");
            Country= Console.ReadLine();

            Console.WriteLine("Hello, Your Name is "+Name+" and you from Country "+Country);
            Console.Read();
        }
    }
}
