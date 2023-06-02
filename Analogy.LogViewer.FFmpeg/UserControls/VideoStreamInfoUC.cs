using System;
using System.Windows.Forms;
using FFMpegCore;

namespace Analogy.LogViewer.FFmpeg.UserControls
{
    public partial class VideoStreamInfoUC : UserControl
    {
        private VideoStream Stream { get; }

        public VideoStreamInfoUC()
        {
            InitializeComponent();
        }

        public VideoStreamInfoUC(FFMpegCore.VideoStream stream) : this()
        {
            Stream = stream;
        }
        private void VideoStreamInfoUC_Load(object sender, EventArgs e)
        {
            tbStreamCodecName.Text = Stream.CodecName;
            tbStreamCodecLongName.Text = Stream.CodecLongName;
            tbStreamStartTime.Text = Stream.StartTime.ToString();
            tbStreamDimension.Text = $@"{Stream.Height} x {Stream.Width}";
            tbStreamFrameRate.Text = Stream.FrameRate.ToString();
            tbStreamPixelFormat.Text = Stream.PixelFormat;

        }
    }
}
