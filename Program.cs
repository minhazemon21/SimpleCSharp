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

            Console.WriteLine("Take input from user");
            string userName = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Information is: " + userName + "My age is: " + age);



        }
    }

}
