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
            if (Input.GetKeyState(ConsoleKey.A))
            {
                playerX -= 2 * (float)elapsedTime;
            }
            if (Input.GetKeyState(ConsoleKey.S))
            {
                playerY += 2 * (float)elapsedTime;
            }
            if (Input.GetKeyState(ConsoleKey.D))
            {
                playerX += 2 * (float)elapsedTime;
            }
            if (Input.GetKeyState(ConsoleKey.W))
            {
                playerY -= 2 * (float)elapsedTime;
            }
            DrawPoint((int)playerX, (int)playerY, "#");


            WeirdClear();
        }

        int FrameCount = 0;
        private void WeirdClear()
        {
            if (++FrameCount == 1000)
            {
                Console.Clear();
                FrameCount = 0;
            }
        }

        protected override void Setup()
        {
            
        }
    }
}
