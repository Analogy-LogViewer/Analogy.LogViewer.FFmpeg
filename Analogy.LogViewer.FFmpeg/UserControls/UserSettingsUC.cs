using System;
using System.Drawing;
using System.Windows.Forms;
using Analogy.LogViewer.FFmpeg.Managers;

namespace Analogy.LogViewer.FFmpeg.UserControls
{
    public partial class UserSettingsUC : UserControl
    {
        public EncryptionLogic EncryptionLogic => Analogy.LogViewer.Intuitive.Container.Instance.EncryptionLogic;

        public UserSettingsUC()
        {
            InitializeComponent();
        }

        private void importPrivateKeyButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            string message = "Importing new private key may override current key and make log files unreadable. You may want to back up current key before proceed." +
                             "\r\n" + "Do you wish to proceed?";
            string caption = "Override current key warning";
            var result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (openFileDialog1.FileName != null)
                    {
                        bool importResult = EncryptionLogic.ImportPrivateKeyFromFile(openFileDialog1.FileName, true);
                        if (importResult == true)
                        {
                            feedbackLabel.ForeColor = Color.ForestGreen; ;
                            feedbackLabel.Text = "Key imported  successfully";
                            feedbackLabel.Visible = true;
                        }
                        else
                        {

                            feedbackLabel.ForeColor = Color.Red;
                            feedbackLabel.Text = "false";
                            feedbackLabel.Visible = true;
                        }
                    }
                }
            }
        }

        private void exportPairKeysButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                if (folderBrowserDialog1.SelectedPath != null)
                {
                    if (EncryptionLogic.GenerateAndExporKeyXMLToFileRSA(folderBrowserDialog1.SelectedPath))
                    {
                        feedbackLabel.ForeColor = Color.ForestGreen; ;
                        feedbackLabel.Text = "Keys generated successfully and exported to\r\n\"" + folderBrowserDialog1.SelectedPath + "\"";
                        feedbackLabel.Visible = true;
                    }
                    else
                    {
                        feedbackLabel.ForeColor = Color.Red;
                        feedbackLabel.Text = "Unable to generate and export keys";
                        feedbackLabel.Visible = true;
                    }
                }
            }
        }

        private void exportCurrentPublicKeyButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                if (folderBrowserDialog1.SelectedPath != null)
                {
                    if (EncryptionLogic.ExportCurrentKeyXMLToFileRSA(folderBrowserDialog1.SelectedPath, false))
                    {
                        feedbackLabel.ForeColor = Color.ForestGreen; ;
                        feedbackLabel.Text = "Public key exported successfully to\r\n \"" + folderBrowserDialog1.SelectedPath + "\"";
                        feedbackLabel.Visible = true;
                    }
                    else
                    {
                        feedbackLabel.ForeColor = Color.Red;
                        feedbackLabel.Text = "Failed to export public key";
                        feedbackLabel.Visible = true;
                    }
                }
            }
        }

        private void exportCurrPrivateKeysButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            string message = "Exporting a current private to file may compromise data security. Please do not leave it unprotected on the disk." +
                             "\r\n" + "Do you wish to proceed?";
            string caption = "Exporting current private key";
            var result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Warning);

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                if (folderBrowserDialog1.SelectedPath != null)
                {
                    if (EncryptionLogic.ExportCurrentKeyXMLToFileRSA(folderBrowserDialog1.SelectedPath, true) && result == DialogResult.OK)
                    {
                        feedbackLabel.ForeColor = Color.ForestGreen; ;
                        feedbackLabel.Text = "Private key exported successfully to\r\n\"" + folderBrowserDialog1.SelectedPath + "\"";
                        feedbackLabel.Visible = true;
                    }
                    else
                    {
                        feedbackLabel.ForeColor = Color.Red;
                        feedbackLabel.Text = "Failed to export private key";
                        feedbackLabel.Visible = true;
                    }
                }
            }
        }

        private void deleteKeyButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            string message = "You are about to delete current private key from CSP. Log files might become unreadable. You may want to back up current key before proceed." +
                             "\r\n" + "Do you wish to proceed?";
            string caption = "Delete current private key warning";
            var result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                if (EncryptionLogic.DeleteKeysFromContainerRSA())
                {
                    feedbackLabel.ForeColor = Color.ForestGreen; ;
                    feedbackLabel.Text = "Private key was deleted successfully. \r\n"
                                         + "The key is still in memory, please close the application \r\n to see it disappear totally.";
                    feedbackLabel.Visible = true;
                }
                else
                {
                    feedbackLabel.ForeColor = Color.Red;
                    feedbackLabel.Text = "Failed to delete private key";
                    feedbackLabel.Visible = true;
                }
            }
        }

        private void UserSettingsUC_Load(object sender, EventArgs e)
        {
            txtbFFmpegEXELocation.Text = UserSettingsManager.Instance.FFmpegBinaryFolder;
            tbPublishSocket.Text = UserSettingsManager.Instance.PublishPort;
            tbSubscribeSocket.Text = UserSettingsManager.Instance.SubscribePort;
            tbPublishSocket.TextChanged += (s, e) =>
            {
                UserSettingsManager.Instance.PublishPort = tbPublishSocket.Text;
                SaveSettings();
            };
            tbSubscribeSocket.TextChanged += (s, e) =>
            {
                UserSettingsManager.Instance.PublishPort = tbSubscribeSocket.Text;
                SaveSettings();
            };
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
