using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Basic_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // משתנים
            int n = 5;
            double d = 10.5;
            bool b = true;
            string s = "Hello world";
            char ch = 'c';

            // קלט - פלט

            Console.Write(s);
            Console.WriteLine("Gilad");

            string str = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());


            // אופרנדים
            int n1 = 9, n2 = 4, n3;
            n3 = n1 / n2; // n3 = 2 שלם ללא שארית
            n3 = n1 % n2; // n3 = 1 השארית 

            double d1 = 5, d2 = 2.5, d3;
            d3 = d1 / d2; // d3 = 2.0

            string s1 = "Gilad", s2 = "Markman", s3;
            s3 = s1 + " " + s2; // s3 = "Gilad Markman"
            s3 = "Gilad has " + n2 + "Children"; //s3="Gilad has 4 Children"

            // Random
            Random rnd = new Random();
            int min = -3, max = 13;
            int r1 = rnd.Next(min, max);  // rnadom between -3 to 12
            int r2 = rnd.Next(10);        // random between 0 to 9


            // תנאי
            if (num < 0)
            {
                Console.WriteLine("Negative");
            }
            else if (num == 0)
            {
                Console.WriteLine("Zero");
            }
            else
            {
                Console.WriteLine("Positive");
            }

            // לולאה
            int i = 0;
            while (i < 10) 
            {
                Console.WriteLine(i);
            }

            for (int j=0; j < 10; j++)
            {
                Console.WriteLine(i);
            }

        }

        
    }
}
