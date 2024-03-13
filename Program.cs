// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using KPLMOD4_1302223146.Buah;
using KPLMOD4_1302223146.Buah2;
using KPLMOD4_1302223146.posChar;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KodeBuah kodebuah = new KodeBuah();
            KodeBuah2 kodeBuah2 = new KodeBuah2();

            kodebuah.setKodeBuah();
            kodebuah.getKodeBuah();
            Console.WriteLine();
            kodebuah.setKodeBuah();
            kodebuah.getKodeBuah();

            PosisiKarakterGame posisiKarakterGame = new PosisiKarakterGame();
            posisiKarakterGame.run();


        }
    }
}
