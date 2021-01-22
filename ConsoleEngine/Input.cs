using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleEngine
{
    public static class Input
    {
        [DllImport("User32.dll")]
        private static extern int GetAsyncKeyState(Int32 i);

        public static bool GetKeyState(ConsoleKey key)
        {
            if (GetAsyncKeyState((int)key) != 0)
            {
                return true;
            } else { return false; }
        }

    }
}
