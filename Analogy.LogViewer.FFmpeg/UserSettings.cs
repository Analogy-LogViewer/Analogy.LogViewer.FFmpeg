using System;

namespace Analogy.LogViewer.FFmpeg
{
    [Serializable]
    public class UserSettings
    {
        public string FFmpegBinaryFolder { get; set; }
        public string LastVideoFileLoaded { get; set; }
        public UserSettings()
        {
        }
    }
}
