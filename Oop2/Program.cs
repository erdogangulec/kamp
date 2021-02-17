using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.Adi = "Erdoğan";
            musteri1.Soyadi = "Güleç";
            musteri1.TcNo = "234325324";


            TuzelMusteri musteri2 = new TuzelMusteri();
            TuzelMusteri musteri21 = musteri2;
            musteri21.Id = 2;
            musteri2.VergiNo = "13254612346";
            musteri2.SirketAdi = "Gulec";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);


        }
    }
}
