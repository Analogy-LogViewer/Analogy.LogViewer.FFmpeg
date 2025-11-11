using Analogy.Interfaces;
using Analogy.Interfaces.Factories;
using Analogy.Interfaces.WinForms;
using Analogy.Interfaces.WinForms.Factories;
using System;
using System.Collections.Generic;

namespace Analogy.LogViewer.FFmpeg.IAnalogy
{
    internal class FFmpegUserControlFactory : IAnalogyCustomUserControlsFactoryWinForms
    {
        public Guid FactoryId { get; set; } = FFmpegFactories.Id;
        public string Title { get; set; } = "FFmpeg User Controls";

        public IEnumerable<IAnalogyCustomUserControlWinForms> UserControls { get; } = new List<IAnalogyCustomUserControlWinForms>
        {
            new FFTools(),
        };
    }
}