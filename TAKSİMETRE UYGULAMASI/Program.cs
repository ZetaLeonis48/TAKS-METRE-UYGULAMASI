namespace TAKSİMETRE_UYGULAMASI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var acilisUcreti = 150;
            var kilometreUcreti = 25;
            double toplamUcret = 0;
            double geceTarifesi = 1.2;
            Console.WriteLine($"Açılış ücretiniz {acilisUcreti} TL' dir.");
        mesafe:
            Console.WriteLine("Gidilen mesafeyi (KM) giriniz.");
            int mesafe = Convert.ToInt32(Console.ReadLine());
            if (mesafe < 0)
            {
                Console.WriteLine("Mesafe 0 dan küçük olamaz lütfen tekrar giriş yapınız.");
                goto mesafe;
            }
        hesaplama:
            Console.WriteLine("Gece tarifesi ise 1'i gündüz tarifesi ise 2 yi tuşlayın.");
            var tarife = Convert.ToInt32(Console.ReadLine());
            if (tarife == 1)
            {
                mesafe *= kilometreUcreti;
                toplamUcret += mesafe;
                toplamUcret *= geceTarifesi;
                toplamUcret += acilisUcreti;

                Console.WriteLine($"Gece tarifesinde ödemeniz gereken tutar {toplamUcret} TL'dir.");
            }
            else if (tarife == 2)
            {
                mesafe *= kilometreUcreti;
                toplamUcret += mesafe;
                toplamUcret += acilisUcreti;
                Console.WriteLine($"Ödemeniz gereken tutar {toplamUcret} TL'dir.");
            }
            else
            {
                Console.WriteLine("Geçersiz bir tuşlama yaptınız lütfen tekrar deneyiniz.");
                goto hesaplama;

            }


                




        }
    }
}
