using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev_Uygulama_Kalitim_
{
    class Program
    {
        static void Main(string[] args)
        {
            Bilgisayar bilgisayar = new Bilgisayar();
            bilgisayar.Markasi = "Lenova";
            bilgisayar.Modeli = "z50";
            bilgisayar.AlisFiyati = 1200M;
            bilgisayar.SatisFiyati = 1300M;
            bilgisayar.IndirimFiyati = 1000;
            bilgisayar.Barkod = "121212";
            SanalDataBase.DataEkle(bilgisayar);
            Bilgisayar bilgisayar1 = new Bilgisayar();
            bilgisayar1.Markasi = "Lenova";
            bilgisayar1.Modeli = "z50";
            bilgisayar1.AlisFiyati = 1200M;
            bilgisayar1.SatisFiyati = 1300M;
            bilgisayar1.IndirimFiyati = 1000;
            bilgisayar1.Barkod = "121212";
            SanalDataBase.DataEkle(bilgisayar1);
        }
    }
}
