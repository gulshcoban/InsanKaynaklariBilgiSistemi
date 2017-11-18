using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _142802029_142802011
{
    public class Kisi
    {
        public double Uygunluk { get; set; }
        public string Ad { get; set; }
        public string Adres { get; set; }
        public long Telefon { get; set; }
        public string Eposta { get; set; }
        public string Uyrugu { get; set; }
        public string DogumYeri { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string MedeniDurum { get; set; }
        public string YabanciDil { get; set; }
        public string IlgiAlanlari { get; set; }
        public string ReferansOlanKisiler { get; set; }
        public EgitimDurumu Egitim_Durumu { get; set; }
        public IsDeneyimi Is_Deneyimi { get; set; }
        Random rnd = new Random();
        public Kisi()
        {
            this.Uygunluk = rnd.Next(0, 10);
        }

    }
}
