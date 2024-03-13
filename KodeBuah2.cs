using KPLMOD4_1302223146.Buah;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPLMOD4_1302223146.Buah2
{
    internal class KodeBuah2
    {
        public String namaBuah;
        public String kodeBuah;
        public List<KodeBuah> kodebuahList = new List<KodeBuah>();
        public KodeBuah2(String namaBuah, String kodeBuah)
        {
            this.namaBuah = namaBuah;
            this.kodeBuah = kodeBuah;
        }
        public KodeBuah2()
        {
        }
        public void setKodeBuah()
        {
            this.kodebuahList.Add(new KodeBuah("Apel", "A00"));
            this.kodebuahList.Add(new KodeBuah("Aprikot", "B00"));
            this.kodebuahList.Add(new KodeBuah("Alpukat", "C00"));
            this.kodebuahList.Add(new KodeBuah("Pisang", "D00"));
            this.kodebuahList.Add(new KodeBuah("Paprika", "E00"));
            this.kodebuahList.Add(new KodeBuah("Kurma", "K00"));
            this.kodebuahList.Add(new KodeBuah("Durian", "L00"));
            this.kodebuahList.Add(new KodeBuah("Anggur", "M00"));
            this.kodebuahList.Add(new KodeBuah("Melon", "N00"));
            this.kodebuahList.Add(new KodeBuah("Semangka", "O00"));
        }
        public void getKodeBuah()
        {
            Console.WriteLine("Nama Buah\tKode Buah");
            foreach (KodeBuah k in this.kodebuahList)
            {
                Console.WriteLine(k.namaBuah + "\t" + k.kodeBuah);
            }
        }
    }
}
