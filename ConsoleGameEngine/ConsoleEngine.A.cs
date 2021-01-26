using System;

namespace ConsoleEngine
{
    public abstract partial class ConsoleEngine
    {

        /// <summary>
        /// Change to false to quit
        /// </summary>
        protected bool run = true;

        protected abstract void Setup();
        protected abstract void Loop(decimal elapsedTime);

        //Setup to get elapsedTime
        protected long startTime = 0;
        protected long endTime = 0;
        protected decimal elapsedTime = 0;


        public void Start()
        {

            Setup();
            while (run)
            {
                startTime = DateTime.Now.Ticks;

                Loop(elapsedTime);

                GetFps();

                endTime = DateTime.Now.Ticks;
                elapsedTime = ((endTime - startTime) / 10000m) / 1000m;
            }
        }

        #region FPS
        protected int FPS; // the FPS calculated from the last measurement

        private DateTime _lastTime; // marks the beginning the measurement began
        private int _framesRendered; // an increasing count
        private void GetFps()
        {
            _framesRendered++;

            if ((DateTime.Now - _lastTime).TotalSeconds >= 1)
            {
                // one second has elapsed 

                FPS = _framesRendered;
                _framesRendered = 0;
                _lastTime = DateTime.Now;
            }

        }
    }
    #endregion

    public abstract partial class ConsoleEngine
    {
        protected void DrawPoint(int x, int y, string input)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(input);
        }
        protected void DrawBox(int x, int y, int sizeX, int sizeY, char input)
        {
            for (int i = 0; i < sizeX; i++)
            {
                for (int ii = 0; ii < sizeY; ii++)
                {
                    DrawPoint(i + x, ii + y, input.ToString());
                }
            }
        }
    }

}
