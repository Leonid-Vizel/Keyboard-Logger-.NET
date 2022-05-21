using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Input;

namespace KeyboardLogger
{
    public class KeyboardListener
    {
        //Constants
        private readonly int WH_KEYBOARD_LL;
        private readonly IntPtr WM_KEYDOWN;
        private readonly IntPtr WM_SYSKEYDOWN;

        #region DllImports
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
        #endregion

        //Delegates and Events
        public delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
        public event EventHandler<KeyPressedArgs> OnKeyPressed;
        private LowLevelKeyboardProc _proc;
        //Windows hook
        private IntPtr _hookID;

        public KeyboardListener()
        {
            _hookID = IntPtr.Zero;
            WH_KEYBOARD_LL = 13;
            WM_KEYDOWN = (IntPtr)0x0100;
            WM_SYSKEYDOWN = (IntPtr)0x0104;
            _proc = HookCallback;
        }

        public void HookKeyboard()
            => _hookID = SetHook(_proc);

        public void UnHookKeyboard()
            => UnhookWindowsHookEx(_hookID);

        private IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            {
                using (ProcessModule curModule = curProcess.MainModule)
                {
                    return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
                }
            }
        }

        private IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if ((nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN || wParam == (IntPtr)WM_SYSKEYDOWN) && OnKeyPressed != null)
            {
                OnKeyPressed(this, new KeyPressedArgs(KeyInterop.KeyFromVirtualKey(Marshal.ReadInt32(lParam))));
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }
    }
}
