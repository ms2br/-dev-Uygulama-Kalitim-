using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev_Uygulama_Kalitim_
{
    public class Urun : baseClass
    {
        public string Modeli { get; set; }
        public string Markasi { get; set; }// * Belirtmis Oldugumuz Markalar Icersinde Urun Eklensin
        public decimal AlisFiyati
        {
            get
            {
                return _AlisFiyati;
            }
            set
            {
                if (value > 0)
                    _AlisFiyati = value;
                else
                    Console.WriteLine("Alis Fiyati 0-dan Kucuk ve ya Esit Olamaz");
            }
        }// * Alis Fitai 0 dan kucuk Olmamali 
        public decimal SatisFiyati
        {
            get { return _SatisFiyati; }
            set
            {
                if (value > _AlisFiyati)
                    _SatisFiyati = value;
                else
                    Console.WriteLine("Satis Fiyati Alis Fiyatindan Kucuk ve ya Esit Olamaz");
            }
        }// * Alis Fitaindan Kucuk Olamaz 
        public decimal IndirimFiyati
        {
            get { return _IndirimFiyati; }
            set
            {
                if (value > 0)
                    _IndirimFiyati = value;
                else
                    Console.WriteLine("Indirim Fiyati 0-dan Kucuk ve ya Esit Olamaz");
            }
        }// * 0 Kucuk Olamaz 

        #region Field
        private decimal _AlisFiyati;
        private decimal _IndirimFiyati;
        private decimal _SatisFiyati;
        #endregion
    }
}
