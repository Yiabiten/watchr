using System;
using System.Runtime.InteropServices;

namespace Night0wl.HookApi
{
    internal sealed class Hook : IDisposable
    {
        #region DllImports

        [DllImport("user32.dll")]
        static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc callback, IntPtr hInstance, uint threadId);

        [DllImport("user32.dll")]
        static extern bool UnhookWindowsHookEx(IntPtr hInstance);

        [DllImport("user32.dll")]
        static extern IntPtr CallNextHookEx(IntPtr idHook, int nCode, int wParam, IntPtr lParam);

        [DllImport("kernel32.dll")]
        static extern IntPtr LoadLibrary(string lpFileName);

        #endregion

        #region Consts and privates

        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x100;

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        private readonly IntPtr hookProcedureHandle;
        private static Action<VkCode> onKeyPressed;

        #endregion

        #region singleton Hook

        private static Hook instance;

        public static Hook GetInstance(Action<VkCode> onKeyPressedAction)
        {
            if (instance == null)
            {
                instance = new Hook();
                onKeyPressed = onKeyPressedAction;
                return instance;
            }
            throw new ApplicationException("Hook already running..");
        }

        private Hook()
        {
            var hInstance = LoadLibrary("User32");
            hookProcedureHandle = SetWindowsHookEx(WH_KEYBOARD_LL, HandleKeystroke, hInstance, 0);
        }

        #endregion

        private IntPtr HandleKeystroke(int code, IntPtr wParam, IntPtr lParam)
        {
            if (code >= 0 && wParam == (IntPtr) WM_KEYDOWN)
            {
                var vkCode = Marshal.ReadInt32(lParam);
                var key = (VkCode) vkCode;
                onKeyPressed(key);
            }
            return CallNextHookEx(hookProcedureHandle, code, (int) wParam, lParam);
        }

        public void Dispose()
        {
            UnhookWindowsHookEx(hookProcedureHandle);
        }
    }
}