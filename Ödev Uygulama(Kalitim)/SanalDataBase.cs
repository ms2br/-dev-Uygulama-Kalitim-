using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev_Uygulama_Kalitim_
{
    public static class SanalDataBase
    {
        private static ArrayList DataBase;
        static SanalDataBase()
        {
            DataBase = new ArrayList();
        }

        public static void DataEkle(baseClass Data)
        {
            if (Data != null && !string.IsNullOrEmpty(Data.Barkod) && DataGozetmeni(Data.Barkod) != false)
                DataBase.Add(Data);
        }

        public static bool DataGozetmeni(string barkod)
        {
            bool gozetmen = true;
            if (DataBase != null && DataBase.Count > 0)
            {
                for (int i = 0; i < DataBase.Count; i++)
                {
                    baseClass Temp = (baseClass)DataBase[i];
                    if (Temp.Barkod == barkod)
                    {
                        gozetmen = false;
                        break;
                    }
                }
            }
            return gozetmen;
        }
    }
}
