using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _142802029_142802011
{
    public class IsDeneyimi : LinkedListADT
    {
        public string Ad { get; set; }
        public string Adres { get; set; }
        public string Pozisyon { get; set; }


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
                temp += "\nİş Adı: " + ((IsDeneyimi)item.Data).Ad +
                    "\nİş Adresi: " + ((IsDeneyimi)item.Data).Adres +
                    "\nPozisyonu: " + ((IsDeneyimi)item.Data).Pozisyon + Environment.NewLine;
                item = item.Next;
            }

            return temp;
        }
    }
}
