using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev_Uygulama_Kalitim_
{
    public class baseClass
    {
        public static int sayac = 1;
        private int id;
        public int IdAtama
        {
            get
            {
                return id;
            }
            private set
            {
                //id = sayac;
                //sayac++;
                //Nedeni Basit Set Alanini Pribvate Olarak Isaretlendir...Zaten Deger Atilmiyor Dolayisi Olarak Deger Atilamiyor 
            }
        }
        public baseClass()
        {
            id = sayac;
            sayac++;
        }
        private string _Barkod;
        public string Barkod
        {
            get { return _Barkod; }
            set
            {
                if (SanalDataBase.DataGozetmeni(value) != false)
                {
                    _Barkod = value;
                }
                else
                {
                    Console.WriteLine("Bu Barkod Daha Once Kayt Edilmisdir");
                }
            }
        }// *
        public DateTime OlusturmaTarihi { get; set; }
        public int OlusturanKullanici { get; set; }
        public DateTime GuncellemeTarih { get; set; }
        public int GuncelleyenKullanici { get; set; }
        public bool Silindi { get; set; }
    }
}
