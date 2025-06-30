// You are working on a new player uses this Interface

public interface IAudioPlayer
{
    public void Play(string filename);
}

public class NewAudioPlayer : IAudioPlayer
{
    public void Play(string filename)
    {
        Console.WriteLine("Playing file 2020 " + filename);
    }
}

public class LegacyMediaPlayer
{
    public void PlayFile(string filePath)
    {
        Console.WriteLine("Playing file 1980 " + filePath);
    }
}

public class MediaAdapter : IAudioPlayer
{
    LegacyMediaPlayer mediaPlayer = new LegacyMediaPlayer();

    public MediaAdapter(LegacyMediaPlayer mediaPlayer)
    {
        this.mediaPlayer = mediaPlayer;
    }

    public void Play(string filename)
    {
        mediaPlayer.PlayFile(filename);
    }
}

class Program
{
    public static void Main()
    {
        LegacyMediaPlayer mediaPlayer = new LegacyMediaPlayer();
        IAudioPlayer mediaAdapter = new MediaAdapter(mediaPlayer);
        mediaAdapter.Play("NewSong.mp3");
    }
}