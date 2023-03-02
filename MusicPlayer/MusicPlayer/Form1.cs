using System.Net.Http;
using System;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using NAudio.Wave;
using NAudio.Utils;
using System.IO;
using System.Formats.Tar;
using System.Diagnostics;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0,0);
        private bool playing = false;
        private WaveOut waveOut;
        private AudioFileReader audioFileReader;
        private PictureBox pictureBox;
        private bool shuffle = false;
        private Thread playbackThread;
        private bool loop = false;
        //TODO: Add to Settings: EQ, File Storage as an option, Playlists
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            waveOut = new WaveOut();
            trackBar1.Value = 50;
            volumeLabel.Text = "50%";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            playBtn.Left = (this.ClientSize.Width - playBtn.Width) / 2;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }


        private System.Drawing.Drawing2D.GraphicsPath GetCirclePath(Rectangle rect)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(rect);
            return path;
        }

        private void forwardBtn_Click(object sender, EventArgs e)
        {
            if (shuffle == false)
            {
                if (trackList.SelectedIndex < trackList.Items.Count - 1)
                {
                    trackList.SelectedIndex = trackList.SelectedIndex + 1;
                }
            }
            else
            {
                if (trackList.SelectedIndex < trackList.Items.Count - 1)
                {
                    Random random = new Random();
                    int index = random.Next(trackList.Items.Count);
                    trackList.SelectedIndex = index;
                }
            }
        }

        private void shuffleBtn_Click(object sender, EventArgs e)
        {
            shuffle = !shuffle;

            if (shuffle == true)
            {
                shuffleBtn.ForeColor = Color.RoyalBlue;
            }
            else
            {
                shuffleBtn.ForeColor = Color.White;   
            }
        }

        private void loopBtn_Click(object sender, EventArgs e)
        {
            loop = !loop;

            if (loop == true)
            {
                loopBtn.ForeColor = Color.RoyalBlue;
            }
            else
            {
                loopBtn.ForeColor = Color.White;
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void backBtn_Click_1(object sender, EventArgs e)
        {
            if (shuffle == false)
            {
                if (trackList.SelectedIndex > 0)
                {
                    trackList.SelectedIndex--;
                }
            }
            else
            {
                if (trackList.SelectedIndex > 0)
                {
                    Random random = new Random();
                    int index = random.Next(trackList.Items.Count);
                    trackList.SelectedIndex = index;
                }
            }
        }

        string[] paths, files;

        private void trackList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (waveOut != null && waveOut.PlaybackState == PlaybackState.Playing)
            {
                waveOut.Stop();
            }
            audioFileReader = new AudioFileReader(paths[trackList.SelectedIndex]);
            waveOut = new WaveOut();

            if (audioFileReader != null)
            {
                audioFileReader.Volume = trackBar1.Value / 100f;
            }

            //waveOut.DeviceNumber = 0;
            waveOut.Init(audioFileReader);
            waveOut.Play();

            if (audioFileReader != null)
            {
                audioFileReader.Volume = trackBar1.Value / 100f;
            }

            try
            {
                var file = TagLib.File.Create(paths[trackList.SelectedIndex]);
                var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                songImage.Image = Image.FromStream(new MemoryStream(bin));

            }
            catch 
            {
                songImage.Image = Properties.Resources.eKore;
            }
            try
            {
                TagLib.File tagFile = TagLib.File.Create(paths[trackList.SelectedIndex]);
                string artist = tagFile.Tag.FirstArtist;
                string album = tagFile.Tag.Album;
                string title = tagFile.Tag.Title;
                artistLabel.Text = artist;
                albumLabel.Text = album;
                songLabel.Text = title;
            }
            catch
            {

            }
            TimeSpan playbackPosition = audioFileReader.CurrentTime;
            TimeSpan totalLength = audioFileReader.TotalTime;


            int currentPosition = (int)playbackPosition.TotalSeconds;
            int totalDuration = (int)totalLength.TotalSeconds;

            if (waveOut.PlaybackState == PlaybackState.Stopped)
            {
                if (shuffle == false && trackList.SelectedIndex < trackList.Items.Count - 1)
                {
                    trackList.SelectedIndex = trackList.SelectedIndex + 1;
                }
                else if (shuffle == true)
                {
                    Random random = new Random();
                    int index = random.Next(trackList.Items.Count);
                    trackList.SelectedIndex = index;
                }
            }

        }
        


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            volumeLabel.Text = trackBar1.Value.ToString() + "%";
            if (audioFileReader != null)
            {
                trackBar1.Scroll += (s, a) => audioFileReader.Volume = trackBar1.Value / 100f;
            }
        }


        private void playBtn_Click(object sender, EventArgs e)
        {
            if (trackList.SelectedItems.Count > 0)
            {
                if (waveOut != null && waveOut.PlaybackState == PlaybackState.Playing)
                {
                    waveOut.Pause();
                }
                else waveOut.Play();
            }
            
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (waveOut.PlaybackState == PlaybackState.Playing)
                {
                    TimeSpan playbackPosition = audioFileReader.CurrentTime;
                    TimeSpan totalLength = audioFileReader.TotalTime;

                    startTime.Text = playbackPosition.ToString(@"mm\:ss");
                    endTime.Text = totalLength.ToString(@"mm\:ss");

                    int currentPosition = (int)playbackPosition.TotalSeconds;
                    int totalDuration = (int)totalLength.TotalSeconds;

                    playBar.Maximum = totalDuration;
                    playBar.Value = currentPosition;
                }
                else if (waveOut.PlaybackState == PlaybackState.Stopped)
                {
                    if (shuffle == false && trackList.SelectedIndex < trackList.Items.Count - 1)
                    {
                        trackList.SelectedIndex = trackList.SelectedIndex + 1;
                    }
                    else if (shuffle == true)
                    {
                        Random random = new Random();
                        int index = random.Next(trackList.Items.Count);
                        trackList.SelectedIndex = index;
                    }
                }
            }
            catch
            {
                Debug.WriteLine("Damn");
            }
        }

        private void playBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (trackList.Items.Count > 0)
            {
                int newPosition = Convert.ToInt32(audioFileReader.TotalTime.TotalMilliseconds * e.X / playBar.Width);
                audioFileReader.CurrentTime = TimeSpan.FromMilliseconds(newPosition);

                int currentPosition = (int)audioFileReader.Position;
                int totalDuration = (int)audioFileReader.Length;
                int newProgress = (int)((double)currentPosition / totalDuration * playBar.Maximum);
                playBar.Value = newProgress;
            }

        }

        private int scrollIndex = 0;

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (trackList.SelectedItem != null)
            {
                string songName = trackList.SelectedItem.ToString();
                if (songName.Length > 25) //adjust this number as needed!!
                {
                    if (scrollIndex >= songName.Length)
                    {
                        scrollIndex = 0;
                    }
                    currentSongLabel.Text = songName.Substring(scrollIndex) + "      " + songName.Substring(0, scrollIndex);
                    scrollIndex++;
                }
                else
                {
                    currentSongLabel.Text = songName;
                }
            }
        }

        private void WaveOut_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            if (e.Exception == null && waveOut.PlaybackState == PlaybackState.Stopped)
            {
                return;
            }

            if (shuffle == true)
            {
                Random rand = new Random();
                trackList.SelectedIndex = rand.Next(0, trackList.Items.Count);
            }
            else if (trackList.SelectedIndex < trackList.Items.Count - 1)
            {
                trackList.SelectedIndex++;
            }
            else
            {
                waveOut.Stop();
            }
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            trackList.Items.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Audio Files|*.wav;*.mp3;*.ogg;*.flac";
            ofd.Title = "Select only audio files";
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.FileNames;
                paths = ofd.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    string fileName = Path.GetFileNameWithoutExtension(files[i]);
                    trackList.Items.Add(fileName);
                }
            }
        }
    }
}