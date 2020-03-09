using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            this.InitializeComponent();
        }

        private void OnMainFormLoaded(object sender, EventArgs e)
        {
            EnumeratedWindowsFormListBoxFiller.Fill(this.ListBoxWindows);
        }

        private void OnButtonRefreshClicked(object sender, EventArgs e)
        {
            EnumeratedWindowsFormListBoxFiller.Fill(this.ListBoxWindows);
        }

        private void OnButtonTopMostClicked(object sender, EventArgs e)
        {
            var selected = (WindowInfo)this.ListBoxWindows.SelectedItem;
            WindowTopMostSetter.SetTopMost(selected?.HWnd);
        }

        private void OnButtonNonTopmostClick(object sender, EventArgs e)
        {
            var selected = (WindowInfo)this.ListBoxWindows.SelectedItem;
            WindowTopMostSetter.SetNonTopMost(selected?.HWnd);
        }
    }
}
