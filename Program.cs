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

            Console.WriteLine("What is your Name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Your Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Information is: " + userName + "My age is: " + age);


            Console.WriteLine("Calculator");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            Console.WriteLine("Addition Is: " + c);
            int d = a - b;
            Console.WriteLine("Subtraction Is: " + d);
            int e = a * b;
            Console.WriteLine("Multiplication Is: " + e);
            int f = a / b;
            Console.WriteLine("Division Is: " + f);
            int g = a % b;
            Console.WriteLine("Modulus Is: " + g);
            int h = a++;
            Console.WriteLine("Incriment Is: " + h);
            int j = --b;
            Console.WriteLine("Decrement Is: " + j);
            int k = ++a;
            Console.WriteLine("Incriment Is: " + k);




        }
    }

}
