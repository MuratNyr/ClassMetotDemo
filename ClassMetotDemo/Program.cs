// See https://aka.ms/new-console-template for more information
using ClassMetotDemo;

MusteriManager manager = new MusteriManager();
Musteri musteri = manager.MusteriEkle(1, "Murat", "Nayir");
manager.MusteriListele(musteri);