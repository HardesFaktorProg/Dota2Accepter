//////////////////////////////////////////////**
//                                             //
//   AAAAA    RRRRR    CCCCCC | IIIII  TTTTTTT //
//  A     A   R   R    C      |   T       T    //
// A       A  RRRRR    C      |   I       T    //
// AAAAAAAAA  R   R    C      |   I       T    //
// A       A  R    R   C      |   I       T    //
// A       A  R     R  CCCCCC | IIIII     T    //
//////////////////////////////////////////////**
// TITLE: Dota 2 Accepter //
//------------------------//
// DESC: This C# program appears to be a part of a system designed to automate actions in the game Dota 2.
// It includes functions to simulate mouse clicks, check the color of the screen pixel, and
// continuously scan for specific colors to trigger actions. The program also features window dragging,
// application closing, and scanning enable/disable functionality.
//------------------------//
// Version: BETA dev      //
/////////////////////////////
// Developers: HardesFaktor /
/////////////////////////////

using System.Threading;
using System.Runtime.InteropServices;
using System.Linq.Expressions;
using System.Diagnostics;
using System.Drawing.Drawing2D;

namespace D2Accepter__Beta_
{
    public partial class Menu : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(uint dwFlags, int dx, int dy, uint cButtons, uint dwExtraInfo);

        //* For AcceptMatch()
        public const uint MOUSEEVENTF_LEFTDOWN = 0x02;
        public const uint MOUSEEVENTF_LEFTUP = 0x04;

        // Method to simulate a mouse click at the center of the screen
        public void AcceptMatch()
        {
            // Get the screen dimensions
            Screen screen = Screen.PrimaryScreen;
            int screenWidth = screen.Bounds.Width;
            int screenHeight = screen.Bounds.Height;

            // Calculate the center coordinates of the screen
            int centerX = screenWidth / 2;
            int centerY = screenHeight / 2;

            // Set the cursor to the center of the screen
            Cursor.Position = new System.Drawing.Point(centerX, centerY);

            // Simulate a left mouse button click
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, centerX, centerY, 0, 0);
        }

        // Variable to control the global switch for scanning
        public bool GlobalSwitch = false;

        // Variable to set the scanning interval
        public int ScanTick = 1000;

        // Array to store RGB values of the pixel color
        static int[] colors = new int[3];

        // Constructor
        public Menu()
        {
            InitializeComponent();
            RoundPanel(rgb_panel, 10); // Rounded panel design
        }

        // Method to check the color of the center pixel of the screen
        public static void MatchMessageBox_Checker()
        {
            // Get the screen resolution
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            // Calculate the center pixel coordinates
            int centerX = screenWidth / 2;
            int centerY = screenHeight / 2;

            // Create a bitmap to capture the screen
            using (Bitmap screenBitmap = new Bitmap(screenWidth, screenHeight))
            {
                // Create a graphics object to capture the screen
                using (Graphics screenGraphics = Graphics.FromImage(screenBitmap))
                {
                    // Capture the screen
                    screenGraphics.CopyFromScreen(0, 0, 0, 0, new Size(screenWidth, screenHeight));
                }

                // Get the color of the center pixel
                Color centerColor = screenBitmap.GetPixel(centerX, centerY);

                // Copy RGB data from the central pixel
                colors[0] = centerColor.R;
                colors[1] = centerColor.G;
                colors[2] = centerColor.B;

                // Display the color in the panel
                Color SelectedColor = Color.FromArgb(colors[0], colors[1], colors[2]);
            }
        }

        // Method to start scanning for the target color
        public void StartScanning()
        {
            // Create a new thread to invoke functions and control other functions
            Thread T_1 = new Thread(func_invokation);
            if (GlobalSwitch == true)
            {
                T_1.Start();
            }
        }

        // Method to continuously check for the target color
        void func_invokation()
        {
            while (true)
            {
                Thread.Sleep(ScanTick);
                MatchMessageBox_Checker(); // Check the color of the center pixel
                rgb_panel.BackColor = Color.FromArgb(colors[0], colors[1], colors[2]); // Display the color in the panel
                if (colors[0] == 60 && colors[1] == 94 && colors[2] == 78)
                {
                    AcceptMatch(); // If the target color is detected, simulate a mouse click
                }
                else if (GlobalSwitch == false)
                {
                    MessageBox.Show("Scanner is Stopped!");
                    break;
                }
            }
        }

        // Method to create a rounded panel
        private void RoundPanel(Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            panel.Region = new Region(path);
        }

        // Method to handle window dragging
        Point lastpoint;
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        // Method to close the application
        private void CloseD2A_main(object sender, EventArgs e)
        {
            GlobalSwitch = false;
            Form.ActiveForm.Close();
        }
        private void CloseD2A_tray(object sender, EventArgs e)
        {
            GlobalSwitch = false;
            this.Close();
        }

        // Method to enable/disable the scanning
        private void enables_Click(object sender, EventArgs e)
        {
            switch (enables.Checked)
            {
                case true: enables.Checked = false; GlobalSwitch = false; break;
                case false: enables.Checked = true; GlobalSwitch = true; StartScanning(); break;
            }
        }
    }
}
