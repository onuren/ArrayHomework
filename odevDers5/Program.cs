using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odevDers5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 21, 59, 483, 26, 14, -14, 78, -89, -415 };
            int gecici = 0;
            int enbuyuk = dizi[0];
            int enkucuk = dizi[0];
            int buyuk = 0;
            int kucuk = 0;

            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] > enbuyuk)
                {
                    enbuyuk = dizi[i];
                    buyuk = i;
                }
                if (dizi[i] < enkucuk)
                {
                    enkucuk = dizi[i];
                    kucuk =i;
                }
            }

            //yer değiştirme işlemi
            gecici = dizi[buyuk];
            dizi[buyuk] = dizi[kucuk];
            dizi[kucuk] = gecici;

            //yazdırma işlemi
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine(dizi[i]);
            }
        }
    }
}
