using Analogy.LogViewer.FFmpeg.Properties;
using Analogy.LogViewer.FFmpeg.UserControls;
using Analogy.LogViewer.Template.WinForms;
using Microsoft.Extensions.Logging;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analogy.LogViewer.FFmpeg.IAnalogy
{
    public class FFmpegUserSettingsFactory : TemplateUserSettingsFactoryWinForms
    {
        public override Guid FactoryId { get; set; } = FFmpegFactories.Id;
        public override Guid Id { get; set; } = new Guid("c84a5f45-c6a6-423a-86c2-a650581da0bf");
        public override UserControl DataProviderSettings { get; set; }
        public override Image SmallImage { get; set; } = Resources.ffmpeg16x16;
        public override Image LargeImage { get; set; } = Resources.ffmpeg32x32;
        public override string Title { get; set; } = "FFmpeg Settings";

        public FFmpegUserSettingsFactory()
        {
        }

        public override void CreateUserControl(ILogger logger)
        {
            DataProviderSettings = new UserSettingsUC();
        }

        public override Task SaveSettingsAsync()
        {
            return Task.CompletedTask;
        }
    }
}