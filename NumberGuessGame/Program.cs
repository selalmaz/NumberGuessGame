using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessGame
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayi, hak = 3;
            Random rastgele = new Random();
            int b = 10, a = 0;
            int Rastgele = rastgele.Next(a, b);

            Console.WriteLine("{0} ile {1} arasinda sayiyi tahmin et\n\n", a, b);


            for (int i = 1; i <= hak; i++)
            {
                Console.Write("Sayi giriniz: ");
                sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi > b || sayi < 0)
                {
                    Console.WriteLine("{0}-{1} arasinda deger giriniz.", a, b);
                    i--;
                }
                    
                else
                {
                    if (sayi == Rastgele)
                    {
                        Console.WriteLine("Tebrikler dogru cevap {0}'dir", Rastgele);
                        break;
                    }
                    else
                    {

                        if (sayi > Rastgele)
                            Console.WriteLine("daha kucuk bir sayi giriniz kalan hakkiniz:{0}", hak - i);

                        else
                            Console.WriteLine("daha buyuk bir sayi giriniz kalan hakkiniz:{0}", hak - i);
                    }

                    if (hak - i == 0)
                    {
                        Console.WriteLine("hakkiniz kalmadi dogru sonuc: {0}", Rastgele);
                        break;
                    }
                }
            }

            Console.ReadLine();


        }
    }
}
