using System;
using System.IO;
using System.Text;
using System.Media;
using System.Diagnostics;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using System.Threading;

namespace tes727
{
    // this get the systen username
    public class Masaya
    {
        // public string Shindou;
        public string Shindou = Environment.UserName;
        public static string audiosuka = Environment.CurrentDirectory + @"\data\SYS_ASUKA00.ogg";
        public static string audio_mashiro = Environment.CurrentDirectory + @"\data\SYS_MASHIRO00.ogg";
        public static string audio_misaki = Environment.CurrentDirectory + @"\data\SYS_MISAKI00.ogg";
        public static string audio_rika = Environment.CurrentDirectory + @"\data\SYS_RIKA00.ogg";
        // Assign audio file
            // public static string woc = Environment.CurrentDirectory + @"\data\woc.ogg";
            // public static string spritesuka = Environment.CurrentDirectory + @"\data\asuka.png";
    }
    class Program
    {
        static void Main(string[] args)
        {

            // obsolete since switching so SFML
                // set path and command arg
                // string vlc = @"C:\Program Files\VideoLAN\VLC\vlc.exe";
                // var sys_asuka = new AudioFileReader(Environment.CurrentDirectory + @"\data\SYS_ASUKA00.mp3");
            // Assign soundbuffer
            var sys_asuka = new SoundBuffer(Masaya.audiosuka);
            var sys_mashiro = new SoundBuffer(Masaya.audio_mashiro);
            var sys_misaki = new SoundBuffer(Masaya.audio_misaki);
            var sys_rika = new SoundBuffer(Masaya.audio_rika);    
                // var sys_woc = new Music(Masaya.woc);
            // Draw a window     
                // var doommeow = new RenderWindow(new SFML.Window.VideoMode(960, 540), "whitecat");
            // obsolete since switching so SFML
                // var minori = new WasapiOut();
                // var minori = new SoundBuffer(pathsuka);
                // string aoi = "-I null --play-and-exit --no-loop";
                // the random number generator
            var misaki = new Random();
            var Asuka = new Masaya();
            int rika = misaki.Next(1, 5);
            // This code below is a debug flag to force a specific outcome, for testing only
                // int rika = 1;
            // play and greet
            switch (rika)
            {
                case 1:
                    {
                        Console.WriteLine($"Hello there! {Asuka.Shindou} from Asuka");
                        var minori = new Sound(sys_asuka);
                        minori.Play();
                        // This draw an image of Asuka into a Window
                            // sys_woc.Play();
                            // var texturesuka = new Texture(Masaya.spritesuka);
                            // var sprite_asuka = new Sprite(texturesuka);
                            // doommeow.Draw(sprite_asuka);
                            // doommeow.Display();
                            // var info = texturesuka.Size;
                            // Console.WriteLine(info);
                        int mdk = sys_asuka.Duration.AsMilliseconds();
                            // int mdkwoc = sys_woc.Duration.AsMilliseconds();
                            // Console.WriteLine(mdkwoc);
                        Thread.Sleep(mdk);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine($"Hello there! {Asuka.Shindou} from Rika");
                        var minori = new Sound(sys_rika);
                        minori.Play();
                        int mdk = sys_rika.Duration.AsMilliseconds();
                            // Console.WriteLine(mdk);
                        Thread.Sleep(mdk);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine($"Hello there! {Asuka.Shindou} from Mashiro");
                        var minori = new Sound(sys_mashiro);
                        minori.Play();
                        int mdk = sys_mashiro.Duration.AsMilliseconds();
                            // Console.WriteLine(mdk);
                        Thread.Sleep(mdk);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine($"Hello there! {Asuka.Shindou} from Misaki");
                        var minori = new Sound(sys_misaki);
                        minori.Play();
                        int mdk = sys_misaki.Duration.AsMilliseconds();
                            // Console.WriteLine(mdk);
                        Thread.Sleep(mdk);
                        break;
                    }
            }
        }
    }
}
