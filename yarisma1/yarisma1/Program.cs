using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yarisma1
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("****Sürpriz Ödüllü Bilgi Yarışmasına Hoşgeldiniz****");
                Console.WriteLine();
                Console.WriteLine("--------------------------------");
                Console.WriteLine();

                int soru = 1;
                string cevap;
                if (soru == 1)
            {
                Console.WriteLine("Türkiye'nin başkenti neresidir ? ");
                Console.WriteLine();
                Console.WriteLine("A)Adana");
                Console.WriteLine("B)Ankara");
                Console.WriteLine("C)İstanbul");
                Console.WriteLine("D)İzmir");
                Console.WriteLine();
                Console.WriteLine("Cevabınız: ");
                cevap = Console.ReadLine();
                if(cevap=="b" || cevap=="B")
                {
                    soru = soru + 1;
                }
                else
                {
                    Console.WriteLine("Yanlış cevap toplam puanınız : 0");
                }


            }
            Console.ReadLine();
            if (soru == 2)
            {
                Console.WriteLine("Aşağıdaki şıklardan hangisinin rakamları toplamı daha büyüktür ? ");
                Console.WriteLine();
                Console.WriteLine("A)1994");
                Console.WriteLine("B)1995");
                Console.WriteLine("C)1996");
                Console.WriteLine("D)1997");
                Console.WriteLine();
                Console.WriteLine("Cevabınız: ");
                cevap = Console.ReadLine();
                if (cevap == "d" || cevap == "D")
                {
                    soru = soru + 1;
                }
                else
                {
                    Console.WriteLine("Yanlış cevap toplam puanınız : 1");
                }


            }
            Console.ReadLine();
            if (soru == 3)
            {
                Console.WriteLine("Kahramanmaraş hangi coğrafi bölgemizdedir ? ");
                Console.WriteLine();
                Console.WriteLine("A)Doğu Anadolu");
                Console.WriteLine("B)Güneydoğu Anadolu");
                Console.WriteLine("C)Akdeniz");
                Console.WriteLine("D)İç Anadolu");
                Console.WriteLine();
                Console.WriteLine("Cevabınız: ");
                cevap = Console.ReadLine();
                if (cevap == "c" || cevap == "C")
                {
                    soru = soru + 1;
                }
                else
                {
                    Console.WriteLine("Yanlış cevap toplam puanınız : 2");
                }


            }
            Console.ReadLine();
            if (soru == 4)
            {
                Console.WriteLine("Ülkemiz kaç coğrafi bölgeden oluşmaktadır ? ");
                Console.WriteLine();
                Console.WriteLine("A)2");
                Console.WriteLine("B)4");
                Console.WriteLine("C)5");
                Console.WriteLine("D)7");
                Console.WriteLine();
                Console.WriteLine("Cevabınız: ");
                cevap = Console.ReadLine();
                if (cevap == "d" || cevap == "D")
                {
                    soru = soru + 1;
                }
                else
                {
                    Console.WriteLine("Yanlış cevap toplam puanınız : 3");
                }


            }
            Console.ReadLine();
            if (soru == 5)
            {
                Console.WriteLine("333x111+1 kaçtır ? ");
                Console.WriteLine();
                Console.WriteLine("A)33,333");
                Console.WriteLine("B)33,334");
                Console.WriteLine("C)36,964");
                Console.WriteLine("D)36,444");
                Console.WriteLine();
                Console.WriteLine("Cevabınız: ");
                cevap = Console.ReadLine();
                if (cevap == "c" || cevap == "C")
                {
                    Console.WriteLine("Doğru cevap verdiniz.Yarışmayı kazandınız efenim....Ödül olarak bizden bir adet alkış kazandınız ...");
                   
                }
                else
                {
                    Console.WriteLine("Yanlış cevap toplam puanınız : 4");
                }


            }
            Console.ReadLine();
        }

        }
    }

