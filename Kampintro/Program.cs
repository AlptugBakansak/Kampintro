using System;

namespace Kampintro
{
    class Program
    {
        private const string V = "Kategori";

        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //Do not repeat yourself - kendini tekrarlama
            //kategori etiketi değer tutucu - alias

            string kategoriEtiketi = V;
            int ogrenciSayisi = 32000;
            double faizorani = 1.45;
            bool sistemeGirisyapmismi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");

            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu");

            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }

            if (sistemeGirisyapmismi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }



            Console.WriteLine(kategoriEtiketi);


            

            }
    }
}
