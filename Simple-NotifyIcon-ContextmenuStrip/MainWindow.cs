using System;
using System.Windows.Forms;

namespace Simple_NotifyIcon_ContextmenuStrip
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void MainWindow_Move(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.notifyIcon.ShowBalloonTip(100, "Notify Message", "Please click for see more details.", ToolTipIcon.Info);
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
