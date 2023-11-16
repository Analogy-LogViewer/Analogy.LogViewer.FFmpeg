using Analogy.LogViewer.FFmpeg.Managers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Analogy.LogViewer.FFmpeg.UserControls
{
    public partial class UserSettingsUC : UserControl
    {
        public UserSettingsUC()
        {
            InitializeComponent();
        }

        private void UserSettingsUC_Load(object sender, EventArgs e)
        {
            txtbFFmpegEXELocation.Text = UserSettingsManager.Instance.FFmpegBinaryFolder;
        }

        private void SaveSettings()
        {
            UserSettingsManager.Instance.Save();
        }

        private void tnSelectVideo_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog() { ShowNewFolderButton = false })
            {
                DialogResult result = folderBrowserDialog.ShowDialog(); // Show the dialog.
                if (result == DialogResult.OK) // Test result.
                {
                    txtbFFmpegEXELocation.Text = UserSettingsManager.Instance.FFmpegBinaryFolder = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void txtbFFmpegEXELocation_TextChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }
    }
}