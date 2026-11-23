using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Name: {Name ?? "null"}, Age: {Age}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;

            Console.WriteLine($"Исходные значения: x = {x}, y = {y}");
            SwapWithoutRef(x, y);
            Console.WriteLine($"После SwapWithoutRef: x = {x}, y = {y}");
            SwapWithRef(ref x, ref y);
            Console.WriteLine($"После SwapWithRef: x = {x}, y = {y}");

            Console.WriteLine();

            Person person1 = new Person { Name = "Алексей", Age = 30 };
            Person person2 = new Person { Name = "Мария", Age = 25 };

            Console.WriteLine("Исходные данные:");
            Console.WriteLine(person1);
            Console.WriteLine(person2);

            Console.WriteLine();
            Console.WriteLine("Попытка сброса БЕЗ ref");
            ResetPersonWithoutRef(person1);
            Console.WriteLine($"person1 is null: {person1 == null}");
            Console.WriteLine(person1);

            Console.WriteLine();
            Console.WriteLine("Попытка сброса С ref");
            ResetPersonWithRef(ref person2);
            Console.WriteLine($"person2 is null: {person2 == null}");
            if (person2 != null) Console.WriteLine(person2);

            Console.WriteLine();
            Console.WriteLine("Изменение состояния объекта (без ref)");
            person2 = new Person { Name = "Мария", Age = 25 };
            person2.Age = 30;
            Console.WriteLine(person2);

            Console.ReadLine();
        }

        static void SwapWithoutRef(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void SwapWithRef(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void ResetPersonWithoutRef(Person person)
        {
            person = null;
        }

        static void ResetPersonWithRef(ref Person person)
        {
            person = null;
        }
    }
}