using System;

namespace SimpleCSharp
{
    class Program
    {
        string color = "red";
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var i = 0;
            for(i=0; i<=10;i++)
            {
                Console.WriteLine("Emon Is Here");

            }

            Program myobject = new Program();
            for(i=0; i<=10; i++)
            {
                Console.WriteLine(myobject.color);

            }



        }
    }

}
