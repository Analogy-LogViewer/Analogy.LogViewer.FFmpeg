using System;
using System.Collections.Generic;
using System.Drawing;
using Analogy.Interfaces;
using Analogy.Interfaces.DataTypes;
using Analogy.Interfaces.Factories;
using Analogy.LogViewer.FFmpeg.Properties;
using Analogy.LogViewer.Template.Managers;

namespace Analogy.LogViewer.FFmpeg.IAnalogy
{
    public class FFmpegActionsFactory : IAnalogyCustomActionsFactory
    {
        public Guid FactoryId { get; set; } = FFmpegFactories.Id;
        public string Title { get; set; } = "FFmpeg Tools";

        public IEnumerable<IAnalogyCustomAction> Actions { get; } = new List<IAnalogyCustomAction>
        {
            //new Action1()
        };

        private class Action1 : IAnalogyCustomAction
        {

            public Action Action { get; } = () =>
            {
               
            };

            public Guid Id { get; set; } = new Guid("b6c5410d-5ef5-4b1c-84f1-0dcd7eac3966");
            public Image SmallImage { get; set; } = Resources.ffmpeg16x16;
            public Image LargeImage { get; set; } = Resources.ffmpeg32x32;
            public string Title { get; set; } = "Kalpa Hosting";
            public AnalogyCustomActionType Type { get; } = AnalogyCustomActionType.BelongsToProvider;
            public AnalogyToolTip? ToolTip { get; set; }
        }
        
    }
}