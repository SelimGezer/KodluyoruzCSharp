using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            for (int i = 0; i < 20; i++)
            {
                Console.Write((i + 1) + ".Sayiyi Giriniz:");
                int okunan = Convert.ToInt32(Console.ReadLine());
                arrayList.Add(okunan);
            }

            arrayList.Sort();

            int enKucukToplam = 0;

            for (int i = 0; i < 3; i++)
            {
                enKucukToplam += (int)arrayList[i];
            }

            int enBuyukToplam = 0;

            for (int i = arrayList.Count - 1; i > arrayList.Count - 1 - 3; i--)
            {
                enBuyukToplam += (int)arrayList[i];
            }

            Console.WriteLine("\nEn Küçüklerin Ort:" + enKucukToplam / 3);
            Console.WriteLine("En Büyüklerin Ort:" + enBuyukToplam / 3);
            Console.WriteLine("Ortalama Toplamları:" + (enBuyukToplam+enKucukToplam)/3);
                       
            Console.ReadKey();
        }
    }
}
