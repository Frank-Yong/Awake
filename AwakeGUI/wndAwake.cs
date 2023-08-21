using Awake;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwakeGUI
{
    public partial class wndAwake : Form
    {
        public wndAwake()
        {
            InitializeComponent();
        }

        private void mnuNotifyIcon_Opening(object sender, CancelEventArgs e)
        {
            bool awake = NativeMethods.GetAwakeState();
            this.awakeToolStripMenuItem.Enabled = !awake;
            this.sleepToolStripMenuItem.Enabled = awake;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void awakeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NativeMethods.ForceSystemAwake();
            SetNotifyIcon();

        }

        private void sleepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NativeMethods.ResetSystemDefault();
            SetNotifyIcon();
        }

        private void wndAwake_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            SetNotifyIcon();
        }

        private void SetNotifyIcon()
        {
            bool awake = NativeMethods.GetAwakeState();
            this.niCoffee.Text = awake ? "Awake" : "Sleep";
            this.niCoffee.Icon = awake 
                ? Properties.Resources.Iconsmind_Outline_Coffee 
                : Properties.Resources.Pictogrammers_Material_Light_Sleep;
        }

        private void niCoffee_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                bool awake = NativeMethods.GetAwakeState();
                if (awake)
                    NativeMethods.ResetSystemDefault();
                else
                    NativeMethods.ForceSystemAwake();

                SetNotifyIcon();
            }
        }
    }
}
