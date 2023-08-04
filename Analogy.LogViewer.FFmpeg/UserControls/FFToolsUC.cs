using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Analogy.Interfaces;
using Analogy.LogViewer.FFmpeg.Managers;
using FFMpegCore;
using Microsoft.Extensions.Logging;

namespace Analogy.LogViewer.FFmpeg.UserControls
{
    public partial class FFToolsUC : UserControl
    {
        public FFToolsUC()
        {
            InitializeComponent();
        }

        public FFToolsUC(ILogger logger) : this()
        {

        }
        private void FFToolsUC_Load(object sender, EventArgs e)
        {
            txtbVideoFile.Text = UserSettingsManager.Instance.LastVideoFileLoaded;
        }

        private void tnSelectVideo_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                DialogResult result = openFileDialog.ShowDialog(); // Show the dialog.
                if (result == DialogResult.OK) // Test result.
                {
                    txtbVideoFile.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            GlobalFFOptions.Configure(options => options.BinaryFolder = UserSettingsManager.Instance.FFmpegBinaryFolder);
            string inputFile = txtbVideoFile.Text;
            try
            {
                if (File.Exists(inputFile))
                {
                    tcStreams.TabPages.Clear();
                    var mediaInfo = FFProbe.Analyse(txtbVideoFile.Text);
                    tbInfoDuration.Text = mediaInfo.Duration.ToString();
                    tbInfoFormatBitRate.Text = mediaInfo.Format.BitRate.ToString();
                    tbInfoFormatDuration.Text = mediaInfo.Format.Duration.ToString();
                    tbInfoFormatName.Text = mediaInfo.Format.FormatName;
                    tbInfoFormatLongName.Text = mediaInfo.Format.FormatLongName;
                    tbInfoFormatStartTime.Text = mediaInfo.Format.StartTime.ToString();
                    gbStreams.Text = $"Streams:{mediaInfo.VideoStreams.Count}";
                    for (int i = 0; i < mediaInfo.VideoStreams.Count; i++)
                    {
                        VideoStream? stream = mediaInfo.VideoStreams[i];
                        TabPage page = new TabPage($"Stream: {i}");
                        VideoStreamInfoUC uc = new VideoStreamInfoUC(stream);
                        page.Controls.Add(uc);
                        uc.Dock = DockStyle.Fill;
                        tcStreams.TabPages.Add(page);
                    }

                    var packets = FFProbe.GetPackets(inputFile).Packets.Where(p => p.CodecType.StartsWith("video", StringComparison.InvariantCultureIgnoreCase));
                    rtbPackets.Text = string.Join(Environment.NewLine,
                        packets.Select(p =>
                            $"pts time: {p.PtsTime}. Dts time: {p.DtsTime}. Duration: {p.Duration}."));
                }


            }
            catch (Exception exception)
            {
                MessageBox.Show($"Error: {exception.Message}", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void txtbVideoFile_TextChanged(object sender, EventArgs e)
        {
            UserSettingsManager.Instance.LastVideoFileLoaded = txtbVideoFile.Text;
            UserSettingsManager.Instance.Save();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {


        }
    }
}
