using Analogy.Interfaces;
using Analogy.Interfaces.DataTypes;
using Analogy.LogViewer.FFmpeg.Properties;
using Analogy.LogViewer.FFmpeg.UserControls;
using Microsoft.Extensions.Logging;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analogy.LogViewer.FFmpeg.IAnalogy
{
    internal class FFTools : IAnalogyCustomUserControl
    {
        public UserControl UserControl { get; set; }
        public Guid Id { get; set; } = new Guid("65da5c86-bedc-4c85-8ba7-c57b1c05d920");
        public Image? SmallImage { get; set; } = Resources.ffmpeg16x16;
        public Image? LargeImage { get; set; } = Resources.ffmpeg32x32;
        public string Title { get; set; } = "FF Tools";
        public AnalogyToolTip? ToolTip { get; set; }

        public Task InitializeUserControl(Control hostingControl, ILogger logger)
        {
            UserControl = new FFToolsUC(logger);
            return Task.CompletedTask;
        }

        public Task UserControlRemoved()
        {
            return Task.CompletedTask;
        }
    }
}