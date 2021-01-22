using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Input;

namespace ConsoleEngine
{
    class Program
    {
        static void Main(string[] args)
        {

            new Game().Start();
        }
    }
    public class Game : Engine
    {
        public override void Loop(decimal elapsedTime)
        {
        }

        public override void Setup()
        {
        }
    }
}