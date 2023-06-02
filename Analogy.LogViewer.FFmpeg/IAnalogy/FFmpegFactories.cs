using System;
using System.Collections.Generic;
using System.Drawing;
using Analogy.Interfaces;
using Analogy.LogViewer.FFmpeg.Properties;
using Analogy.LogViewer.Template;

namespace Analogy.LogViewer.FFmpeg.IAnalogy
{
    public class FFmpegFactories : PrimaryFactory
    {
        internal static Guid Id = new Guid("5d82cf23-bc2b-4ca7-a18c-19cd9b27dd30");
        public override Guid FactoryId { get; set; } = Id;
        public override string Title { get; set; } = "FFmpeg";
        public override Image SmallImage { get; set; } = Resources.Intuitive16x16;
        public override Image LargeImage { get; set; } = Resources.Intuitive32x32;
        public override IEnumerable<IAnalogyChangeLog> ChangeLog { get; set; } = GetChangeLog();
        public override IEnumerable<string> Contributors { get; set; } = new List<string> { "Lior Banai" };
        public override string About { get; set; } = "Intuitive Log Parsers";

        private static IEnumerable<IAnalogyChangeLog> GetChangeLog()
        {
            yield return new AnalogyChangeLog("Initial version", AnalogChangeLogType.None, "Lior Banai", new DateTime(2022, 07, 15));
        }
    }

    public class DataSourceFactory : DataProvidersFactory
    {
        public override Guid FactoryId { get; set; } = FFmpegFactories.Id;
        public override string Title { get; set; } = "Intuitive Logs";

        public override IEnumerable<IAnalogyDataProvider> DataProviders { get; set; } = new List<IAnalogyDataProvider>
        {

        };
    }
}
