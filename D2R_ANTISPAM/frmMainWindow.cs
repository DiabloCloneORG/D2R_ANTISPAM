using D2R_ANTISPAM.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using GameOverlay.Drawing;
using GameOverlay.Windows;
using SharpDX.Direct2D1;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace D2R_ANTISPAM
{
    public partial class frmMainWindow : Form
    {

        private System.Drawing.Rectangle _hiddingRectangle;
        private RECT _LastD2WindowPosition = new RECT { Left = 0, Top = 0, Bottom = 0, Right = 0 };

        private bool _flagInGame = false;
        private string _lastInGameIPAddress = "";

        private Hashtable _excludedIPAddresses;
        private Hashtable _activeIPAddresses;

        private TcpActiveConnectionHelpers.MIB_TCPROW_OWNER_PID[] _TcpConnections;


        public struct POINTL
        {
            public Int32 x;
            public Int32 y;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct DEVMODE
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
            public string dmDeviceName;
            public short dmSpecVersion;
            public short dmDriverVersion;
            public short dmSize;
            public short dmDriverExtra;
            public int dmFields;
            public int dmPositionX;
            public int dmPositionY;
            public int dmDisplayOrientation;
            public int dmDisplayFixedOutput;
            public short dmColor;
            public short dmDuplex;
            public short dmYResolution;
            public short dmTTOption;
            public short dmCollate;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
            public string dmFormName;
            public short dmLogPixels;
            public int dmBitsPerPel;
            public int dmPelsWidth;
            public int dmPelsHeight;
            public int dmDisplayFlags;
            public int dmDisplayFrequency;
            public int dmICMMethod;
            public int dmICMIntent;
            public int dmMediaType;
            public int dmDitherType;
            public int dmReserved1;
            public int dmReserved2;
            public int dmPanningWidth;
            public int dmPanningHeight;
        }

        [DllImport("user32.dll")]
        public static extern bool EnumDisplaySettings(string deviceName, int modeNum, ref DEVMODE devMode);

        private int ConvertStringToInt(string s)
        {
            int i = 0;
            var result = int.TryParse(s, out i);
            if (result) return i;
            return 0;
        }


        public frmMainWindow()
        {
            InitializeComponent();

            DirectXOverlayStartup();
            _drawingFont = _graphics?.CreateFont("sans-serif", 20, true);

            _activeIPAddresses = new Hashtable();
            _excludedIPAddresses = new Hashtable();
        }


        private bool isIpAddressExcluded(string needle_ipaddress)
        {
            return _excludedIPAddresses.ContainsKey(needle_ipaddress);
        }

        private void RefreshNetworkConnectionTable()
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            Process p = null;
            _activeIPAddresses = new Hashtable();
            foreach (TcpActiveConnectionHelpers.MIB_TCPROW_OWNER_PID pid in _TcpConnections)
            {
                try
                {
                    if (p != null) { if (pid.ProcessId != p.Id) { p = Process.GetProcessById(Convert.ToInt32(pid.ProcessId)); } }
                    else { p = Process.GetProcessById(Convert.ToInt32(pid.ProcessId)); }

                    if (p.ProcessName.ToLowerInvariant() != "d2r") { continue; }
                    if (pid.State != TcpActiveConnectionHelpers.MIB_TCP_STATE.MIB_TCP_STATE_ESTAB) { continue; }
                    if (pid.RemoteAddress.ToString() == "127.0.0.1") { continue; }
                    if (pid.RemoteAddress.ToString().StartsWith("34.117.122")) { continue; }
                    if (pid.RemoteAddress.ToString().StartsWith("24.105.29")) { continue; }
                    if (pid.RemoteAddress.ToString().StartsWith("37.244.28")) { continue; }
                    if (pid.RemoteAddress.ToString().StartsWith("37.244.54")) { continue; }
                    if (pid.RemoteAddress.ToString().StartsWith("117.52.35")) { continue; }
                    if (pid.RemoteAddress.ToString().StartsWith("137.221.105")) { continue; }
                    if (pid.RemoteAddress.ToString().StartsWith("137.221.106")) { continue; }

                    /* IP Addresses Connections Found While Being Outside of a Game (IE: while in lobby, or char select screen) */

                    /* North America */
                    if (pid.RemoteAddress.ToString()=="34.95.148.93") { continue; }
                    if (pid.RemoteAddress.ToString()=="35.224.190.107") { continue; }
                    if (pid.RemoteAddress.ToString()=="35.198.33.20") { continue; }
                    if (pid.RemoteAddress.ToString()=="34.125.178.230") { continue; }
                    if (pid.RemoteAddress.ToString()=="34.106.220.198") { continue; }
                    if (pid.RemoteAddress.ToString()=="35.198.9.161") { continue; }
                    if (pid.RemoteAddress.ToString()=="34.125.192.178") { continue; }
                    if (pid.RemoteAddress.ToString()=="35.203.90.248") { continue; }
                    if (pid.RemoteAddress.ToString()=="34.106.157.7") { continue; }
                    if (pid.RemoteAddress.ToString()=="35.184.165.43") { continue; }
                    if (pid.RemoteAddress.ToString()=="34.95.254.42") { continue; }
                    if (pid.RemoteAddress.ToString()=="35.236.78.59") { continue; }
                    if (pid.RemoteAddress.ToString()=="34.106.46.242") { continue; }
                    if (pid.RemoteAddress.ToString()=="34.125.187.42") { continue; }
                    if (pid.RemoteAddress.ToString()=="34.127.3.170") { continue; }
                    if (pid.RemoteAddress.ToString()=="34.83.221.205") { continue; }
                    if (pid.RemoteAddress.ToString()=="34.145.246.88") { continue; }
                    if (pid.RemoteAddress.ToString()=="34.106.138.112") { continue; }
                    if (pid.RemoteAddress.ToString()=="35.198.38.221") { continue; }
                    if (pid.RemoteAddress.ToString()=="34.150.253.5") { continue; }
                    if (pid.RemoteAddress.ToString()=="35.247.120.89") { continue; }
                    if (pid.RemoteAddress.ToString()=="158.115.222.213") { continue; }
                    if (pid.RemoteAddress.ToString()=="158.115.222.235") { continue; }
                    if (pid.RemoteAddress.ToString() == "35.203.49.62") { continue; }
                    if (pid.RemoteAddress.ToString() == "35.244.75.115") { continue; }
                    if (pid.RemoteAddress.ToString() == "158.115.222.192") { continue; }
                    if (pid.RemoteAddress.ToString() == "34.106.62.192") { continue; }
                    if (pid.RemoteAddress.ToString() == "34.83.204.197") { continue; }
                    if (pid.RemoteAddress.ToString() == "34.145.56.105") { continue; }

                    



                    if (pid.RemotePort.ToString() == "1119") { continue; }


                    if (_excludedIPAddresses.ContainsKey(pid.RemoteAddress.ToString())) { continue; }

                    if (!_activeIPAddresses.ContainsKey(pid.RemoteAddress.ToString()))
                    {
                        _activeIPAddresses.Add(pid.RemoteAddress.ToString(), 1);
                    }
                }
                catch
                {

                }
            }


            if (_activeIPAddresses.Count < 1)
            {
                if (_flagInGame == true)
                { // We were in a game, and we seem to have left that game ip.
                    _flagInGame = false;

                    if (_lastInGameIPAddress.Length > 0)
                    {
                        _lastInGameIPAddress = "";
                    }
                }
            }
            else if (_activeIPAddresses.Count == 1)
            { // We may have joined a game
                var activeIP = (from DictionaryEntry entry in _activeIPAddresses select entry.Key).FirstOrDefault();

                if (_flagInGame == false || activeIP != null && activeIP.ToString() != _lastInGameIPAddress)
                { // This confirm we have just joined a game
                    _lastInGameIPAddress = activeIP.ToString();
                    _flagInGame = true;
                }

            }
            else if (_activeIPAddresses.Count > 1)
            {
                foreach (DictionaryEntry de in _activeIPAddresses)
                {
                    // This could be the char selection screen/lobby or in a game... better to wait for next iteration, eventually one of these connection will drop,
                    // leaving only one connection IF we're in a game, otherwise 0.
                }
            }

            if (p != null)
            { // Release the process object before next iteration.
                try
                {
                    p.Dispose();
                }
                catch { }
            }
        }

        private void frmMainWindow_Load(object sender, EventArgs e)
        {
            this.Text = "D2R-ANTISPAM UTILITY BY DiabloClone.ORG, v" + Application.ProductVersion + " - Discord Server @ https://discord.gg/FQrpzV8Smv";
            
            ReloadSettingsGenerals();

            btnStopTimer.Enabled = true;
            btnStopTimer.Visible = true;

            btnStartTimer.Visible = false;
            btnStartTimer.Enabled = false;

            tmrRefresh.Enabled = true;

        }


        private void ReloadSettingsGenerals()
        {
            try
            {

                this.TopMost = Settings.Default.KeepOnTop;
            }
            catch
            {
                MessageBox.Show(this,
                    "An error occured while loading the configuration (General Options section).\r\n\r\n" +
                        "Please make sure you have the latest version with all the necessary included files.",
                    "Configuration Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void SaveSettingsGenerals()
        {
            try
            {
                Settings.Default.Save();
                Settings.Default.Reload();
            }
            catch
            {
                MessageBox.Show(this,
                    "An error occured while saving the configuration (General Options section).\r\n\r\n" +
                        "Please make sure you have the latest version with all the necessary included files.",
                    "Configuration Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            _TcpConnections = TcpActiveConnectionHelpers.GetAllTcpConnections();

            RefreshNetworkConnectionTable();

            RefreshLobbyCensor();
        }


        
        private void frmMainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void frmMainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        

        private GameOverlay.Windows.OverlayWindow _window;
        private GameOverlay.Drawing.SolidBrush _black;
        private GameOverlay.Drawing.SolidBrush _red;
        private GameOverlay.Drawing.SolidBrush _white;
        private GameOverlay.Drawing.SolidBrush _yellow;

        private GameOverlay.Drawing.Graphics _graphics;
        private SharpDX.Direct2D1.WindowRenderTarget _device;
        private GameOverlay.Drawing.SolidBrush _currentBrush;
        private GameOverlay.Drawing.Font _drawingFont;

        private Process GetProcess() => Process.GetProcessesByName("d2r")?.FirstOrDefault();
        private Process gameProcess;
        private IntPtr gameWindowHandle;


        public int DirectXOverlayStartup()
        {
            if (gameProcess == default)
            {
                gameProcess = GetProcess();
            }
            if (gameProcess == default) { return 1; }

            if (gameProcess.HasExited)
            {
                gameProcess = null;
            }
            if (gameProcess == default)
            {
                gameProcess = GetProcess();
            }
            if (gameProcess == default) { return 1; }

            gameWindowHandle = gameProcess.MainWindowHandle;

            DEVMODE devMode = default;
            devMode.dmSize = (short)Marshal.SizeOf<DEVMODE>();
            EnumDisplaySettings(null, -1, ref devMode);

            // (Re)Create and initialize the overlay window.
            _window?.Dispose();
            _window = new OverlayWindow(0, 0, devMode.dmPelsWidth, devMode.dmPelsHeight);
            _window?.Create();

            // Create and initialize the graphics object.
            _graphics?.Dispose();
            _graphics = new Graphics()
            {
                MeasureFPS = false,
                PerPrimitiveAntiAliasing = false,
                TextAntiAliasing = true,
                UseMultiThreadedFactories = false,
                VSync = false,
                Width = _window.Width,
                Height = _window.Height,
                WindowHandle = _window.Handle
            };
            _graphics?.Setup();

            // Get a refernence to the underlying RenderTarget from SharpDX. This'll be used to draw portions of images.
            if (_device!=null)
            {
                _device.Dispose();
            }
            _device = (WindowRenderTarget)typeof(Graphics).GetField("_device", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(_graphics);
            _black = _graphics?.CreateSolidBrush(0, 0, 0);
            _red = _graphics?.CreateSolidBrush(250, 0, 0);
            _white = _graphics?.CreateSolidBrush(255, 255, 255);
            _yellow = _graphics?.CreateSolidBrush(255, 255, 0);
            _currentBrush = _black;

            return 0;
        }

        private void RefreshLobbyCensor()
        {
            if (!_flagInGame)
            {
                _window?.Show();
                DrawLobbyCensor();
            }
            else
            {
                _window?.Hide();
            }
        }

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool IsWindowVisible(IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetWindowRect(HandleRef hWnd, out RECT lpRect);

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;        // x position of upper-left corner
            public int Top;         // y position of upper-left corner
            public int Right;       // x position of lower-right corner
            public int Bottom;      // y position of lower-right corner
        }

        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        private void DrawLobbyCensor() 
        {
            RECT _CurrentD2WindowPosition;

            try
            {
                _graphics?.BeginScene();
                _graphics?.ClearScene();
                if (_device == null)
                {
                    DirectXOverlayStartup();
                    return;
                }

                gameProcess = GetProcess();
                if (gameProcess==null) { return;  }
                if (gameWindowHandle!=gameProcess.MainWindowHandle)
                {
                    DirectXOverlayStartup();
                    return;
                }
                gameWindowHandle = gameProcess.MainWindowHandle;

                if (_window != null && _window.IsInitialized && gameProcess != null)
                {
                    GetWindowRect(new HandleRef(gameProcess, gameWindowHandle), out _CurrentD2WindowPosition);
                }

                _window?.PlaceAbove(gameWindowHandle);
                _window?.FitTo(gameWindowHandle, true);

            }
            catch { }

            System.Drawing.Rectangle bounds = Screen.GetBounds(System.Drawing.Point.Empty);
            System.Drawing.Bitmap bitmap32bppPArgb = new System.Drawing.Bitmap(bounds.Width, bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
            System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(bitmap32bppPArgb);
            g.CopyFromScreen(System.Drawing.Point.Empty, System.Drawing.Point.Empty, bounds.Size);
            

            System.Drawing.Rectangle screenshot_rectangle = new System.Drawing.Rectangle(0, 0, bitmap32bppPArgb.Width, bitmap32bppPArgb.Height);
            Emgu.CV.Image<Emgu.CV.Structure.Bgr, byte> screenshot;

            System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(bounds.Width, bounds.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            using (System.Drawing.Graphics gr = System.Drawing.Graphics.FromImage(bitmap))
            {
                gr.DrawImage(bitmap32bppPArgb, new System.Drawing.Rectangle(0, 0, bitmap.Width, bitmap.Height));
            }
            
            // Transfert from memory.
            BitmapData bitmapData = bitmap.LockBits(screenshot_rectangle, ImageLockMode.ReadOnly, bitmap.PixelFormat);
            screenshot = new Emgu.CV.Image<Bgr, byte>(bitmap.Width, bitmap.Height, bitmapData.Stride, bitmapData.Scan0);
            bitmap.UnlockBits(bitmapData);

            try
            {
                var gray_screenshot = screenshot.Convert<Emgu.CV.Structure.Gray, byte>();

                // Somehow, even value is a problem, so let make sure the value is not a even value.
                if ((numSmoothGaussian.Value % 2) == 0)
                {
                    gray_screenshot = gray_screenshot.SmoothGaussian(Convert.ToInt32(numSmoothGaussian.Value+1));
                }
                else
                {
                    gray_screenshot = gray_screenshot.SmoothGaussian(Convert.ToInt32(numSmoothGaussian.Value));
                }
                
                gray_screenshot = gray_screenshot.ThresholdToZero(new Gray(Convert.ToInt32(numThresholdToZero.Value)));
                if (chkVerboseProcessing.Checked)
                {
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();
                        pictureBox1.Image = null;
                    }

                    pictureBox1.Image = (System.Drawing.Image)gray_screenshot.ToBitmap().Clone();
                }

                gray_screenshot = gray_screenshot.ThresholdBinary(new Gray(Convert.ToInt32(numThresholdBinary1.Value)), new Gray(Convert.ToInt32(numThresholdBinary2.Value)));
                if (chkVerboseProcessing.Checked)
                {
                    if (pictureBox2.Image != null)
                    {
                        pictureBox2.Image.Dispose();
                        pictureBox2.Image = null;
                    }

                    pictureBox2.Image = (System.Drawing.Image)gray_screenshot.ToBitmap().Clone();
                }

                gray_screenshot = gray_screenshot.Canny(Convert.ToInt32(numCanny1.Value), Convert.ToInt32(numCanny2.Value));
                if (chkVerboseProcessing.Checked)
                {
                    if (pictureBox3.Image != null)
                    {
                        pictureBox3.Image.Dispose();
                        pictureBox3.Image = null;
                    }

                    pictureBox3.Image = (System.Drawing.Image)gray_screenshot.ToBitmap().Clone();
                }

                gray_screenshot = gray_screenshot.Dilate(Convert.ToInt32(numDilate.Value));
                gray_screenshot = gray_screenshot.Erode(Convert.ToInt32(numErode.Value));
                if (chkVerboseProcessing.Checked)
                {
                    if (pictureBox4.Image != null)
                    {
                        pictureBox4.Image.Dispose();
                        pictureBox4.Image = null;
                    }

                    pictureBox4.Image = (System.Drawing.Image)gray_screenshot.ToBitmap().Clone();
                }

                VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
                Mat m = new Mat();

                CvInvoke.FindContours(
                       gray_screenshot,
                       contours,
                       m,
                       Emgu.CV.CvEnum.RetrType.List,
                       Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);

                
                
                
                
                _window.PlaceAbove(gameProcess.MainWindowHandle);
                
                
                

                for (int i = 0; i < contours.Size; i++)
                {
                    double perimeter = CvInvoke.ArcLength(contours[i], true);
                    VectorOfPoint approx = new VectorOfPoint();
                    CvInvoke.ApproxPolyDP(contours[i], approx, 0.01 * perimeter, true);

                    

                    var moments = CvInvoke.Moments(contours[i]);
                    int x = (int)(moments.M10 / moments.M00);
                    int y = (int)(moments.M01 / moments.M00);

                    if (approx.Size==4)
                    {
                        //CvInvoke.DrawContours(screenshot, contours, i, new MCvScalar(0, 0, 255), 4);

                        System.Drawing.Rectangle rect = CvInvoke.BoundingRectangle(contours[i]);
                        GameOverlay.Drawing.Rectangle grect = new GameOverlay.Drawing.Rectangle(rect.Left, rect.Top, rect.Right, rect.Bottom);

                        GetWindowRect(new HandleRef(gameProcess, gameProcess.MainWindowHandle), out _CurrentD2WindowPosition);

                        if (IsWindowVisible(gameProcess.MainWindowHandle))
                        {
                            if (rect.X > 25 && rect.Y > 25 && rect.Width > 300 && rect.Height > 500 && rect.X < (int)(screenshot.Width / 2) && rect.Width < (int)(screenshot.Width / 3))
                            {

                                if (_CurrentD2WindowPosition.Left != _LastD2WindowPosition.Left ||
                                    _CurrentD2WindowPosition.Right != _LastD2WindowPosition.Right ||
                                    _CurrentD2WindowPosition.Top != _LastD2WindowPosition.Top ||
                                    _CurrentD2WindowPosition.Bottom != _LastD2WindowPosition.Bottom)
                                {
                                    _hiddingRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
                                    _LastD2WindowPosition = _CurrentD2WindowPosition;
                                }

                                Console.WriteLine(new System.Drawing.Rectangle(_window.X, _window.Y, _window.Width, _window.Height).ToString());
                                if ((rect.Width * rect.Height) > (_hiddingRectangle.Width * _hiddingRectangle.Height))
                                {
                                    _hiddingRectangle = rect;
                                }
                                if (_hiddingRectangle.Height< 600) { _hiddingRectangle.Height = 600; }

                                CvInvoke.Rectangle(screenshot, _hiddingRectangle, new MCvScalar(0, 0, 255), 4, Emgu.CV.CvEnum.LineType.FourConnected);
                                _graphics?.FillRectangle(_white, _hiddingRectangle.X, _hiddingRectangle.Y, _hiddingRectangle.X + _hiddingRectangle.Width, _hiddingRectangle.Y + _hiddingRectangle.Height);
                                _graphics?.FillRectangle(_black, _hiddingRectangle.X + 20, _hiddingRectangle.Y + 20, _hiddingRectangle.X + _hiddingRectangle.Width - 20, _hiddingRectangle.Y + _hiddingRectangle.Height - 20);
                                Console.WriteLine("Old section: " + _hiddingRectangle.X + ", " + _hiddingRectangle.Y + " -> " + _hiddingRectangle.Width + "x" + _hiddingRectangle.Height);
                                

                                int xOffset = _hiddingRectangle.X + 50;
                                int yOffset = _hiddingRectangle.Y + 30;

                                DrawTextBlock(xOffset, yOffset, "D2R ANTI-SPAM UTILITY", _red);
                                yOffset += 50;

                                DrawTextBlock(xOffset, yOffset, "STOP THE NON-SENSE, LAUGH A LITTLE", _white);
                                yOffset += 25;

                                DrawTextBlock(xOffset, yOffset, "AND JOIN US ON OUR DISCORD SERVER:", _white);
                                yOffset += 25;

                                DrawTextBlock(xOffset, yOffset, "https://discord.gg/FQrpzV8Smv", _yellow);
                                yOffset += 25;

                                byte[] tired_of_your_shit_image = ImageToByteArray(Properties.Resources.TIRED_OF_YOUR_SHIT);
                                _graphics?.DrawImage(new GameOverlay.Drawing.Image(_device, tired_of_your_shit_image), new Point(_hiddingRectangle.X + 50, yOffset), 1);
                                tired_of_your_shit_image = null;

                            }
                        }
                        else
                        {
                            Console.WriteLine("D"); 
                            _graphics.ClearScene();
                        }
                    }
                }

                if (chkVerboseProcessing.Checked)
                {
                    if (pictureBox5.Image != null)
                    {
                        pictureBox5.Image.Dispose();
                        pictureBox5.Image = null;
                    }

                    pictureBox5.Image = (System.Drawing.Image)screenshot.ToBitmap().Clone();
                }

                screenshot.Dispose();

                
                //_device.Flush();

                // _device.Transform = new SharpDX.Mathematics.Interop.RawMatrix3x2(ConvertStringToInt(CustomScale.Text), 0f, 0f, ConvertStringToInt(CustomScale.Text), 0f, 0f);



            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }

            try { }
            catch (Exception ex) { }
            finally
            {
                _graphics?.EndScene();

                screenshot.Dispose();
                bitmapData = null;
                bitmap.Dispose();
                g.Dispose();

                System.GC.Collect();

            }


        }

        private void DrawTextBlock(float dx, float dy, string data, SolidBrush color)
        {
            try
            {
                _graphics?.DrawText(_drawingFont, _drawingFont.FontSize, color, dx, dy, data);
            }
            catch { }
        }


        private void numericTweak_ValueChanged(object sender, EventArgs e)
        {
            try { RefreshLobbyCensor(); }
            catch { }
        }


        private void btnStartTimer_Click(object sender, EventArgs e)
        {
            
            btnStopTimer.Enabled = true;
            btnStopTimer.Visible = true;

            btnStartTimer.Visible = false;
            btnStartTimer.Enabled = false;

            tmrRefresh.Enabled = true;
        }

        private void btnStopTimer_Click(object sender, EventArgs e)
        {
            btnStopTimer.Enabled = false;
            btnStopTimer.Visible = false;

            btnStartTimer.Visible = true;
            btnStartTimer.Enabled = true;

            tmrRefresh.Enabled = false;
        }

        private void chkVerboseProcessing_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {

            }
            else
            {
                pictureBox1.Image = null;
                pictureBox2.Image = null;
                pictureBox3.Image = null;
                pictureBox4.Image = null;
                pictureBox5.Image = null;
            }
        }

        private void linkDiabloCloneDiscordServer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://discord.gg/FQrpzV8Smv",
                UseShellExecute = true
            });
        }

        private void chkKeepOnTop_CheckedChanged_1(object sender, EventArgs e)
        {
            this.TopMost = ((CheckBox)sender).Checked;
        }
    }
}
