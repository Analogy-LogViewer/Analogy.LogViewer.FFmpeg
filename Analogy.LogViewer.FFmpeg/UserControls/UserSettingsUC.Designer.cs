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
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage2 = new System.Windows.Forms.TabPage();
            groupBox3 = new System.Windows.Forms.GroupBox();
            tnSelectVideo = new System.Windows.Forms.Button();
            txtbFFmpegEXELocation = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // folderBrowserDialog1
            // 
            folderBrowserDialog1.Description = "Choose folder to generate keys into";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(734, 528);
            tabControl1.TabIndex = 8;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Location = new System.Drawing.Point(4, 29);
            tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabPage2.Size = new System.Drawing.Size(726, 495);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "FFmpeg/probe Settings";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tnSelectVideo);
            groupBox3.Controls.Add(txtbFFmpegEXELocation);
            groupBox3.Controls.Add(label3);
            groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox3.Location = new System.Drawing.Point(3, 4);
            groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox3.Size = new System.Drawing.Size(720, 66);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "FFProbe Settings";
            // 
            // tnSelectVideo
            // 
            tnSelectVideo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            tnSelectVideo.Location = new System.Drawing.Point(657, 19);
            tnSelectVideo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tnSelectVideo.Name = "tnSelectVideo";
            tnSelectVideo.Size = new System.Drawing.Size(56, 35);
            tnSelectVideo.TabIndex = 17;
            tnSelectVideo.Text = "...";
            tnSelectVideo.UseVisualStyleBackColor = true;
            tnSelectVideo.Click += tnSelectVideo_Click;
            // 
            // txtbFFmpegEXELocation
            // 
            txtbFFmpegEXELocation.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtbFFmpegEXELocation.Location = new System.Drawing.Point(211, 24);
            txtbFFmpegEXELocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtbFFmpegEXELocation.Name = "txtbFFmpegEXELocation";
            txtbFFmpegEXELocation.Size = new System.Drawing.Size(439, 27);
            txtbFFmpegEXELocation.TabIndex = 3;
            txtbFFmpegEXELocation.TextChanged += txtbFFmpegEXELocation_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(16, 26);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(130, 20);
            label3.TabIndex = 1;
            label3.Text = "Executable Folder:";
            // 
            // UserSettingsUC
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "UserSettingsUC";
            Size = new System.Drawing.Size(734, 528);
            Load += UserSettingsUC_Load;
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtbFFmpegEXELocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button tnSelectVideo;
    }
}
