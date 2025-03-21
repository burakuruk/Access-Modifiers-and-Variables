using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erişim_Belirleyiciler_ve_Değişkenler.Classes
{
    class User
    {
        private string adSoyad;
        private int yas;
        public string Email { get; set; }

        public string GetAdSoyad()
        {
            return adSoyad;
        }

        public void SetAdSoyad(string isim)
        {
            adSoyad = isim;
        }

        public int GetYas()
        {
            return yas;
        }

        public void SetYas(int kullaniciYasi)
        {
            if (kullaniciYasi > 0) 
            {
                yas = kullaniciYasi;
            }
            else
            {
                Console.WriteLine("Geçersiz yaş girdiniz.");
            }
        }

        public void BilgileriGoster()
        {
            Console.WriteLine("Ad Soyad: "+ adSoyad);
            Console.WriteLine("Yaş: "+ yas);
            Console.WriteLine("Email: "+ Email);
        }
    }
}
