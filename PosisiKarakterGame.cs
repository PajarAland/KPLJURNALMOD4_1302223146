using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPLMOD4_1302223146.posChar
{
    internal class PosisiKarakterGame
    {
        public enum StatePlayer {Jongkok, Berdiri, Tengkurap, Terbang};
        
        public void run()
        {
            StatePlayer defaults = StatePlayer.Berdiri;
            String masukanPerintah;
            Console.WriteLine("Input Action: ");
            Console.WriteLine("1. [S] untuk arah bawah");
            Console.WriteLine("2. [W] untuk arah atas");
            masukanPerintah = Console.ReadLine();

            if (masukanPerintah == "W")
            {
                if(defaults == StatePlayer.Jongkok)
                {
                    defaults = StatePlayer.Berdiri;
                    Console.WriteLine(defaults + "Tombol Arah Atas di Tekan");
                }
                else if (defaults == StatePlayer.Tengkurap)
                {
                    defaults = StatePlayer.Berdiri;
                    Console.WriteLine(defaults + "Tombol Arah Atas di Tekan");
                }
                else if(defaults == StatePlayer.Terbang)
                {
                    defaults = StatePlayer.Berdiri;
                    Console.WriteLine(defaults + "Tombol Arah Atas di Tekan");
                }
            }
            else if (masukanPerintah == "S")
            {
                if (defaults == StatePlayer.Berdiri)
                {
                    defaults = StatePlayer.Jongkok;
                    Console.WriteLine(defaults + "Tombol Arah Bawah di Tekan");
                }
                else if (defaults == StatePlayer.Terbang)
                {
                    defaults = StatePlayer.Jongkok;
                    Console.WriteLine(defaults + "Tombol Arah Bawah di Tekan");
                }
                else if (defaults == StatePlayer.Tengkurap)
                {
                    defaults = StatePlayer.Jongkok;
                    Console.WriteLine(defaults + "Tombol Arah Bawah di Tekan");
                }
            }
            else if (masukanPerintah == "X")
            {
                if (defaults == StatePlayer.Jongkok)
                {
                    defaults = StatePlayer.Terbang;
                    Console.WriteLine(defaults + "Tombol Arah Bawah di Tekan");
                }
                else if (defaults == StatePlayer.Berdiri)
                {
                    defaults = StatePlayer.Terbang;
                    Console.WriteLine(defaults + "Tombol X di Tekan");
                }
                else if (defaults == StatePlayer.Tengkurap)
                {
                    defaults = StatePlayer.Terbang;
                    Console.WriteLine(defaults + "Tombol X di Tekan");
                }
            }

        }
    }
}
