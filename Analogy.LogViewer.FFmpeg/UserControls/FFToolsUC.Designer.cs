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
            tabControl1 = new System.Windows.Forms.TabControl();
            tpFFProbe = new System.Windows.Forms.TabPage();
            tabControl2 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            groupBox2 = new System.Windows.Forms.GroupBox();
            rtbPackets = new System.Windows.Forms.RichTextBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            panel2 = new System.Windows.Forms.Panel();
            gbStreams = new System.Windows.Forms.GroupBox();
            tcStreams = new System.Windows.Forms.TabControl();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            tbInfoDuration = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            tbInfoFormatStartTime = new System.Windows.Forms.TextBox();
            tbInfoFormatBitRate = new System.Windows.Forms.TextBox();
            lblInfoFormatStartTime = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            tbInfoFormatName = new System.Windows.Forms.TextBox();
            tbInfoFormatDuration = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            tbInfoFormatLongName = new System.Windows.Forms.TextBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            btnAnalyze = new System.Windows.Forms.Button();
            tnSelectVideo = new System.Windows.Forms.Button();
            txtbVideoFile = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            tabControl1.SuspendLayout();
            tpFFProbe.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            gbStreams.SuspendLayout();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpFFProbe);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(1076, 819);
            tabControl1.TabIndex = 0;
            // 
            // tpFFProbe
            // 
            tpFFProbe.Controls.Add(tabControl2);
            tpFFProbe.Controls.Add(groupBox3);
            tpFFProbe.Location = new System.Drawing.Point(4, 29);
            tpFFProbe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tpFFProbe.Name = "tpFFProbe";
            tpFFProbe.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tpFFProbe.Size = new System.Drawing.Size(1068, 786);
            tpFFProbe.TabIndex = 0;
            tpFFProbe.Text = "FFProbe";
            tpFFProbe.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage1);
            tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl2.Location = new System.Drawing.Point(3, 70);
            tabControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new System.Drawing.Size(1062, 712);
            tabControl2.TabIndex = 13;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new System.Drawing.Point(4, 29);
            tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabPage1.Size = new System.Drawing.Size(1054, 679);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Info";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rtbPackets);
            groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox2.Location = new System.Drawing.Point(477, 4);
            groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox2.Size = new System.Drawing.Size(574, 671);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Packets";
            // 
            // rtbPackets
            // 
            rtbPackets.Dock = System.Windows.Forms.DockStyle.Fill;
            rtbPackets.Location = new System.Drawing.Point(3, 24);
            rtbPackets.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            rtbPackets.Name = "rtbPackets";
            rtbPackets.Size = new System.Drawing.Size(568, 643);
            rtbPackets.TabIndex = 0;
            rtbPackets.Text = "";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(panel1);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            groupBox1.Location = new System.Drawing.Point(3, 4);
            groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox1.Size = new System.Drawing.Size(474, 671);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Info";
            // 
            // panel2
            // 
            panel2.Controls.Add(gbStreams);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(3, 248);
            panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(468, 419);
            panel2.TabIndex = 15;
            // 
            // gbStreams
            // 
            gbStreams.Controls.Add(tcStreams);
            gbStreams.Dock = System.Windows.Forms.DockStyle.Fill;
            gbStreams.Location = new System.Drawing.Point(0, 0);
            gbStreams.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gbStreams.Name = "gbStreams";
            gbStreams.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gbStreams.Size = new System.Drawing.Size(468, 419);
            gbStreams.TabIndex = 0;
            gbStreams.TabStop = false;
            gbStreams.Text = "Streams";
            // 
            // tcStreams
            // 
            tcStreams.Dock = System.Windows.Forms.DockStyle.Fill;
            tcStreams.Location = new System.Drawing.Point(3, 24);
            tcStreams.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tcStreams.Name = "tcStreams";
            tcStreams.SelectedIndex = 0;
            tcStreams.Size = new System.Drawing.Size(462, 391);
            tcStreams.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tbInfoDuration);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tbInfoFormatStartTime);
            panel1.Controls.Add(tbInfoFormatBitRate);
            panel1.Controls.Add(lblInfoFormatStartTime);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(tbInfoFormatName);
            panel1.Controls.Add(tbInfoFormatDuration);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tbInfoFormatLongName);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(3, 24);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(468, 224);
            panel1.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(13, 14);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "Duration:";
            // 
            // tbInfoDuration
            // 
            tbInfoDuration.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbInfoDuration.Location = new System.Drawing.Point(165, 10);
            tbInfoDuration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbInfoDuration.Name = "tbInfoDuration";
            tbInfoDuration.Size = new System.Drawing.Size(286, 27);
            tbInfoDuration.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(13, 192);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(111, 20);
            label2.TabIndex = 2;
            label2.Text = "Format BitRate:";
            // 
            // tbInfoFormatStartTime
            // 
            tbInfoFormatStartTime.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbInfoFormatStartTime.Location = new System.Drawing.Point(165, 45);
            tbInfoFormatStartTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbInfoFormatStartTime.Name = "tbInfoFormatStartTime";
            tbInfoFormatStartTime.Size = new System.Drawing.Size(286, 27);
            tbInfoFormatStartTime.TabIndex = 11;
            // 
            // tbInfoFormatBitRate
            // 
            tbInfoFormatBitRate.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbInfoFormatBitRate.Location = new System.Drawing.Point(165, 189);
            tbInfoFormatBitRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbInfoFormatBitRate.Name = "tbInfoFormatBitRate";
            tbInfoFormatBitRate.Size = new System.Drawing.Size(286, 27);
            tbInfoFormatBitRate.TabIndex = 3;
            // 
            // lblInfoFormatStartTime
            // 
            lblInfoFormatStartTime.AutoSize = true;
            lblInfoFormatStartTime.Location = new System.Drawing.Point(13, 49);
            lblInfoFormatStartTime.Name = "lblInfoFormatStartTime";
            lblInfoFormatStartTime.Size = new System.Drawing.Size(131, 20);
            lblInfoFormatStartTime.TabIndex = 10;
            lblInfoFormatStartTime.Text = "Format Start Time:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(13, 84);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(121, 20);
            label5.TabIndex = 4;
            label5.Text = "Format Duration:";
            // 
            // tbInfoFormatName
            // 
            tbInfoFormatName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbInfoFormatName.Location = new System.Drawing.Point(165, 150);
            tbInfoFormatName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbInfoFormatName.Name = "tbInfoFormatName";
            tbInfoFormatName.Size = new System.Drawing.Size(286, 27);
            tbInfoFormatName.TabIndex = 9;
            // 
            // tbInfoFormatDuration
            // 
            tbInfoFormatDuration.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbInfoFormatDuration.Location = new System.Drawing.Point(165, 80);
            tbInfoFormatDuration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbInfoFormatDuration.Name = "tbInfoFormatDuration";
            tbInfoFormatDuration.Size = new System.Drawing.Size(286, 27);
            tbInfoFormatDuration.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(13, 154);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(103, 20);
            label9.TabIndex = 8;
            label9.Text = "Format Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(13, 119);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(140, 20);
            label4.TabIndex = 6;
            label4.Text = "Format Long Name:";
            // 
            // tbInfoFormatLongName
            // 
            tbInfoFormatLongName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbInfoFormatLongName.Location = new System.Drawing.Point(165, 115);
            tbInfoFormatLongName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbInfoFormatLongName.Name = "tbInfoFormatLongName";
            tbInfoFormatLongName.Size = new System.Drawing.Size(286, 27);
            tbInfoFormatLongName.TabIndex = 7;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnAnalyze);
            groupBox3.Controls.Add(tnSelectVideo);
            groupBox3.Controls.Add(txtbVideoFile);
            groupBox3.Controls.Add(label3);
            groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox3.Location = new System.Drawing.Point(3, 4);
            groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox3.Size = new System.Drawing.Size(1062, 66);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Input Video File";
            // 
            // btnAnalyze
            // 
            btnAnalyze.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnAnalyze.Location = new System.Drawing.Point(952, 19);
            btnAnalyze.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnAnalyze.Name = "btnAnalyze";
            btnAnalyze.Size = new System.Drawing.Size(100, 35);
            btnAnalyze.TabIndex = 17;
            btnAnalyze.Text = "Analyze";
            btnAnalyze.UseVisualStyleBackColor = true;
            btnAnalyze.Click += btnAnalyze_Click;
            // 
            // tnSelectVideo
            // 
            tnSelectVideo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            tnSelectVideo.Location = new System.Drawing.Point(888, 19);
            tnSelectVideo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tnSelectVideo.Name = "tnSelectVideo";
            tnSelectVideo.Size = new System.Drawing.Size(56, 35);
            tnSelectVideo.TabIndex = 16;
            tnSelectVideo.Text = "...";
            tnSelectVideo.UseVisualStyleBackColor = true;
            tnSelectVideo.Click += tnSelectVideo_Click;
            // 
            // txtbVideoFile
            // 
            txtbVideoFile.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtbVideoFile.Location = new System.Drawing.Point(76, 24);
            txtbVideoFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtbVideoFile.Name = "txtbVideoFile";
            txtbVideoFile.Size = new System.Drawing.Size(805, 27);
            txtbVideoFile.TabIndex = 3;
            txtbVideoFile.TextChanged += txtbVideoFile_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(16, 28);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(35, 20);
            label3.TabIndex = 1;
            label3.Text = "File:";
            // 
            // FFToolsUC
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "FFToolsUC";
            Size = new System.Drawing.Size(1076, 819);
            Load += FFToolsUC_Load;
            tabControl1.ResumeLayout(false);
            tpFFProbe.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            gbStreams.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
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
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
    }
}
