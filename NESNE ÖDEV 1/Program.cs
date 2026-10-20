using System;

namespace ConsoleApp
{
    public class SayiOyunu
    {
        // 1. Kapsülleme 
        private string _deger;
        private int _sayi;

        // 2. Getter ve Setter yapıları 
        public string Deger
        {
            get { return _deger; }
            set { _deger = value; }
        }

        public int Sayi
        {
            get { return _sayi; }
            set 
            { 
                _sayi = value; 
            }
        }

        // Oyunun ana döngüsünü ve işleyişini yöneten metot
        public void OyunuBaslat()
        {
            do
            {
                Console.Write("Sayı gir :");
                Deger = Console.ReadLine(); 

                // Çıkış şartı kontrolü
                if (Deger == "N" || Deger == "n")
                {
                    break;
                }

                // Sayı formatı kontrolü
                if (int.TryParse(Deger, out int donusturulenSayi))
                {
                    Sayi = donusturulenSayi; 
                    SonucuYazdir();
                }
                else
                {
                    Console.WriteLine("Hatalı giriş! Lütfen geçerli bir tam sayı giriniz.");
                }

            } while (true);
        }

        // Tek/Çift hesaplama metodu
        private void SonucuYazdir()
        {
            if (Sayi % 2 == 0)
            {
                Console.WriteLine("Sayı çifttir");
            }
            else
            {
                Console.WriteLine("Sayı tektir");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SayiOyunu oyun = new SayiOyunu();
            
            oyun.OyunuBaslat();
        }
    }
}