namespace MusicPlayer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playBar = new System.Windows.Forms.ProgressBar();
            this.playBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.songLabel = new System.Windows.Forms.Label();
            this.albumLabel = new System.Windows.Forms.Label();
            this.artistLabel = new System.Windows.Forms.Label();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.endTime = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.shuffleBtn = new System.Windows.Forms.Button();
            this.startTime = new System.Windows.Forms.Label();
            this.loopBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.forwardBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.fileBtn = new System.Windows.Forms.Button();
            this.songImage = new System.Windows.Forms.PictureBox();
            this.trackList = new System.Windows.Forms.ListBox();
            this.topBar = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.currentSongLabel = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topBar)).BeginInit();
            this.SuspendLayout();
            // 
            // playBar
            // 
            this.playBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.playBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.playBar.Location = new System.Drawing.Point(43, 45);
            this.playBar.MarqueeAnimationSpeed = 10;
            this.playBar.Maximum = 1000;
            this.playBar.Name = "playBar";
            this.playBar.Size = new System.Drawing.Size(775, 11);
            this.playBar.TabIndex = 0;
            this.playBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.playBar_MouseDown);
            // 
            // playBtn
            // 
            this.playBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playBtn.Font = new System.Drawing.Font("Iosevka Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playBtn.ForeColor = System.Drawing.Color.White;
            this.playBtn.Location = new System.Drawing.Point(371, 70);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(94, 35);
            this.playBtn.TabIndex = 1;
            this.playBtn.Text = "Play/Pause";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.songLabel);
            this.panel1.Controls.Add(this.albumLabel);
            this.panel1.Controls.Add(this.artistLabel);
            this.panel1.Controls.Add(this.volumeLabel);
            this.panel1.Controls.Add(this.endTime);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.playBar);
            this.panel1.Controls.Add(this.shuffleBtn);
            this.panel1.Controls.Add(this.startTime);
            this.panel1.Controls.Add(this.loopBtn);
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.forwardBtn);
            this.panel1.Controls.Add(this.playBtn);
            this.panel1.Location = new System.Drawing.Point(-14, 360);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 120);
            this.panel1.TabIndex = 2;
            // 
            // songLabel
            // 
            this.songLabel.Font = new System.Drawing.Font("Iosevka Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.songLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.songLabel.Location = new System.Drawing.Point(19, 97);
            this.songLabel.Name = "songLabel";
            this.songLabel.Size = new System.Drawing.Size(146, 15);
            this.songLabel.TabIndex = 16;
            this.songLabel.Text = "Deer Dance";
            // 
            // albumLabel
            // 
            this.albumLabel.Font = new System.Drawing.Font("Iosevka Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.albumLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.albumLabel.Location = new System.Drawing.Point(19, 80);
            this.albumLabel.Name = "albumLabel";
            this.albumLabel.Size = new System.Drawing.Size(146, 15);
            this.albumLabel.TabIndex = 15;
            this.albumLabel.Text = "Toxicity";
            // 
            // artistLabel
            // 
            this.artistLabel.Font = new System.Drawing.Font("Iosevka Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.artistLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.artistLabel.Location = new System.Drawing.Point(19, 62);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(146, 15);
            this.artistLabel.TabIndex = 14;
            this.artistLabel.Text = "System Of A Down";
            // 
            // volumeLabel
            // 
            this.volumeLabel.AutoSize = true;
            this.volumeLabel.Font = new System.Drawing.Font("Iosevka Extended", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.volumeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.volumeLabel.Location = new System.Drawing.Point(723, 91);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(35, 14);
            this.volumeLabel.TabIndex = 13;
            this.volumeLabel.Text = "100%";
            // 
            // endTime
            // 
            this.endTime.AutoSize = true;
            this.endTime.Font = new System.Drawing.Font("Iosevka Extended", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.endTime.ForeColor = System.Drawing.SystemColors.Control;
            this.endTime.Location = new System.Drawing.Point(723, 8);
            this.endTime.Name = "endTime";
            this.endTime.Size = new System.Drawing.Size(95, 34);
            this.endTime.TabIndex = 12;
            this.endTime.Text = "00:00";
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.trackBar1.Location = new System.Drawing.Point(671, 62);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(138, 45);
            this.trackBar1.TabIndex = 10;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // shuffleBtn
            // 
            this.shuffleBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shuffleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shuffleBtn.Font = new System.Drawing.Font("Iosevka Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shuffleBtn.ForeColor = System.Drawing.Color.White;
            this.shuffleBtn.Location = new System.Drawing.Point(171, 70);
            this.shuffleBtn.Name = "shuffleBtn";
            this.shuffleBtn.Size = new System.Drawing.Size(94, 35);
            this.shuffleBtn.TabIndex = 5;
            this.shuffleBtn.Text = "Shuffle";
            this.shuffleBtn.UseVisualStyleBackColor = true;
            this.shuffleBtn.Click += new System.EventHandler(this.shuffleBtn_Click);
            // 
            // startTime
            // 
            this.startTime.AutoSize = true;
            this.startTime.Font = new System.Drawing.Font("Iosevka Extended", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startTime.ForeColor = System.Drawing.SystemColors.Control;
            this.startTime.Location = new System.Drawing.Point(43, 8);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(95, 34);
            this.startTime.TabIndex = 11;
            this.startTime.Text = "00:00";
            // 
            // loopBtn
            // 
            this.loopBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loopBtn.Font = new System.Drawing.Font("Iosevka Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loopBtn.ForeColor = System.Drawing.Color.White;
            this.loopBtn.Location = new System.Drawing.Point(571, 70);
            this.loopBtn.Name = "loopBtn";
            this.loopBtn.Size = new System.Drawing.Size(94, 35);
            this.loopBtn.TabIndex = 4;
            this.loopBtn.Text = "Loop";
            this.loopBtn.UseVisualStyleBackColor = true;
            this.loopBtn.Click += new System.EventHandler(this.loopBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Iosevka Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(271, 70);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(94, 35);
            this.backBtn.TabIndex = 3;
            this.backBtn.Text = "Backwards";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click_1);
            // 
            // forwardBtn
            // 
            this.forwardBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.forwardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forwardBtn.Font = new System.Drawing.Font("Iosevka Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.forwardBtn.ForeColor = System.Drawing.Color.White;
            this.forwardBtn.Location = new System.Drawing.Point(471, 70);
            this.forwardBtn.Name = "forwardBtn";
            this.forwardBtn.Size = new System.Drawing.Size(94, 35);
            this.forwardBtn.TabIndex = 2;
            this.forwardBtn.Text = "Forwards";
            this.forwardBtn.UseVisualStyleBackColor = true;
            this.forwardBtn.Click += new System.EventHandler(this.forwardBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitBtn.BackgroundImage")));
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.exitBtn.Location = new System.Drawing.Point(808, 8);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(34, 34);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.minimizeBtn);
            this.panel2.Controls.Add(this.fileBtn);
            this.panel2.Controls.Add(this.exitBtn);
            this.panel2.Location = new System.Drawing.Point(-14, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(861, 50);
            this.panel2.TabIndex = 8;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Iosevka Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(19, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 35);
            this.button1.TabIndex = 16;
            this.button1.Text = "Settings";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.Font = new System.Drawing.Font("Iosevka Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minimizeBtn.ForeColor = System.Drawing.Color.White;
            this.minimizeBtn.Location = new System.Drawing.Point(771, 8);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(22, 10);
            this.minimizeBtn.TabIndex = 15;
            this.minimizeBtn.Text = "Minimize";
            this.minimizeBtn.UseVisualStyleBackColor = true;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // fileBtn
            // 
            this.fileBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileBtn.Font = new System.Drawing.Font("Iosevka Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileBtn.ForeColor = System.Drawing.Color.White;
            this.fileBtn.Location = new System.Drawing.Point(101, 7);
            this.fileBtn.Name = "fileBtn";
            this.fileBtn.Size = new System.Drawing.Size(64, 35);
            this.fileBtn.TabIndex = 14;
            this.fileBtn.Text = "Files";
            this.fileBtn.UseVisualStyleBackColor = true;
            this.fileBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // songImage
            // 
            this.songImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.songImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.songImage.ErrorImage = null;
            this.songImage.Image = ((System.Drawing.Image)(resources.GetObject("songImage.Image")));
            this.songImage.Location = new System.Drawing.Point(25, 63);
            this.songImage.Name = "songImage";
            this.songImage.Size = new System.Drawing.Size(227, 227);
            this.songImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.songImage.TabIndex = 9;
            this.songImage.TabStop = false;
            // 
            // trackList
            // 
            this.trackList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.trackList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trackList.Font = new System.Drawing.Font("Iosevka Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.trackList.ForeColor = System.Drawing.Color.White;
            this.trackList.FormattingEnabled = true;
            this.trackList.ItemHeight = 20;
            this.trackList.Location = new System.Drawing.Point(277, 63);
            this.trackList.Name = "trackList";
            this.trackList.Size = new System.Drawing.Size(535, 282);
            this.trackList.TabIndex = 10;
            this.trackList.SelectedIndexChanged += new System.EventHandler(this.trackList_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Iosevka Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(12, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Now playing:";
            // 
            // currentSongLabel
            // 
            this.currentSongLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentSongLabel.Font = new System.Drawing.Font("Iosevka Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentSongLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.currentSongLabel.Location = new System.Drawing.Point(12, 321);
            this.currentSongLabel.Name = "currentSongLabel";
            this.currentSongLabel.Size = new System.Drawing.Size(259, 24);
            this.currentSongLabel.TabIndex = 13;
            this.currentSongLabel.Text = "-";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 150;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(836, 480);
            this.Controls.Add(this.currentSongLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackList);
            this.Controls.Add(this.songImage);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Music Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.songImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProgressBar playBar;
        private Button playBtn;
        private Panel panel1;
        private Button shuffleBtn;
        private Button loopBtn;
        private Button backBtn;
        private Button forwardBtn;
        private Button exitBtn;
        private TrackBar trackBar1;
        private Panel panel2;
        private PictureBox songImage;
        private Label startTime;
        private Label endTime;
        private ListBox trackList;
        private Label volumeLabel;
        private Button fileBtn;
        private BindingSource topBar;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label currentSongLabel;
        private System.Windows.Forms.Timer timer2;
        private Label songLabel;
        private Label albumLabel;
        private Label artistLabel;
        private Button minimizeBtn;
        private Button button1;
    }
}