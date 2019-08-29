using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing.Common;
using ZXing;
using ZXing.QrCode;
namespace System
{
    public partial class QR_Camera : Form
    {
        public QR_Camera()
        {
            InitializeComponent();
        }

        private FilterInfoCollection videoDevicesList;
        private IVideoSource videoSource;
        private void QR_Camera_Load(object sender, EventArgs e)
        {
            videoDevicesList = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo videoDevice in videoDevicesList)
            {
                comboBox1.Items.Add(videoDevice.Name);
            }
            comboBox1.SelectedIndex = 0;
            MessageBox.Show(EnCryptDecrypt.CryptorEngine.Encrypt("20151171414", true));
            Clipboard.SetText(EnCryptDecrypt.CryptorEngine.Encrypt("20151171414", true));
        }
        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // get new frame
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            // here you can process the frame
            pictureBox1.BackgroundImage = bitmap;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            videoSource = new VideoCaptureDevice(videoDevicesList[comboBox1.SelectedIndex].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
            videoSource.Start();
            decode_QRtag();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            videoSource.SignalToStop();
            if (videoSource != null && videoSource.IsRunning && pictureBox1.Image != null)
            {
                pictureBox1.BackgroundImage.Dispose();
            }

        }

        private void QR_Camera_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
            }
            pictureBox1.BackgroundImage.Dispose();
        }

        private void decode_QRtag()
        {
            try
            {
                //pictureBox1 shows the web cam video
                Bitmap bitmap = new Bitmap(pictureBox1.BackgroundImage);

                BarcodeReader reader = new BarcodeReader { AutoRotate = true ,TryInverted=true};
                Result result = reader.Decode(bitmap);
                string decoded = result.ToString().Trim();
                //capture a snapshot if there is a match
                //PictureBox2.Image = bitmap;
                MessageBox.Show(decoded);
                videoSource.SignalToStop();
            }
            catch
            {
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decode_QRtag();
        }
    }
}
