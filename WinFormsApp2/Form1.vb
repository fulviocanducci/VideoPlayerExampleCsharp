Imports LibVLCSharp.Shared
Imports LibVLCSharp.WinForms
Public Class Form1
    Private LibVLC As LibVLC
    Private MediaPlayer As MediaPlayer
    Private VideoView As VideoView
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LibVLC = New LibVLC()
        MediaPlayer = New MediaPlayer(LibVLC)
        VideoView = New VideoView() With {
            .Dock = DockStyle.Fill,
            .MediaPlayer = MediaPlayer
        }
        GrpBoxVideo.Controls.Add(VideoView)
        Dim videoPath = "C:\Temp\Videos\1.mp4"
        Using media As Media = New Media(LibVLC, videoPath, FromType.FromPath)
            MediaPlayer.Play(media)
        End Using
    End Sub
End Class
