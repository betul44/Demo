using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMMetotDemo
{
    class MusteriManager
    {
        public void Ekle ( Musteri ekle)
        {
            Console.WriteLine("Müşteri Ekleme: ");
            Console.WriteLine("Müşteri eklendi!!");
            Console.WriteLine("Adı:"+ ekle.Adi);
            Console.WriteLine("Soyadı: " + ekle.Soyadi);
        }
        public void Sil (Musteri sil)
        {
            Console.WriteLine("Müşteri Silme: ");
            Console.WriteLine("Müşteri silindi!!");
            Console.WriteLine("Adı:" + sil.Adi);
            Console.WriteLine("Soyadı: " + sil.Soyadi);
        }
    
        public void Listele (Musteri listele)
        {
        Console.WriteLine("Müşteri listele: ");
        Console.WriteLine("Müşteri listelendi!!");
        Console.WriteLine("Adı:" + listele.Adi);
        Console.WriteLine("Soyadı: " + listele.Soyadi);
        }
    }
}
