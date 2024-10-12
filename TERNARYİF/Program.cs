using System;

namespace TERNARYİF
{
    internal class Program
    {          static void Main(string[] args)
        {
            /* Console.WriteLine("CİNSİYET GİRİNİZ: 1.ERKEK \n 2.KADIN");
            var deger=Console.ReadLine();
            var sonuc = deger =="1" ? "ERKEK" :"KADIN";
            Console.WriteLine(sonuc);
            */



            //TERNARY İF : ÜÇLÜ EĞER 
            //DEGER=KOŞUL?TRUE;FALSE 
            //EĞER ATAMA YAPILACAKSA İF ELSE KULLANIRIZ.
          Console.WriteLine("NOTUNUZU GİRİN :");
            var not =Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("NOTUNUZ {0}",not < 25 ? "FF-KALDI" : not >= 25 & not <= 50 ? "FD" : not >= 50 & not <= 60 ? "DD" : not >= 60 & not <= 70 ? "DC" : "AA-GEÇTİ"  );


            // 

            //1.DERLEME ZAMANI HATALAR:


            
        }
    }
}
