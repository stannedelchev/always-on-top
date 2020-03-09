using CommonWin32.API;
using CommonWin32.Windows;
using System;

namespace WindowsFormsApp1
{
    internal static class WindowTopMostSetter
    {
        public static void SetTopMost(IntPtr? hWnd)
        {
            if (hWnd == null)
            {
                return;
            }

            SetTopMost(hWnd.Value, true);
        }

        public static void SetNonTopMost(IntPtr? hWnd)
        {
            if (hWnd == null)
            {
                return;
            }

            SetTopMost(hWnd.Value, false);
        }

        private static void SetTopMost(IntPtr hWnd, bool newValue)
        {
            CommonWin32.API.User32.SetWindowPos(hWnd, newValue ? HWndValues.HWND_TOPMOST : HWndValues.HWND_NOTOPMOST,
                                                0, 0, 0, 0,
                                                SetWindowPosOptions.SWP_NOMOVE | SetWindowPosOptions.SWP_NOSIZE |
                                                SetWindowPosOptions.SWP_NOACTIVATE);
        }
    }
}