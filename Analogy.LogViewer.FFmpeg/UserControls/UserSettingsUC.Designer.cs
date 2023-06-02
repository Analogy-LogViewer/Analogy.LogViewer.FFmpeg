namespace Analogy.LogViewer.FFmpeg.UserControls
{
    partial class UserSettingsUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.feedbackLabel = new System.Windows.Forms.Label();
            this.deleteKeyButton = new System.Windows.Forms.Button();
            this.exportPairKeysButton = new System.Windows.Forms.Button();
            this.exportCurrPrivateKeysButton = new System.Windows.Forms.Button();
            this.exportCurrentPublicKeyButton = new System.Windows.Forms.Button();
            this.importPrivateKeyButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbSubscribeSocket = new System.Windows.Forms.TextBox();
            this.tbPublishSocket = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtbFFmpegEXELocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tnSelectVideo = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // feedbackLabel
            // 
            this.feedbackLabel.AutoSize = true;
            this.feedbackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.feedbackLabel.Location = new System.Drawing.Point(16, 23);
            this.feedbackLabel.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.feedbackLabel.Name = "feedbackLabel";
            this.feedbackLabel.Size = new System.Drawing.Size(147, 17);
            this.feedbackLabel.TabIndex = 2;
            this.feedbackLabel.Text = "Feedback message";
            this.feedbackLabel.Visible = false;
            // 
            // deleteKeyButton
            // 
            this.deleteKeyButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.deleteKeyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.deleteKeyButton.Location = new System.Drawing.Point(211, 196);
            this.deleteKeyButton.Margin = new System.Windows.Forms.Padding(26, 25, 26, 25);
            this.deleteKeyButton.Name = "deleteKeyButton";
            this.deleteKeyButton.Size = new System.Drawing.Size(312, 29);
            this.deleteKeyButton.TabIndex = 4;
            this.deleteKeyButton.Text = "Delete Private key from CSP";
            this.deleteKeyButton.UseVisualStyleBackColor = true;
            this.deleteKeyButton.Click += new System.EventHandler(this.deleteKeyButton_Click);
            // 
            // exportPairKeysButton
            // 
            this.exportPairKeysButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.exportPairKeysButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.exportPairKeysButton.Location = new System.Drawing.Point(211, 91);
            this.exportPairKeysButton.Margin = new System.Windows.Forms.Padding(26, 25, 26, 25);
            this.exportPairKeysButton.Name = "exportPairKeysButton";
            this.exportPairKeysButton.Size = new System.Drawing.Size(312, 29);
            this.exportPairKeysButton.TabIndex = 5;
            this.exportPairKeysButton.Text = "Generate and export a pair of keys";
            this.exportPairKeysButton.UseVisualStyleBackColor = true;
            this.exportPairKeysButton.Click += new System.EventHandler(this.exportPairKeysButton_Click);
            // 
            // exportCurrPrivateKeysButton
            // 
            this.exportCurrPrivateKeysButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.exportCurrPrivateKeysButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.exportCurrPrivateKeysButton.Location = new System.Drawing.Point(211, 161);
            this.exportCurrPrivateKeysButton.Margin = new System.Windows.Forms.Padding(26, 25, 26, 25);
            this.exportCurrPrivateKeysButton.Name = "exportCurrPrivateKeysButton";
            this.exportCurrPrivateKeysButton.Size = new System.Drawing.Size(312, 29);
            this.exportCurrPrivateKeysButton.TabIndex = 1;
            this.exportCurrPrivateKeysButton.Text = "Export current private key";
            this.exportCurrPrivateKeysButton.UseVisualStyleBackColor = true;
            this.exportCurrPrivateKeysButton.Click += new System.EventHandler(this.exportCurrPrivateKeysButton_Click);
            // 
            // exportCurrentPublicKeyButton
            // 
            this.exportCurrentPublicKeyButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.exportCurrentPublicKeyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.exportCurrentPublicKeyButton.Location = new System.Drawing.Point(211, 126);
            this.exportCurrentPublicKeyButton.Margin = new System.Windows.Forms.Padding(26, 25, 26, 25);
            this.exportCurrentPublicKeyButton.Name = "exportCurrentPublicKeyButton";
            this.exportCurrentPublicKeyButton.Size = new System.Drawing.Size(312, 29);
            this.exportCurrentPublicKeyButton.TabIndex = 3;
            this.exportCurrentPublicKeyButton.Text = "Export current public key";
            this.exportCurrentPublicKeyButton.UseVisualStyleBackColor = true;
            this.exportCurrentPublicKeyButton.Click += new System.EventHandler(this.exportCurrentPublicKeyButton_Click);
            // 
            // importPrivateKeyButton
            // 
            this.importPrivateKeyButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.importPrivateKeyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.importPrivateKeyButton.Location = new System.Drawing.Point(211, 56);
            this.importPrivateKeyButton.Margin = new System.Windows.Forms.Padding(26, 25, 26, 25);
            this.importPrivateKeyButton.Name = "importPrivateKeyButton";
            this.importPrivateKeyButton.Size = new System.Drawing.Size(312, 29);
            this.importPrivateKeyButton.TabIndex = 0;
            this.importPrivateKeyButton.Text = "Import Private key from file to CSP";
            this.importPrivateKeyButton.UseVisualStyleBackColor = true;
            this.importPrivateKeyButton.Click += new System.EventHandler(this.importPrivateKeyButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Choose folder to generate keys into";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(734, 422);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(726, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbSubscribeSocket);
            this.groupBox2.Controls.Add(this.tbPublishSocket);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(720, 146);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "IPC Settings";
            // 
            // tbSubscribeSocket
            // 
            this.tbSubscribeSocket.Location = new System.Drawing.Point(211, 17);
            this.tbSubscribeSocket.Name = "tbSubscribeSocket";
            this.tbSubscribeSocket.Size = new System.Drawing.Size(312, 22);
            this.tbSubscribeSocket.TabIndex = 3;
            // 
            // tbPublishSocket
            // 
            this.tbPublishSocket.Location = new System.Drawing.Point(211, 45);
            this.tbPublishSocket.Name = "tbPublishSocket";
            this.tbPublishSocket.Size = new System.Drawing.Size(312, 22);
            this.tbPublishSocket.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subscribe Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Publish Port:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.feedbackLabel);
            this.groupBox1.Controls.Add(this.deleteKeyButton);
            this.groupBox1.Controls.Add(this.importPrivateKeyButton);
            this.groupBox1.Controls.Add(this.exportCurrPrivateKeysButton);
            this.groupBox1.Controls.Add(this.exportCurrentPublicKeyButton);
            this.groupBox1.Controls.Add(this.exportPairKeysButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 241);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log Settings";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(726, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "FFmpeg/probe Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tnSelectVideo);
            this.groupBox3.Controls.Add(this.txtbFFmpegEXELocation);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(720, 53);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "FFProbe Settings";
            // 
            // txtbFFmpegEXELocation
            // 
            this.txtbFFmpegEXELocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbFFmpegEXELocation.Location = new System.Drawing.Point(211, 19);
            this.txtbFFmpegEXELocation.Name = "txtbFFmpegEXELocation";
            this.txtbFFmpegEXELocation.Size = new System.Drawing.Size(439, 22);
            this.txtbFFmpegEXELocation.TabIndex = 3;
            this.txtbFFmpegEXELocation.TextChanged += new System.EventHandler(this.txtbFFmpegEXELocation_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Executable Folder:";
            // 
            // tnSelectVideo
            // 
            this.tnSelectVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tnSelectVideo.Location = new System.Drawing.Point(657, 15);
            this.tnSelectVideo.Margin = new System.Windows.Forms.Padding(4);
            this.tnSelectVideo.Name = "tnSelectVideo";
            this.tnSelectVideo.Size = new System.Drawing.Size(56, 28);
            this.tnSelectVideo.TabIndex = 17;
            this.tnSelectVideo.Text = "...";
            this.tnSelectVideo.UseVisualStyleBackColor = true;
            this.tnSelectVideo.Click += new System.EventHandler(this.tnSelectVideo_Click);
            // 
            // UserSettingsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "UserSettingsUC";
            this.Size = new System.Drawing.Size(734, 422);
            this.Load += new System.EventHandler(this.UserSettingsUC_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label feedbackLabel;
        private System.Windows.Forms.Button deleteKeyButton;
        private System.Windows.Forms.Button exportPairKeysButton;
        private System.Windows.Forms.Button exportCurrPrivateKeysButton;
        private System.Windows.Forms.Button exportCurrentPublicKeyButton;
        private System.Windows.Forms.Button importPrivateKeyButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbSubscribeSocket;
        private System.Windows.Forms.TextBox tbPublishSocket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtbFFmpegEXELocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button tnSelectVideo;
    }
}
