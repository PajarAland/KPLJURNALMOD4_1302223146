using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPLMOD4_1302223146.Buah
{
    internal class KodeBuah
    {
        public String namaBuah;
        public String kodeBuah;
        public List<KodeBuah> kodebuahList = new List<KodeBuah>();
        public KodeBuah(String namaBuah, String kodeBuah)
        {
            this.namaBuah = namaBuah;
            this.kodeBuah = kodeBuah;
            
        }

        public KodeBuah()
        {
        }

        public void setKodeBuah()
        {
            this.kodebuahList.Add(new KodeBuah("Apel", "A00"));
            this.kodebuahList.Add(new KodeBuah("Aprikot", "B00"));
            this.kodebuahList.Add(new KodeBuah("Alpukat", "C00"));
            this.kodebuahList.Add(new KodeBuah("Pisang", "D00"));
            this.kodebuahList.Add(new KodeBuah("Paprika", "E00"));
            this.kodebuahList.Add(new KodeBuah("Blackberry", "F00"));
            this.kodebuahList.Add(new KodeBuah("Ceri", "H00"));
            this.kodebuahList.Add(new KodeBuah("Kelapa", "I00"));
            this.kodebuahList.Add(new KodeBuah("Jagung", "J00"));
        }
        public void getKodeBuah()
        {
            Console.WriteLine("Nama Buah\tKode Buah");
            foreach(KodeBuah k in this.kodebuahList)
            {
                Console.WriteLine(k.namaBuah + "\t" + k.kodeBuah);
            }
        }
    }
}
