using System;
using System.IO;

namespace Analogy.LogViewer.FFmpeg.Managers
{
    [Serializable]
    public class UserSettingsManager
    {
        private static readonly Lazy<UserSettingsManager> _instance =
            new Lazy<UserSettingsManager>(() => new UserSettingsManager());

        public static UserSettingsManager Instance { get; } = _instance.Value;
        private string FileName { get; } = "IntuitiveSettings.dat";

        public string SubscribePort
        {
            get => Settings.SubscribePort;
            set => Settings.SubscribePort = value;
        }

        public string PublishPort
        {
            get => Settings.PublishPort;
            set => Settings.PublishPort = value;
        }
        public string FFmpegBinaryFolder 
        {
            get => Settings.FFmpegBinaryFolder;
            set => Settings.FFmpegBinaryFolder = value;
        }
        public string LastVideoFileLoaded
        {
            get => Settings.LastVideoFileLoaded;
            set => Settings.LastVideoFileLoaded = value;
        }
        private UserSettings Settings { get; }
        public UserSettingsManager()
        {
            if (File.Exists(FileName))
            {
                try
                {
                    Settings = Utils.DeSerializeJsonFile<UserSettings>(FileName);

                }
                catch (Exception)
                {
                    Settings = new UserSettings();
                }
            }
            else
            {
                Settings = new UserSettings();
            }
        }
        public void Save()
        {
            Utils.SerializeToJsonFile(Settings, FileName);
        }
    }
}
