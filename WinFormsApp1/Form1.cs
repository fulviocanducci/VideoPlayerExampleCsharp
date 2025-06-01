using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private LibVLC LibVLC { get; }
        private MediaPlayer MediaPlayer { get; }
        private VideoView VideoView { get; }
        public Form1()
        {
            InitializeComponent();
            Core.Initialize();
            LibVLC = new LibVLC();
            MediaPlayer = new MediaPlayer(LibVLC);
            VideoView = new VideoView
            {
                MediaPlayer = MediaPlayer,
                Dock = DockStyle.Fill,
                BackColor = Color.Black,
                Name = "Video",
            };
            GrpBoxVideo.Controls.Add(VideoView);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string videoPath = @"C:\Temp\Videos\1.mp4";
            using var media = new Media(LibVLC, videoPath, FromType.FromPath);            
            MediaPlayer.Play(media);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MediaPlayer.Stop();
            string videoPath = @"C:\Temp\Videos\2.mp4";
            using var media = new Media(LibVLC, videoPath, FromType.FromPath);
            MediaPlayer.Play(media);
        }
    }
}
