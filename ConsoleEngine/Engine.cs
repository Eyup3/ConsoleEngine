using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEngine
{
    public abstract class Engine
    {
        public bool run = true;

        public abstract void Loop(decimal elapsedTime);
        public abstract void Setup();

        private long startTime = 0;
        private long endTime = 0;
        private decimal elapsedTime = 0;


        public void Start()
        {
            
            Setup();
            while (run)
            {
                startTime = DateTime.Now.Ticks;
                Loop((decimal)elapsedTime);
                endTime = DateTime.Now.Ticks;
                elapsedTime = ((endTime - startTime) / 10000m) / 1000m;
            }
        }

        public void DrawPoint(decimal x, decimal y, char c)
        { 
            if (!(x < Console.BufferWidth) && !(y < Console.BufferHeight)) return;
            Console.SetCursorPosition((int)Math.Round(x, 0), (int)Math.Round(y, 0));
            Console.Write(c);
        }




    }
}
