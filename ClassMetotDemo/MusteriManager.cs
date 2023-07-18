using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public Musteri MusteriEkle(int id, string ad, string soyad) 
        {
            Musteri musteri = new Musteri();
            musteri.Id = id;
            musteri.Ad = ad;
            musteri.Soyad = soyad;
            return musteri;
            //veritabanı kodlarımıza değer olarak gelen musteri.id musteri.ad musteri.soyad değerlerini kullanabiliriz
        }
        public void MusteriSil(Musteri musteri) 
        {
            //aynı şekilde buralarda da parametreden gelen değerleri sileriz.
        }
        public void MusteriListele(Musteri musteri)
        {
            Console.Write("id: {0} | Adı: {1} | Soyadı: {2}", musteri.Id, musteri.Ad, musteri.Soyad);
            //Bu kısımda gelen değeri direk listeleme işlemi yapabiliriz
        }
    }
}
