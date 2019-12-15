using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ödev.Gazikazan
{
    class Program
    {
        static void Main(string[] args)
        {
            int puan;
            Random rnd = new Random();
            byte rasgele = (byte)rnd.Next(0, 1);



            for (int i = 3; i > 0; i--)
            {
                Console.WriteLine(i != 0 ? $"bilemediniz .{i} hakkınız kaldı" : "oyun bitti");
                Console.WriteLine("Rastgele Sayı Giriniz ");
                int sayı = int.Parse(Console.ReadLine());
                if(i==3 && rasgele==sayı)
                {
                    Console.WriteLine($"100 puan aldınız :");
                    puan = 100 / 1;
                    Console.WriteLine("ortalamanız={0}", puan);
                    break;
                }
                else if(i==2 && rasgele == sayı)
                {
                    Console.WriteLine($"70 puan idare eder:");
                    puan = 70 / 2;
                    Console.WriteLine("ortalamanız={0}",puan);
                    break;

                }
                else if(i==0 && rasgele == sayı)
                {
                    Console.WriteLine($"50 puan eh işte:");
                    puan = 50 / 3;
                    Console.WriteLine("ortalamanız={0}",puan);
                    break;
                }
                else if (sayı == rasgele)
                {
                    Console.WriteLine("Tebrikler Doğru Sayıyı Buldunuz");
                   
                    break;
                }

            }
            while (true)
            {

                Console.WriteLine("Çıkmak istermisiniz...? E/H");
                string cevap = Console.ReadLine();
                if (cevap == "E")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Programı kapatıp tekrar açın");
                }
            }
      
            Console.ReadKey();
        }
    }
}
