using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SimpleCSharp
{
    class Program
    {
        string color = "red";
        static void Main(string[] args)
        {

            //string[] dayWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            //Console.Write("\nLINQ : Display the name of the days of a week : ");
            //Console.Write("\n------------------------------------------------\n");


            //var days = from WeekDay in dayWeek
            //           select WeekDay;
            //foreach (var WeekDay in days)
            //{
            //    Console.WriteLine(WeekDay);
            //}
            //Console.WriteLine();
            //Console.WriteLine("Hello World!");
            //var i = 0;
            //for(i=0; i<=10;i++)
            //{
            //    Console.WriteLine("Emon Is Here");

            //}

            //Program myobject = new Program();
            //for(i=0; i<=10; i++)
            //{
            //    Console.WriteLine(myobject.color);

            //}

            //Console.WriteLine("What is your Name: ");
            //string userName = Console.ReadLine();
            //Console.WriteLine("Your Age: ");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Your Information is: " + userName + "My age is: " + age);


            //Console.WriteLine("Calculator");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = a + b;
            //Console.WriteLine("Addition Is: " + c);
            //int d = a - b;
            //Console.WriteLine("Subtraction Is: " + d);
            //int e = a * b;
            //Console.WriteLine("Multiplication Is: " + e);
            //int f = a / b;
            //Console.WriteLine("Division Is: " + f);
            //int g = a % b;
            //Console.WriteLine("Modulus Is: " + g);
            //int h = a++;
            //Console.WriteLine("Incriment Is: " + h);
            //int j = --b;
            //Console.WriteLine("Decrement Is: " + j);
            //int k = ++a;
            //Console.WriteLine("Incriment Is: " + k);

            //Console.WriteLine("Calculator");
            //Console.WriteLine("Minimum value " + Math.Min(a, b));
            //Console.WriteLine("Absulate vale " + Math.Abs(-105));
            //Console.WriteLine("Square value " + Math.Sqrt(a));
            //Console.WriteLine("Round value " + Math.Round(15.32));


            //int numberoflayer = 6, Space, Number;
            //Console.WriteLine("Print paramid");
            //for (int i = 1; i <= numberoflayer; i++) // Total number of layer for pramid  
            //{
            //    for (Space = 1; Space <= (numberoflayer - i); Space++) // Loop For Space  
            //        Console.Write(" ");
            //    for (Number = 1; Number <= i; Number++) //increase the value  
            //        Console.Write('*');
            //    for (Number = (i - 1); Number >= 1; Number--) //decrease the value  
            //        Console.Write('*');
            //    Console.WriteLine();
            //}


            Console.WriteLine("Pyramid in C#");

            int layer = Convert.ToInt32(Console.ReadLine()), space, star;
            for (int intial = 0; intial <= layer; intial++) //user for layer
            {
                for (space = 1; space <= (layer - intial); space++) // user for space

                    Console.Write(" ");

                for (star = 1; star <= intial; star++)

                    Console.Write("*");

                for (star = (intial - 1); star >= 1; star--)

                    Console.Write("*");



                Console.WriteLine();
            }



            Console.WriteLine(layer);








        }
    }



}
