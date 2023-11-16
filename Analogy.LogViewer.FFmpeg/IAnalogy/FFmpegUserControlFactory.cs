using Analogy.Interfaces;
using Analogy.Interfaces.Factories;
using System;
using System.Collections.Generic;

namespace Analogy.LogViewer.FFmpeg.IAnalogy
{
    internal class FFmpegUserControlFactory : IAnalogyCustomUserControlsFactory
    {
        public Guid FactoryId { get; set; } = FFmpegFactories.Id;
        public string Title { get; set; } = "FFmpeg User Controls";

        public IEnumerable<IAnalogyCustomUserControl> UserControls { get; } = new List<IAnalogyCustomUserControl>
        {
            new FFTools(),
        };
    }
}