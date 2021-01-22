using System;

namespace ConsoleEngine
{
    public abstract class ConsoleEngine
    {

        /// <summary>
        /// Change to false to quit
        /// </summary>
        public bool run = true;

        public abstract void Loop(decimal elapsedTime);
        public abstract void Setup();

        //Setup to get elapsedTime
        private long startTime = 0;
        private long endTime = 0;
        private decimal elapsedTime = 0;


        public void Start()
        {

            Setup();
            while (run)
            {
                startTime = DateTime.Now.Ticks;

                Loop(elapsedTime);

                endTime = DateTime.Now.Ticks;
                elapsedTime = ((endTime - startTime) / 10000m) / 1000m;
            }
        }
    }
}
