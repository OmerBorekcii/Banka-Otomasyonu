namespace Banka_Otomasyonu
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            decimal bakiye = 1000;
            decimal yatırma_tutar = 0;
            decimal cekme_tutar = 0;
            int secim;

            while (true)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("---------Banka Otomasyonu-----------");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("       Bankamıza Hoşgeldiniz      ");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("(1) Para Yatırma");
                Console.WriteLine("(2) Para Çekme");
                Console.WriteLine("(3) Bakiye Görüntülüme");
                Console.WriteLine("(4) Çıkış");
                Console.WriteLine("------------------------------------");
                Console.Write("Lütfen Yapmak İstediğiniz İşlemin Numarısını Giriniz:");
                
                while (!int.TryParse(Console.ReadLine(), out secim))
                {
                    Console.Write("Geçerli bir sayı giriniz:");
                }


                switch (secim)
                {
                    case 1:
                        {
                            Console.Write("Yatırmak İstediğiniz Tutar: ");
                            while (!decimal.TryParse(Console.ReadLine(), out yatırma_tutar))
                            {
                                Console.Write("Geçerli bir sayı giriniz:");
                            }

                            para_yatirma(ref bakiye, yatırma_tutar);

                            break;
                        }
                    case 2:
                        {
                            Console.Write("Çekmek İstediğiniz Tutar: ");
                            while (!decimal.TryParse(Console.ReadLine(), out cekme_tutar))
                            {
                                Console.Write("Geçerli bir sayı giriniz:");
                            }

                            para_cekme(ref bakiye, cekme_tutar);

                            break;
                        }
                    case 3:
                        {
                            bakiye_goruntule(bakiye);

                            break;
                        }
                    case 4:
                        {
                            Cikis();

                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Geçersiz Giriş Tekrar Deneyiniz");

                            break;
                        }
                }
            }
        }

        private static void Cikis()
        {
            Console.WriteLine("Çıkış yapılıyor...");
            Environment.Exit(0);
        }

        private static void bakiye_goruntule(decimal bakiye)
        {
            Console.WriteLine($"Bakiye -> {bakiye}");
        }

        private static void para_yatirma(ref decimal bakiye,decimal yatırma_tutar)
        {
            if (yatırma_tutar <= 0)
            {
                Console.WriteLine("Geçersiz Tutar");
                return;
            }

            bakiye = bakiye + yatırma_tutar;

            Console.WriteLine($"{yatırma_tutar} TL Yatırılıyor");
            Console.WriteLine($"{yatırma_tutar} TL Yatırıldı");
            Console.WriteLine($"Yeni Bakiye {bakiye} TL");
        }

        private static void para_cekme(ref decimal bakiye,decimal cekme_tutar)
        {           
            if (cekme_tutar > bakiye)
            {
                Console.WriteLine("Bakiye Yetersiz");
                return;
            }

            if (cekme_tutar <= 0)
            {
                Console.WriteLine("Geçersiz Tutar");
                return;
            }

            bakiye = bakiye - cekme_tutar;

            Console.WriteLine($"{cekme_tutar} TL Çekiliyor");
            Console.WriteLine($"{cekme_tutar} TL Çekildi");
            Console.WriteLine($"Kalan Bakiye {bakiye} TL");

        }
    }
}
