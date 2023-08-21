namespace AwakeGUI
{
    partial class wndAwake
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wndAwake));
            this.niCoffee = new System.Windows.Forms.NotifyIcon(this.components);
            this.mnuNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.awakeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sleepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.niImages = new System.Windows.Forms.ImageList(this.components);
            this.mnuNotifyIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // niCoffee
            // 
            this.niCoffee.ContextMenuStrip = this.mnuNotifyIcon;
            this.niCoffee.Icon = ((System.Drawing.Icon)(resources.GetObject("niCoffee.Icon")));
            this.niCoffee.Text = "Awake";
            this.niCoffee.Visible = true;
            this.niCoffee.MouseClick += new System.Windows.Forms.MouseEventHandler(this.niCoffee_MouseClick);
            // 
            // mnuNotifyIcon
            // 
            this.mnuNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.awakeToolStripMenuItem,
            this.sleepToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.mnuNotifyIcon.Name = "mnuNotifyIcon";
            this.mnuNotifyIcon.Size = new System.Drawing.Size(110, 70);
            this.mnuNotifyIcon.Opening += new System.ComponentModel.CancelEventHandler(this.mnuNotifyIcon_Opening);
            // 
            // awakeToolStripMenuItem
            // 
            this.awakeToolStripMenuItem.Name = "awakeToolStripMenuItem";
            this.awakeToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.awakeToolStripMenuItem.Text = "Awake";
            this.awakeToolStripMenuItem.Click += new System.EventHandler(this.awakeToolStripMenuItem_Click);
            // 
            // sleepToolStripMenuItem
            // 
            this.sleepToolStripMenuItem.Name = "sleepToolStripMenuItem";
            this.sleepToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.sleepToolStripMenuItem.Text = "Sleep";
            this.sleepToolStripMenuItem.Click += new System.EventHandler(this.sleepToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // niImages
            // 
            this.niImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("niImages.ImageStream")));
            this.niImages.TransparentColor = System.Drawing.Color.Transparent;
            this.niImages.Images.SetKeyName(0, "Iconsmind-Outline-Coffee.ico");
            this.niImages.Images.SetKeyName(1, "Pictogrammers-Material-Light-Sleep.ico");
            // 
            // wndAwake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "wndAwake";
            this.ShowInTaskbar = false;
            this.Text = "Awake";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.wndAwake_Load);
            this.mnuNotifyIcon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon niCoffee;
        private System.Windows.Forms.ContextMenuStrip mnuNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem awakeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sleepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ImageList niImages;
    }
}

