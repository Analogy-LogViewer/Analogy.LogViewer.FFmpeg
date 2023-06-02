namespace Analogy.LogViewer.FFmpeg.UserControls
{
    partial class FFToolsUC
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpFFProbe = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtbPackets = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbStreams = new System.Windows.Forms.GroupBox();
            this.tcStreams = new System.Windows.Forms.TabControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbInfoDuration = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbInfoFormatStartTime = new System.Windows.Forms.TextBox();
            this.tbInfoFormatBitRate = new System.Windows.Forms.TextBox();
            this.lblInfoFormatStartTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbInfoFormatName = new System.Windows.Forms.TextBox();
            this.tbInfoFormatDuration = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbInfoFormatLongName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.tnSelectVideo = new System.Windows.Forms.Button();
            this.txtbVideoFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tpFFProbe.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbStreams.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpFFProbe);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1076, 655);
            this.tabControl1.TabIndex = 0;
            // 
            // tpFFProbe
            // 
            this.tpFFProbe.Controls.Add(this.tabControl2);
            this.tpFFProbe.Controls.Add(this.groupBox3);
            this.tpFFProbe.Location = new System.Drawing.Point(4, 25);
            this.tpFFProbe.Name = "tpFFProbe";
            this.tpFFProbe.Padding = new System.Windows.Forms.Padding(3);
            this.tpFFProbe.Size = new System.Drawing.Size(1068, 626);
            this.tpFFProbe.TabIndex = 0;
            this.tpFFProbe.Text = "FFProbe";
            this.tpFFProbe.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtbPackets);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(477, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(574, 532);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Packets";
            // 
            // rtbPackets
            // 
            this.rtbPackets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPackets.Location = new System.Drawing.Point(3, 18);
            this.rtbPackets.Name = "rtbPackets";
            this.rtbPackets.Size = new System.Drawing.Size(568, 511);
            this.rtbPackets.TabIndex = 0;
            this.rtbPackets.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 532);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gbStreams);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 197);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(468, 332);
            this.panel2.TabIndex = 15;
            // 
            // gbStreams
            // 
            this.gbStreams.Controls.Add(this.tcStreams);
            this.gbStreams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbStreams.Location = new System.Drawing.Point(0, 0);
            this.gbStreams.Name = "gbStreams";
            this.gbStreams.Size = new System.Drawing.Size(468, 332);
            this.gbStreams.TabIndex = 0;
            this.gbStreams.TabStop = false;
            this.gbStreams.Text = "Streams";
            // 
            // tcStreams
            // 
            this.tcStreams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcStreams.Location = new System.Drawing.Point(3, 18);
            this.tcStreams.Name = "tcStreams";
            this.tcStreams.SelectedIndex = 0;
            this.tcStreams.Size = new System.Drawing.Size(462, 311);
            this.tcStreams.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbInfoDuration);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbInfoFormatStartTime);
            this.panel1.Controls.Add(this.tbInfoFormatBitRate);
            this.panel1.Controls.Add(this.lblInfoFormatStartTime);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbInfoFormatName);
            this.panel1.Controls.Add(this.tbInfoFormatDuration);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbInfoFormatLongName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 179);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Duration:";
            // 
            // tbInfoDuration
            // 
            this.tbInfoDuration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInfoDuration.Location = new System.Drawing.Point(165, 8);
            this.tbInfoDuration.Name = "tbInfoDuration";
            this.tbInfoDuration.Size = new System.Drawing.Size(286, 22);
            this.tbInfoDuration.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Format BitRate:";
            // 
            // tbInfoFormatStartTime
            // 
            this.tbInfoFormatStartTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInfoFormatStartTime.Location = new System.Drawing.Point(165, 36);
            this.tbInfoFormatStartTime.Name = "tbInfoFormatStartTime";
            this.tbInfoFormatStartTime.Size = new System.Drawing.Size(286, 22);
            this.tbInfoFormatStartTime.TabIndex = 11;
            // 
            // tbInfoFormatBitRate
            // 
            this.tbInfoFormatBitRate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInfoFormatBitRate.Location = new System.Drawing.Point(165, 151);
            this.tbInfoFormatBitRate.Name = "tbInfoFormatBitRate";
            this.tbInfoFormatBitRate.Size = new System.Drawing.Size(286, 22);
            this.tbInfoFormatBitRate.TabIndex = 3;
            // 
            // lblInfoFormatStartTime
            // 
            this.lblInfoFormatStartTime.AutoSize = true;
            this.lblInfoFormatStartTime.Location = new System.Drawing.Point(13, 39);
            this.lblInfoFormatStartTime.Name = "lblInfoFormatStartTime";
            this.lblInfoFormatStartTime.Size = new System.Drawing.Size(116, 16);
            this.lblInfoFormatStartTime.TabIndex = 10;
            this.lblInfoFormatStartTime.Text = "Format Start Time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Format Duration:";
            // 
            // tbInfoFormatName
            // 
            this.tbInfoFormatName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInfoFormatName.Location = new System.Drawing.Point(165, 120);
            this.tbInfoFormatName.Name = "tbInfoFormatName";
            this.tbInfoFormatName.Size = new System.Drawing.Size(286, 22);
            this.tbInfoFormatName.TabIndex = 9;
            // 
            // tbInfoFormatDuration
            // 
            this.tbInfoFormatDuration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInfoFormatDuration.Location = new System.Drawing.Point(165, 64);
            this.tbInfoFormatDuration.Name = "tbInfoFormatDuration";
            this.tbInfoFormatDuration.Size = new System.Drawing.Size(286, 22);
            this.tbInfoFormatDuration.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Format Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Format Long Name:";
            // 
            // tbInfoFormatLongName
            // 
            this.tbInfoFormatLongName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInfoFormatLongName.Location = new System.Drawing.Point(165, 92);
            this.tbInfoFormatLongName.Name = "tbInfoFormatLongName";
            this.tbInfoFormatLongName.Size = new System.Drawing.Size(286, 22);
            this.tbInfoFormatLongName.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPlay);
            this.groupBox3.Controls.Add(this.btnAnalyze);
            this.groupBox3.Controls.Add(this.tnSelectVideo);
            this.groupBox3.Controls.Add(this.txtbVideoFile);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1062, 53);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Input Video File";
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlay.Location = new System.Drawing.Point(987, 15);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(68, 28);
            this.btnPlay.TabIndex = 18;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnalyze.Location = new System.Drawing.Point(880, 15);
            this.btnAnalyze.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(100, 28);
            this.btnAnalyze.TabIndex = 17;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // tnSelectVideo
            // 
            this.tnSelectVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tnSelectVideo.Location = new System.Drawing.Point(818, 15);
            this.tnSelectVideo.Margin = new System.Windows.Forms.Padding(4);
            this.tnSelectVideo.Name = "tnSelectVideo";
            this.tnSelectVideo.Size = new System.Drawing.Size(56, 28);
            this.tnSelectVideo.TabIndex = 16;
            this.tnSelectVideo.Text = "...";
            this.tnSelectVideo.UseVisualStyleBackColor = true;
            this.tnSelectVideo.Click += new System.EventHandler(this.tnSelectVideo_Click);
            // 
            // txtbVideoFile
            // 
            this.txtbVideoFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbVideoFile.Location = new System.Drawing.Point(76, 19);
            this.txtbVideoFile.Name = "txtbVideoFile";
            this.txtbVideoFile.Size = new System.Drawing.Size(735, 22);
            this.txtbVideoFile.TabIndex = 3;
            this.txtbVideoFile.TextChanged += new System.EventHandler(this.txtbVideoFile_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "File:";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 56);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1062, 567);
            this.tabControl2.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1054, 538);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1054, 538);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Play";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FFToolsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "FFToolsUC";
            this.Size = new System.Drawing.Size(1076, 655);
            this.Load += new System.EventHandler(this.FFToolsUC_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpFFProbe.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gbStreams.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpFFProbe;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtbVideoFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Button tnSelectVideo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbInfoDuration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbInfoFormatStartTime;
        private System.Windows.Forms.Label lblInfoFormatStartTime;
        private System.Windows.Forms.TextBox tbInfoFormatName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbInfoFormatLongName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbInfoFormatDuration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbInfoFormatBitRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tcStreams;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gbStreams;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtbPackets;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}
