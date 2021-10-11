using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1
{
    class Program
    {
        static void soru1()
        {
            Console.Write("n giriniz:");
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> ciftler = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int okunan = Convert.ToInt32(Console.ReadLine());

                if (okunan % 2 == 0)
                {
                    ciftler.Add(okunan);
                }
            }

            Console.WriteLine("\nCift Olanlar");

            for (int i = 0; i < ciftler.Count; i++)
            {
                Console.Write(ciftler[i] + " ");
            }
        }
        static void soru2()
        {
            Console.Write("n giriniz:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("m giriniz:");
            int m = Convert.ToInt32(Console.ReadLine());

            List<int> sonuclar = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int okunan = Convert.ToInt32(Console.ReadLine());

                if (okunan == m || okunan%m==0)
                {
                    sonuclar.Add(okunan);
                }
            }

            Console.WriteLine("\nSonuçlar");

            for (int i = 0; i < sonuclar.Count; i++)
            {
                Console.Write(sonuclar[i] + " ");
            }
        }
        static void soru3()
        {
            int n = 0;
            while (true)
            {
                Console.Write("n giriniz:");
                n = Convert.ToInt32(Console.ReadLine());
                if (n < 0)
                {
                    Console.WriteLine("Negatif sayı giremezsiniz!");
                }
                else
                {
                    break;
                }
            }

            Stack<string> stack = new Stack<string>();
            for (int i = 0; i < n; i++)
            {
                string okunan = Console.ReadLine();
                stack.Push(okunan);
            }

            Console.WriteLine();

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Peek());
                stack.Pop();
            }

        }
        static void soru4()
        {
             Console.Write("Cümleyi Giriniz:");
             string okunan = Console.ReadLine();
             int harfSayisi = 0;
             int kelimeSayisi = 0;

             for (int i = 0; i < okunan.Length; i++)
             {
                 if (char.IsWhiteSpace(okunan,i))
                 {
                     kelimeSayisi++;
                 }
                 else
                 {
                    if(char.IsLetter(okunan[i]))
                         harfSayisi++;
                 }
             }

            Console.WriteLine("Kelime Sayisi:" + (++kelimeSayisi) + " " + "Harf Sayisi:" + harfSayisi);
        }

        static void Main(string[] args)
        {
            //soru1();
            //soru2();
            //soru3();
            //soru4();

            Console.ReadKey();

        }
    }
}
