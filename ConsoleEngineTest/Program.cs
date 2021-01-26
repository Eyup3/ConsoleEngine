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
        float playerX = 0, playerY = 0;

        protected override void Loop(decimal elapsedTime)
        {
            if (Input.GetKeyState(ConsoleKey.D))
            {
                playerX += 2 * (float)elapsedTime;
            }
            DrawBox((int)playerX, (int)playerY, 10, 10, '#'); 
        }

        protected override void Setup()
        {
            
        }
    }
}
