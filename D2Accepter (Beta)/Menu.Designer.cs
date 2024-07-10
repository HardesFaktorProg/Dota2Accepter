namespace D2Accepter__Beta_
{
	partial class Menu
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            pictureBox1 = new PictureBox();
            close_app = new PictureBox();
            rgb_panel = new Panel();
            tray_ico = new NotifyIcon(components);
            tray_menu = new ContextMenuStrip(components);
            закрытьToolStripMenuItem = new ToolStripMenuItem();
            enables = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)close_app).BeginInit();
            tray_menu.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.d2a;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(147, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 119);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // close_app
            // 
            close_app.BackColor = Color.Transparent;
            close_app.BackgroundImage = Properties.Resources.close;
            close_app.BackgroundImageLayout = ImageLayout.Zoom;
            close_app.Location = new Point(355, 4);
            close_app.Name = "close_app";
            close_app.Size = new Size(38, 40);
            close_app.TabIndex = 1;
            close_app.TabStop = false;
            close_app.Click += CloseD2A_main;
            // 
            // rgb_panel
            // 
            rgb_panel.Location = new Point(124, 157);
            rgb_panel.Name = "rgb_panel";
            rgb_panel.Size = new Size(161, 10);
            rgb_panel.TabIndex = 2;
            // 
            // tray_ico
            // 
            tray_ico.ContextMenuStrip = tray_menu;
            tray_ico.Icon = (Icon)resources.GetObject("tray_ico.Icon");
            tray_ico.Text = "TrayD2A";
            tray_ico.Visible = true;
            // 
            // tray_menu
            // 
            tray_menu.Items.AddRange(new ToolStripItem[] { закрытьToolStripMenuItem, enables });
            tray_menu.Name = "contextMenuStrip1";
            tray_menu.Size = new Size(168, 48);
            // 
            // закрытьToolStripMenuItem
            // 
            закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            закрытьToolStripMenuItem.Size = new Size(167, 22);
            закрытьToolStripMenuItem.Text = "Close D2Accepter";
            // 
            // enables
            // 
            enables.Checked = true;
            enables.CheckState = CheckState.Checked;
            enables.DisplayStyle = ToolStripItemDisplayStyle.Text;
            enables.Name = "enables";
            enables.ShowShortcutKeys = false;
            enables.Size = new Size(167, 22);
            enables.Text = "Enabled";
            enables.Click += enables_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.backgroundv2;
            ClientSize = new Size(400, 623);
            Controls.Add(rgb_panel);
            Controls.Add(close_app);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu";
            Text = "D2Accepter";
            MouseDown += MainForm_MouseDown;
            MouseMove += MainForm_MouseMove;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)close_app).EndInit();
            tray_menu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
		private PictureBox close_app;
		private Panel rgb_panel;
		private NotifyIcon tray_ico;
		private ContextMenuStrip tray_menu;
		private ToolStripMenuItem закрытьToolStripMenuItem;
		private ToolStripMenuItem enabledToolStripMenuItem;
		private ToolStripMenuItem enables;
	}
}