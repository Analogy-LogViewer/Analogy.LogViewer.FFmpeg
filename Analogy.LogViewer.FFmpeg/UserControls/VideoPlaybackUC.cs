using System;
using System.IO;
using System.Windows.Forms;
using Analogy.LogViewer.FFmpeg.Properties;
using LibVLCSharp.Shared;

namespace Analogy.LogViewer.FFmpeg.UserControls
{
    public partial class VideoPlaybackUC : XtraUserControl
    {
        public event EventHandler<string> VideoLoaded;
        public string VideoFile { get; private set; }
        private bool VlcInitialized { get; set; }
        private LibVLC LibVLC { get; set; }
        private MediaPlayer MediaPlayer { get; set; }
        private long CurrentRecordingPosition { get; set; }
        private bool duringMouseDraggingOfSlider;
        public VideoPlaybackUC()
        {
            if (!DesignMode)
            {
                Core.Initialize();
            }
            InitializeComponent();
            InitializeVLC();
        }

        public VideoPlaybackUC(string videoFile) : this()
        {
            VideoFile = videoFile;
        }
        private void VideoPlaybackUC_Load(object sender, EventArgs e)
        {
            if (DesignMode)
            {
                return;
            }
            SetupEventHandlers();
            if (!string.IsNullOrEmpty(VideoFile))
            {
                LoadVideo(VideoFile);
            }
        }

        private void InitializeVLC()
        {
            if (!VlcInitialized)
            {
                VlcInitialized = true;
                LibVLC = new LibVLC();
                MediaPlayer = new MediaPlayer(LibVLC);
                MediaPlayer.EnableHardwareDecoding = true;
                videoView1.MediaPlayer = MediaPlayer;
            }
        }
        public void DisposeVC()
        {
            MediaPlayer.Stop();
            MediaPlayer.Dispose();
            LibVLC.Dispose();
        }
        private void SetupEventHandlers()
        {
            MediaPlayer.TimeChanged += (s, e) =>
            {
                lblplaybackTime.InvokeIfRequired(lblplaybackTime =>
                {
                    lblplaybackTime.Text = $"{TimeSpan.FromMilliseconds(e.Time):c}/{TimeSpan.FromMilliseconds(MediaPlayer.Length):c}";
                });
            };
            //SizeChanged += (s, e) =>
            //{
            //    dockPanelVideo.FloatSize = Size;
            //};
            bbiOpenVideo.ItemClick += (s, e) =>
            {
                var file = GetVideoFile();
                if (!string.IsNullOrEmpty(file))
                {
                    LoadVideo(file);

                }
            };
            sbtnPlayback.Click += (s, e) =>
            {
                if (MediaPlayer.IsPlaying)
                {
                    MediaPlayer.Pause();
                }
                else
                {
                    MediaPlayer.Play();
                }
            };
            sbtnStop.Click += (s, e) =>
            {

                MediaPlayer.Stop();
            };

            tbTime.BeforeShowValueToolTip += (s, e) =>
            {
                var current = TimeSpan.FromMilliseconds(tbTime.Value);
                e.ShowArgs.ToolTip = $"{current:c})";
            };
            tbTime.MouseDown += (s, e) =>
            {
                TrackBarControl trackBar = s as TrackBarControl;
                TrackBarViewInfo viewInfo = trackBar.GetViewInfo() as TrackBarViewInfo;
                var hitInfo = viewInfo.CalcHitInfo(e.Location);
                if (hitInfo.HitTest == EditHitTest.Button)
                {
                    duringMouseDraggingOfSlider = true;
                }
            };
            tbTime.MouseUp += (s, e) =>
            {
                TrackBarControl trackBar = s as TrackBarControl;
                TrackBarViewInfo viewInfo = trackBar.GetViewInfo() as TrackBarViewInfo;
                var hitInfo = viewInfo.CalcHitInfo(e.Location);
                if (hitInfo.HitTest == EditHitTest.Button)
                {
                    MediaPlayer.Time = tbTime.Value;
                    duringMouseDraggingOfSlider = false;
                }

            };

            MediaPlayer.LengthChanged += MediaPlayer_LengthChanged;
            MediaPlayer.TimeChanged += MediaPlayer_TimeChanged;
            MediaPlayer.Stopped += (s, e) =>
                sbtnPlayback.InvokeIfRequired(b => b.ImageOptions.Image = Resources.Play_32x32);
            MediaPlayer.Paused += (s, e) =>
                sbtnPlayback.InvokeIfRequired(b => b.ImageOptions.Image = Resources.Play_32x32);
            MediaPlayer.Playing += (s, e) =>
                sbtnPlayback.InvokeIfRequired(b => b.ImageOptions.Image = Resources.Pause_32x32);

        }

