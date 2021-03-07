using System;
using ConsoleEngine;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class SS : ConsoleEngine.ConsoleEngine
    {
        protected override void Loop(decimal elapsedTime)
        {
            
        }

        protected override void Setup()
        {
        }
    }
}
