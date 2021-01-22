using System;
using System.Runtime.InteropServices;

namespace ConsoleEngine
{
    public static class Input
    {
        [DllImport("User32.dll")]
        private static extern int GetAsyncKeyState(Int32 i);

        /// <summary>
        /// Get state of ConsoleKey
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static bool GetKeyState(ConsoleKey key)
        {
            if (GetAsyncKeyState((int)key) != 0)
            {
                return true;
            }
            else { return false; }
        }

    }
}
