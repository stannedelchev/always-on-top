using System;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public static class EnumeratedWindowsFormListBoxFiller
    {
        public static void Fill(ListBox listBox)
        {
            listBox.Items.Clear();

            User32.EnumDesktopWindows(IntPtr.Zero, (hWnd, lParam) =>
            {
                var stringBuilder = new StringBuilder(255);
                User32.GetWindowText(hWnd, stringBuilder, 255);

                var title = stringBuilder.ToString();
                if (string.IsNullOrEmpty(title))
                {
                    return true;
                }

                listBox.Items.Add(new WindowInfo()
                {
                    HWnd = hWnd,
                    Title = title
                });

                return true;
            }, IntPtr.Zero);
        }
    }
}