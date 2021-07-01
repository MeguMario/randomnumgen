using System;
using System.IO;
using System.Text;
using System.Media;
using System.Diagnostics;

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
            string vlc = @"C:\Program Files\VideoLAN\VLC\vlc.exe";
            string sys_asuka = Environment.CurrentDirectory + @"\data\SYS_ASUKA00.mp3";
            string sys_mashiro = Environment.CurrentDirectory + @"\data\SYS_MASHIRO00.mp3";
            string sys_misaki = Environment.CurrentDirectory + @"\data\SYS_MISAKI00.mp3";
            string sys_rika = Environment.CurrentDirectory + @"\data\SYS_RIKA00.mp3";
            string aoi = "-I null --play-and-exit --no-loop";
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
                        Process.Start(vlc, aoi + " " + sys_asuka).WaitForExit();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine($"Hello there! {Asuka.Shindou} from Rika");
                        Process.Start(vlc, aoi + " " + sys_rika).WaitForExit();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine($"Hello there! {Asuka.Shindou} from Mashiro");
                        Process.Start(vlc, aoi + " " + sys_mashiro).WaitForExit();
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine($"Hello there! {Asuka.Shindou} from Misaki");
                        Process.Start(vlc, aoi + " " + sys_misaki).WaitForExit();
                        break;
                    }
            }
        }
    }
}