        private void MediaPlayer_TimeChanged(object sender, MediaPlayerTimeChangedEventArgs e)
        {
            tbTime.InvokeIfRequired(l =>
            {
                if (!duringMouseDraggingOfSlider)
                {
                    tbTime.Value = (int)e.Time;

                }
            });
        }

        private void MediaPlayer_LengthChanged(object sender, MediaPlayerLengthChangedEventArgs e)
        {
            this.InvokeIfRequired(l =>
            {
                var length = TimeSpan.FromMilliseconds(e.Length);
                tbTime.Properties.Maximum = (int)e.Length;
                tbTime.Properties.Labels.BeginUpdate();
                tbTime.Properties.Labels.Clear();
                tbTime.Properties.Labels.Add(new TrackBarLabel("0:00:00", tbTime.Properties.Minimum));
                tbTime.Properties.Labels.Add(new TrackBarLabel($"{length:c}", tbTime.Properties.Maximum));
                tbTime.Properties.ShowLabels = true;
                tbTime.Properties.ShowValueToolTip = true;
                tbTime.Properties.Labels.EndUpdate();

            });
        }
        private void LoadVideo(string filename)
        {
            VideoFile = filename;
            var media = new Media(LibVLC, VideoFile);
            MediaPlayer.Media = media;
            media.AddOption(":start-paused");
            MediaPlayer.Play();
            MediaPlayer.Position = 0;
            sbtnPlayback.Enabled = true;
            sbtnStop.Enabled = true;
            var dir = Path.GetDirectoryName(filename);
            VideoLoaded?.Invoke(this, filename);
        }
        private string GetVideoFile()
        {
            using (var openFileDialog1 = new OpenFileDialog
            {
                Multiselect = false,
                Filter = "All Media Files|*.wmv;*.avi;*.mpg;*.mpeg;*.m1v;*.mpe;*.m3u;*.mp4;*.mov;*.3g2;*.3gp2;*.3gp;*.3gpp;*.m4a;*.cda;*.aif;*.aifc;*.aiff;*.mid;*.midi;*.rmi;*.mkv;*.WAV;*.AAC;*.WMA;*.WMV;*.AVI;*.MPG;*.MPEG;*.M1V;*.MP2;*.MP3;*.MPA;*.MPE;*.M3U;*.MP4;*.MOV;*.3G2;*.3GP2;*.3GP;*.3GPP;*.M4A;*.CDA;*.AIF;*.AIFC;*.AIFF;*.MID;*.MIDI;*.RMI;*.MKV"
            })
            {
                DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
                if (result == DialogResult.OK) // Test result.
                {
                    return openFileDialog1.FileName;
                }
            }

            return string.Empty;
        }


        public void HidePlayAndStopButtons()
        {
            sbtnPlayback.Visible = false;
            sbtnStop.Visible = false;
            tbTime.Visible = false;
        }

        public long GetCurrentPosition() => MediaPlayer.Time;

        public void SetSync(long recordingPositionMilliseconds)
        {
            var videoPositionMilliseconds = MediaPlayer.Time;
            var dir = Path.GetDirectoryName(VideoFile);
        }
        public void SetCurrentRecordingPosition(long position)
        {
            CurrentRecordingPosition = position;
        }

        public void ResumePlay()
        {
            this.InvokeIfRequired(m => MediaPlayer.Play());
        }

        public void Pause()
        {
            this.InvokeIfRequired(m => MediaPlayer.Pause());


        }

        public void StartPlay()
        {
            this.InvokeIfRequired(m =>
                {
                    MediaPlayer.Play();
                    MediaPlayer.Position = 0.0f;
                }
            );
        }

        public void SetVideoOffsetFromStart(long timeMilliseconds)
        {
            if (timeMilliseconds >= 0 && timeMilliseconds < MediaPlayer.Length)
            {
                MediaPlayer.Time = timeMilliseconds;
            }

        }

        public void StopPlay()
        {
            this.InvokeIfRequired(m => MediaPlayer.Stop());
        }
    }
}
