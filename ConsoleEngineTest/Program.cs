using System;
using System.Text;
using System.Threading;
using ConsoleEngine;

namespace ConsoleEngineTest
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ConsoleHelper.SetCurrentFont("Consolas", 8);
            Console.SetWindowSize(300, 100);

            new Game().Start();
        }
    }

    class Game : ConsoleEngine.ConsoleEngine
    {
        struct Circle
        {
            public int x, y, r;
            public Circle(int X, int Y, int R)
            {
                x = X;
                y = Y;
                r = R;
            }
        }
        Circle Two = new Circle(5, 5, 5);
        int xVel = 10;

        protected override void Loop(decimal elapsedTime)
        {
            Console.Clear();

            Circle One = new Circle(5, 5, 5);
            DrawCircle(One);
            DrawCircle(Two);

            Two.x += (int)(xVel * elapsedTime);

            int SumOfRadius = One.r + Two.r;

            int xDist = One.x - Two.x;
            int yDist = One.y - Two.y;

            string Text = $"{(xDist * xDist + yDist * yDist)} // {xDist} // {yDist}";

            if (SumOfRadius > (xDist * xDist + yDist * yDist))
            {
                Text += "// COLLISSION";
            }
            Console.Title = Text;


        }
        protected override void Setup()
        {

        }

        void DrawCircle(Circle c)
        {
            double PI = 3.1415926535;
            double i, angle, x1, y1;

            for (i = 0; i < 360; i += 0.1)
            {
                angle = i;
                x1 = c.r * Math.Cos(angle * PI / 180);
                y1 = c.r * Math.Sin(angle * PI / 180);
                DrawPoint((int)(c.x + x1), (int)(c.y + y1), "#");
            }

        }
    }

}
