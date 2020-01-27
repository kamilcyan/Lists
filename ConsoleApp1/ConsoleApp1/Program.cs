using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var cities = new List<string>();
            //cities.Add("London");
            //cities.Add("Warsaw");
            //cities.Add("Paris");

            //Console.WriteLine("Initial List");
            //foreach(string city in cities)
            //{
            //    Console.WriteLine($"  {city}");
            //}

            //Console.WriteLine($"The first city is {cities[0]}");
            //Console.WriteLine($"The last city is {cities[cities.Count-1]}");

            //cities.Insert(0, "Sydney");
            //Console.WriteLine("After adding sydney at position 0: ");
            //foreach (string city in cities)
            //{
            //    Console.WriteLine($"  {city}");
            //}

            //cities.RemoveAt(1);
            //cities.Remove("Paris");
            //Console.WriteLine("After removing: ");
            //foreach (string city in cities)
            //{
            //    Console.WriteLine($"  {city}");
            //}

            Program program = new Program();

            List<int> liczby = new List<int>();

            for (int i=0; i<2000; i++)
            {
                if ((i % 2) == 0)
                {
                    liczby.Add(i);
                }
            }

            foreach (int liczba in liczby)
            {
                Console.WriteLine($"  {liczba}");
            }

            
            

            Console.WriteLine(program.Suma(liczby));
            Console.ReadKey();
        }

        public int Suma(List<int> liczbies)
        {
            int suma = 0;
            foreach (int liczba in liczbies)
            {
                if ((liczba % 10) == 0)
                    suma += liczba;
            }
            return suma;
        }
    }
}
