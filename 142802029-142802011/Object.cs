using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _142802029_142802011
{
    public class Object
    {
        public Ilan IlanBilgisi { get; set; }
        public Kisi KisiBilgisi { get; set; }
        public string ilangor(Ilan IlanBilgisi)
        {
            this.IlanBilgisi = IlanBilgisi;
            string temp = IlanBilgisi.SirketBilgileri.Eposta + " " + IlanBilgisi.IsTanimi + " " + IlanBilgisi.ArananElamanOzellikleri
             + " " + IlanBilgisi.SirketBilgileri.Faks + " "
             + IlanBilgisi.SirketBilgileri.IsyeriAdi + " " + IlanBilgisi.SirketBilgileri.TamAdresi
             + " " + IlanBilgisi.SirketBilgileri.Telefon.ToString();
            return temp;
        }

    }
}
