using System;

namespace Analogy.LogViewer.FFmpeg
{
    [Serializable]
    public class UserSettings
    {
        public string SubscribePort { get; set; }
        public string PublishPort { get; set; }
        public string FFmpegBinaryFolder { get; set; }
        public string LastVideoFileLoaded { get; set; }
        public UserSettings()
        {
            SubscribePort = ">tcp://localhost:8000";
            PublishPort = ">tcp://localhost:8001";
        }
    }
}
