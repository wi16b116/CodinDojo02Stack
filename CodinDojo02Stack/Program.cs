using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinDojo02Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestWithInts();
            TestWithStrings();
            //TestWithObjects();
            Console.ReadLine();
        }

        static void TestWithInts()
        {
            TheStack<int> test = new TheStack<int>();

            test.Push(5);
            test.Push(100);
            test.Push(3);
            Console.WriteLine(test.Peek());
            Console.WriteLine(test.Pop());
            Console.WriteLine(test.Pop());
            Console.WriteLine(test.Peek());
            
        }

        static void TestWithStrings()
        {
            TheStack<string> test = new TheStack<string>();
            test.Push("red");
            test.Push("blue");
            test.Push("yellow");
            test.Push("orange");
            Console.WriteLine("Last: " + test.Peek());
            Console.WriteLine("Pop: " + test.Pop());
            Console.WriteLine("Peek: " + test.Peek());
            Console.WriteLine("Pop: " + test.Pop());
            Console.WriteLine("Peek: " + test.Peek());
            
        }

        static void TestWithObjects()
        {
            TheStack <AnimalObject> test = new TheStack<AnimalObject>();

            test.Push(new AnimalObject("Donkey", "Brown"));
            test.Push(new AnimalObject("Cat", "Orange"));
            test.Push(new AnimalObject("Rat", "Black and White"));
            Console.WriteLine("Peek: " + test.Peek());
            Console.WriteLine("Pop: " + test.Pop());
            Console.WriteLine("Peek: " + test.Peek());
            Console.WriteLine("Pop: " + test.Pop());
            Console.WriteLine("Peek: " + test.Peek());
            Console.WriteLine("Pop: " + test.Pop());
            Console.WriteLine("Pop: " + test.Pop()); 
            //creates an exception
            //Console.WriteLine("Peek: " + test.Peek());
        }
    }
}
