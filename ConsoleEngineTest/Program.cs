using System;
using System.Text;
using ConsoleEngine;

namespace ConsoleEngineTest
{
    class Program
    {
        static void Main(string[] args)
        {
            new Game().Start();
        }
    }

    class Game : ConsoleEngine.ConsoleEngine
    {

        protected override void Loop(decimal elapsedTime)
        {

        }

        protected override void Setup()
        {
            
        }
    }
}
