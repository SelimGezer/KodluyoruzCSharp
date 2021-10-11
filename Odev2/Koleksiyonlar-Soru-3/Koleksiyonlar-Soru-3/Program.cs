using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
            keyValuePairs.Add('a', 0);
            keyValuePairs.Add('e', 1);
            keyValuePairs.Add('ı', 2);
            keyValuePairs.Add('i', 3);
            keyValuePairs.Add('o', 4);
            keyValuePairs.Add('ö', 5);
            keyValuePairs.Add('u', 6);
            keyValuePairs.Add('ü', 7);

            Console.Write("Cümle giriniz:");
            string cumle = Console.ReadLine();

            char[] bulunan = new char[cumle.Length];
            int k = 0;

            for (int i = 0; i < cumle.Length; i++)
            {
                if (keyValuePairs.ContainsKey(cumle[i]))
                {
                    bulunan[k++] = cumle[i];
                }
            }

            for (int i = 0; i < bulunan.Length; i++)
            {
                for (int j = 0; j < bulunan.Length-1; j++)
                {
                    if (bulunan[j] != '\0' && bulunan[j + 1] != '\0' && keyValuePairs[bulunan[j]] > keyValuePairs[bulunan[j + 1]])
                    {
                        char gecici = bulunan[j + 1];
                        bulunan[j + 1] = bulunan[j];
                        bulunan[j] = gecici;
                    }
                }
            }

            Console.WriteLine("\nBulunan Sesliler");
            for (int i = 0; i < bulunan.Length; i++)
            {
                Console.Write(bulunan[i]+" ");
            }

            Console.ReadKey();
        }
    }
}
