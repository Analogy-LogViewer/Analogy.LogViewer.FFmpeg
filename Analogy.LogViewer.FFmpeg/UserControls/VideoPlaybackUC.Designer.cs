
namespace Analogy.LogViewer.FFmpeg.UserControls
{
    partial class VideoPlaybackUC
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoPlaybackUC));
            this.videoView1 = new LibVLCSharp.WinForms.VideoView();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barVideoTop = new DevExpress.XtraBars.Bar();
            this.bbiOpenVideo = new DevExpress.XtraBars.BarButtonItem();
            this.bbiVideoAnnotation = new DevExpress.XtraBars.BarButtonItem();
            this.barBottom = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelVideoPlayback = new DevExpress.XtraEditors.PanelControl();
            this.lblplaybackTime = new DevExpress.XtraEditors.LabelControl();
            this.tbTime = new DevExpress.XtraEditors.TrackBarControl();
            this.sbtnStop = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnPlayback = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.videoView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelVideoPlayback)).BeginInit();
            this.panelVideoPlayback.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // videoView1
            // 
            this.videoView1.BackColor = System.Drawing.Color.Black;
            this.videoView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoView1.Location = new System.Drawing.Point(2, 2);
            this.videoView1.Margin = new System.Windows.Forms.Padding(4);
            this.videoView1.MediaPlayer = null;
            this.videoView1.Name = "videoView1";
            this.videoView1.Size = new System.Drawing.Size(1310, 703);
            this.videoView1.TabIndex = 1;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barVideoTop,
            this.barBottom});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiOpenVideo,
            this.bbiVideoAnnotation});
            this.barManager1.MainMenu = this.barVideoTop;
            this.barManager1.MaxItemId = 2;
            this.barManager1.StatusBar = this.barBottom;
            // 
            // barVideoTop
            // 
            this.barVideoTop.BarName = "Main menu";
            this.barVideoTop.DockCol = 0;
            this.barVideoTop.DockRow = 0;
            this.barVideoTop.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barVideoTop.FloatLocation = new System.Drawing.Point(300, 124);
            this.barVideoTop.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiOpenVideo),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiVideoAnnotation)});
            this.barVideoTop.OptionsBar.AllowQuickCustomization = false;
            this.barVideoTop.OptionsBar.MultiLine = true;
            this.barVideoTop.OptionsBar.UseWholeRow = true;
            this.barVideoTop.Text = "Main menu";
            // 
            // bbiOpenVideo
            // 
            this.bbiOpenVideo.Caption = "Open File";
            this.bbiOpenVideo.Id = 0;
            this.bbiOpenVideo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiOpenVideo.ImageOptions.Image")));
            this.bbiOpenVideo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiOpenVideo.ImageOptions.LargeImage")));
            this.bbiOpenVideo.Name = "bbiOpenVideo";
            this.bbiOpenVideo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bbiVideoAnnotation
            // 
            this.bbiVideoAnnotation.Caption = "Video Annotations";
            this.bbiVideoAnnotation.Id = 1;
            this.bbiVideoAnnotation.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiVideoAnnotation.ImageOptions.Image")));
            this.bbiVideoAnnotation.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiVideoAnnotation.ImageOptions.LargeImage")));
            this.bbiVideoAnnotation.Name = "bbiVideoAnnotation";
            this.bbiVideoAnnotation.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barBottom
            // 
            this.barBottom.BarName = "Status bar";
            this.barBottom.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.barBottom.DockCol = 0;
            this.barBottom.DockRow = 0;
            this.barBottom.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.barBottom.OptionsBar.AllowQuickCustomization = false;
            this.barBottom.OptionsBar.DrawDragBorder = false;
            this.barBottom.OptionsBar.UseWholeRow = true;
            this.barBottom.Text = "Status bar";
            this.barBottom.Visible = false;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1314, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 809);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1314, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 779);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1314, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 779);
            // 
            // panelVideoPlayback
            // 
            this.panelVideoPlayback.Controls.Add(this.lblplaybackTime);
            this.panelVideoPlayback.Controls.Add(this.tbTime);
            this.panelVideoPlayback.Controls.Add(this.sbtnStop);
            this.panelVideoPlayback.Controls.Add(this.sbtnPlayback);
            this.panelVideoPlayback.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelVideoPlayback.Location = new System.Drawing.Point(0, 737);
            this.panelVideoPlayback.Name = "panelVideoPlayback";
            this.panelVideoPlayback.Size = new System.Drawing.Size(1314, 72);
            this.panelVideoPlayback.TabIndex = 2;
            // 
            // lblplaybackTime
            // 
            this.lblplaybackTime.Location = new System.Drawing.Point(93, 30);
            this.lblplaybackTime.Name = "lblplaybackTime";
            this.lblplaybackTime.Size = new System.Drawing.Size(71, 16);
            this.lblplaybackTime.TabIndex = 3;
            this.lblplaybackTime.Text = "00:00-00:00";
            // 
            // tbTime
            // 
            this.tbTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTime.EditValue = null;
            this.tbTime.Location = new System.Drawing.Point(289, 7);
            this.tbTime.MenuManager = this.barManager1;
            this.tbTime.Name = "tbTime";
            this.tbTime.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.tbTime.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tbTime.Properties.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbTime.Size = new System.Drawing.Size(1019, 56);
            this.tbTime.TabIndex = 2;
            // 
            // sbtnStop
            // 
            this.sbtnStop.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sbtnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sbtnStop.Enabled = false;
            this.sbtnStop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnStop.ImageOptions.Image")));
            this.sbtnStop.Location = new System.Drawing.Point(49, 17);
            this.sbtnStop.Name = "sbtnStop";
            this.sbtnStop.Size = new System.Drawing.Size(38, 38);
            this.sbtnStop.TabIndex = 1;
            // 
            // sbtnPlayback
            // 
            this.sbtnPlayback.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sbtnPlayback.Enabled = false;
            this.sbtnPlayback.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnPlayback.ImageOptions.Image")));
            this.sbtnPlayback.Location = new System.Drawing.Point(5, 17);
            this.sbtnPlayback.Name = "sbtnPlayback";
            this.sbtnPlayback.Size = new System.Drawing.Size(38, 38);
            this.sbtnPlayback.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.videoView1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 30);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1314, 707);
            this.panelControl1.TabIndex = 5;
            // 
            // VideoPlaybackUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelVideoPlayback);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "VideoPlaybackUC";
            this.Size = new System.Drawing.Size(1314, 829);
            this.Load += new System.EventHandler(this.VideoPlaybackUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.videoView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelVideoPlayback)).EndInit();
            this.panelVideoPlayback.ResumeLayout(false);
            this.panelVideoPlayback.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibVLCSharp.WinForms.VideoView videoView1;
        private DevExpress.XtraEditors.PanelControl panelVideoPlayback;
        private DevExpress.XtraEditors.SimpleButton sbtnPlayback;
        private DevExpress.XtraEditors.SimpleButton sbtnStop;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar barVideoTop;
        private DevExpress.XtraBars.Bar barBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.TrackBarControl tbTime;
        private DevExpress.XtraBars.BarButtonItem bbiOpenVideo;
        private DevExpress.XtraBars.BarButtonItem bbiVideoAnnotation;
        private DevExpress.XtraEditors.LabelControl lblplaybackTime;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}
