using System;
using System.IO;
using System.Text;
using System.Media;
using System.Diagnostics;
using NAudio.Lame;
using NAudio.Wave;
using System.Threading;

namespace tes727
{
    // this get the systen username
    public class Masaya
    {
        // public string Shindou;
        public string Shindou = Environment.UserName;
    }
    class Program
    {
        static void Main(string[] args)
        {
            // set path and command arg
            // string vlc = @"C:\Program Files\VideoLAN\VLC\vlc.exe";
            var sys_asuka = new AudioFileReader(Environment.CurrentDirectory + @"\data\SYS_ASUKA00.mp3");
            var sys_mashiro = new AudioFileReader(Environment.CurrentDirectory + @"\data\SYS_MASHIRO00.mp3");
            var sys_misaki = new AudioFileReader(Environment.CurrentDirectory + @"\data\SYS_MISAKI00.mp3");
            var sys_rika = new AudioFileReader(Environment.CurrentDirectory + @"\data\SYS_RIKA00.mp3");
            var minori = new WasapiOut();
            // string aoi = "-I null --play-and-exit --no-loop";
            // the random number generator
            var misaki = new Random();
            var Asuka = new Masaya();
            int rika = misaki.Next(1, 5);
            // play and greet
            switch (rika)
            {
                case 1:
                    {
                        Console.WriteLine($"Hello there! {Asuka.Shindou} from Asuka");
                        minori.Init(sys_asuka);
                        minori.Play();
                        while (minori.PlaybackState == PlaybackState.Playing)
                        {
                            Thread.Sleep(1000);
                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine($"Hello there! {Asuka.Shindou} from Rika");
                        minori.Init(sys_rika);
                        minori.Play();
                        while (minori.PlaybackState == PlaybackState.Playing)
                        {
                            Thread.Sleep(1000);
                        }
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine($"Hello there! {Asuka.Shindou} from Mashiro");
                        minori.Init(sys_mashiro);
                        minori.Play();
                        while (minori.PlaybackState == PlaybackState.Playing)
                        {
                            Thread.Sleep(1000);
                        }
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine($"Hello there! {Asuka.Shindou} from Misaki");
                        minori.Init(sys_misaki);
                        minori.Play();
                        while (minori.PlaybackState == PlaybackState.Playing)
                        {
                            Thread.Sleep(1000);
                        }
                        break;
                    }
            }
        }
    }
}
