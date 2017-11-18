using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _142802029_142802011
{
    public class EgitimDurumu : LinkedListADT
    {
        public string OkulAdi { get; set; }
        public string Bolumu { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public double NotOrtalamasi { get; set; }


        public override void InsertLast(object value)
        {
            Node tempLast = new Node();
            tempLast.Data = value;
            if (Head == null)
            {
                Head = tempLast;
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = tempLast;
            }
            tempLast.Next = null;
            Size++;
        }

        public override string DisplayElements()
        {
            string temp = "";
            Node item = Head;
            while (item != null)
            {
                temp += "Başlangıç Tarihi: " + ((EgitimDurumu)item.Data).BaslangicTarihi.ToShortDateString() +
                   "\nBitiş Tarihi: " + ((EgitimDurumu)item.Data).BitisTarihi.ToShortDateString() +
                   "\nBölümü: " + ((EgitimDurumu)item.Data).Bolumu + "\nOkul Adı: " + ((EgitimDurumu)item.Data).OkulAdi +
                    "\nNot Ortalaması: " + ((EgitimDurumu)item.Data).NotOrtalamasi.ToString() + Environment.NewLine;
                item = item.Next;
            }
            return temp;
        }
    }
}
