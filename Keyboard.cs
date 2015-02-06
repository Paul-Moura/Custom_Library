using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Custom
{
    public static class Keyboard
    {
        [DllImport("user32.dll")]
        private static extern short GetKeyState(int keyCode);

        public static bool IsKeyActive(Keys keyCode)
        {
            return Convert.ToBoolean(GetKeyState((int)keyCode));
        }

        [DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

        public static void PressKeyboardButton(Keys keyCode)
        {
            const int KEYEVENTF_EXTENDEDKEY = 0x1;
            const int KEYEVENTF_KEYUP = 0x2;

            keybd_event((byte)keyCode, 0x45, KEYEVENTF_EXTENDEDKEY, 0);
            keybd_event((byte)keyCode, 0x45, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0);
        }
    }
}
