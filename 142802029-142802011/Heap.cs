using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _142802029_142802011
{
    public class Heap
    {
        private int MaxSize;
        private HeapDugumu[] heapArray;
        private int currentSize = 0;
        public Heap(int maxSize)
        {
            this.MaxSize = maxSize;
            heapArray = new HeapDugumu[maxSize];
        }
        public bool IsEmpty()
        {
            return currentSize == 0;
        }
        public bool Insert(Object value)
        {
            if (currentSize == MaxSize)
                return false;

            HeapDugumu newHeapDugumu = new HeapDugumu(value);
            heapArray[currentSize] = newHeapDugumu;
            MoveToUp(currentSize++);
            return true;
        }
        public void MoveToUp(int index)
        {
            int parent = (index - 1) / 2;
            HeapDugumu bottom = heapArray[index];
            while (index > 0 && (int)heapArray[parent].Deger.KisiBilgisi.Uygunluk < (int)bottom.Deger.KisiBilgisi.Uygunluk)
            {
                heapArray[index] = heapArray[parent];
                index = parent;
                parent = (parent - 1) / 2;
            }
            heapArray[index] = bottom;
        }
        public HeapDugumu RemoveMax()
        {
            HeapDugumu root = heapArray[0];
            heapArray[0] = heapArray[--currentSize];
            MoveToDown(0);
            return root;
        }

        public string GetMax()
        {
            int i = 0;
            HeapDugumu root = heapArray[0];
            for (i = 0; i < currentSize; i++)
            {
                heapArray[i] = heapArray[i + 1];
            }
            heapArray[i - 1] = null;
            currentSize--;
            MoveToDown(0);

            string temp = "Ad: " + root.Deger.KisiBilgisi.Ad + " Adres: " + root.Deger.KisiBilgisi.Adres
                + " Telefon: " + root.Deger.KisiBilgisi.Telefon.ToString() + " bilgilerine sahip kişi işe alınmıştır..";
            return temp;
        }
        public Kisi Root()
        {
            HeapDugumu root = heapArray[0];
            return root.Deger.KisiBilgisi;
        }
        public void MoveToDown(int index)
        {
            int largerChild;
            HeapDugumu top = heapArray[index];
            while (index < currentSize / 2)
            {
                int leftChild = 2 * index + 1;
                int rightChild = leftChild + 1;
                //Find larger child
                if (rightChild < currentSize && (int)heapArray[leftChild].Deger.KisiBilgisi.Uygunluk < (int)heapArray[rightChild].Deger.KisiBilgisi.Uygunluk)
                    largerChild = rightChild;
                else
                    largerChild = leftChild;
                if ((int)top.Deger.KisiBilgisi.Uygunluk >= (int)heapArray[largerChild].Deger.KisiBilgisi.Uygunluk)
                    break;
                heapArray[index] = heapArray[largerChild];
                index = largerChild;
            }
            heapArray[index] = top;
        }
        public int DeletePosition(Object key)
        {
            int i = 0;
            for (i = 0; i < heapArray.Length; i++)
            {
                if (heapArray[i].Deger.KisiBilgisi.Uygunluk == key.KisiBilgisi.Uygunluk)
                {
                    if (heapArray[i].Deger.KisiBilgisi.Ad == key.KisiBilgisi.Ad)
                    {
                        heapArray[i].Deger.KisiBilgisi = null;
                        heapArray[i].Deger.IlanBilgisi = null;
                        break;
                    }
                }
            }
            return i;
        }
        public void InsertPosition(int position, Object key)
        {
            for (int i = 0; i < heapArray.Length; i++)
            {
                if (i == position)
                {
                    heapArray[i].Deger.KisiBilgisi = key.KisiBilgisi;
                    heapArray[i].Deger.IlanBilgisi = key.IlanBilgisi;
                }
            }
        }
        public void Sil(int position)
        {
            int k = 0;
            for (int i = 0; i < heapArray.Length; i++)
            {
                k = i;
                if (i == position)
                {
                    if (heapArray[k + 1] != null)
                    {
                        while(heapArray[k + 1] != null)
                        {
                            heapArray[k].Deger = heapArray[k + 1].Deger;
                            k++;
                        }
                        heapArray[k] = null;
                        
                    }
                    else
                    {

                        heapArray[k] = null;
                    }

                }
            }
            currentSize--;
        }
        public void DisplayHeap(int count)
        {
            string str = "";

            for (int i = 0; i < count; i++)
            {
                str = "Ad: " + heapArray[i].Deger.KisiBilgisi.Ad +
                  "\nAdres: " + heapArray[i].Deger.KisiBilgisi.Adres +
                   "\nDoğum Tarihi: " + heapArray[i].Deger.KisiBilgisi.DogumTarihi.ToShortDateString() +
                  "\nDoğum Yeri: " + heapArray[i].Deger.KisiBilgisi.DogumYeri +
                    heapArray[i].Deger.KisiBilgisi.Egitim_Durumu.DisplayElements() +
                  "\nE-posta: " + heapArray[i].Deger.KisiBilgisi.Eposta +
                  "\nİlgi Alanları: " + heapArray[i].Deger.KisiBilgisi.IlgiAlanlari +
                "\nMedeni Durumu: " + heapArray[i].Deger.KisiBilgisi.MedeniDurum +
                  "\nReferans Olan Kişiler: " + heapArray[i].Deger.KisiBilgisi.ReferansOlanKisiler +
                 "\nTelefon: " + heapArray[i].Deger.KisiBilgisi.Telefon.ToString() +
                 "\nUygunluk: " + heapArray[i].Deger.KisiBilgisi.Uygunluk.ToString() +
                "\nUyruk: " + heapArray[i].Deger.KisiBilgisi.Uyrugu +
                  "\nYabancı Dil: " + heapArray[i].Deger.KisiBilgisi.YabanciDil +
                    heapArray[i].Deger.KisiBilgisi.Is_Deneyimi.DisplayElements() +
                    Environment.NewLine;
                MessageBox.Show(str);
            }
        }
        public bool Basvuranlar(Kisi k)
        {
            bool deger = false;
            if (currentSize == 0)
                deger = false;
            else
            {
                for (int i = 0; i < currentSize; i++)
                {
                    if ((heapArray[i].Deger.KisiBilgisi.Ad == k.Ad)
                        && (heapArray[i].Deger.KisiBilgisi.Adres == k.Adres)
                        && (heapArray[i].Deger.KisiBilgisi.DogumTarihi == k.DogumTarihi)
                        && (heapArray[i].Deger.KisiBilgisi.DogumYeri == k.DogumYeri)
                         && (heapArray[i].Deger.KisiBilgisi.Eposta == k.Eposta)
                        && (heapArray[i].Deger.KisiBilgisi.IlgiAlanlari == k.IlgiAlanlari)
                        && (heapArray[i].Deger.KisiBilgisi.MedeniDurum == k.MedeniDurum)
                        && (heapArray[i].Deger.KisiBilgisi.ReferansOlanKisiler == k.ReferansOlanKisiler)
                        && (heapArray[i].Deger.KisiBilgisi.Telefon == k.Telefon)
                        && (heapArray[i].Deger.KisiBilgisi.Uyrugu == k.Uyrugu)
                        && (heapArray[i].Deger.KisiBilgisi.YabanciDil == k.YabanciDil)
                        && (((EgitimDurumu)heapArray[i].Deger.KisiBilgisi.Egitim_Durumu.Head.Data).BaslangicTarihi == ((EgitimDurumu)k.Egitim_Durumu.Head.Data).BaslangicTarihi)
                        && (((EgitimDurumu)heapArray[i].Deger.KisiBilgisi.Egitim_Durumu.Head.Data).BitisTarihi == ((EgitimDurumu)k.Egitim_Durumu.Head.Data).BitisTarihi)
                        && (((EgitimDurumu)heapArray[i].Deger.KisiBilgisi.Egitim_Durumu.Head.Data).Bolumu == ((EgitimDurumu)k.Egitim_Durumu.Head.Data).Bolumu)
                        && (((EgitimDurumu)heapArray[i].Deger.KisiBilgisi.Egitim_Durumu.Head.Data).NotOrtalamasi == ((EgitimDurumu)k.Egitim_Durumu.Head.Data).NotOrtalamasi)
                        && (((EgitimDurumu)heapArray[i].Deger.KisiBilgisi.Egitim_Durumu.Head.Data).OkulAdi == ((EgitimDurumu)k.Egitim_Durumu.Head.Data).OkulAdi)

                        && (((EgitimDurumu)heapArray[i].Deger.KisiBilgisi.Egitim_Durumu.Head.Next.Data).BaslangicTarihi == ((EgitimDurumu)k.Egitim_Durumu.Head.Next.Data).BaslangicTarihi)
                        && (((EgitimDurumu)heapArray[i].Deger.KisiBilgisi.Egitim_Durumu.Head.Next.Data).BitisTarihi == ((EgitimDurumu)k.Egitim_Durumu.Head.Next.Data).BitisTarihi)
                        && (((EgitimDurumu)heapArray[i].Deger.KisiBilgisi.Egitim_Durumu.Head.Next.Data).Bolumu == ((EgitimDurumu)k.Egitim_Durumu.Head.Next.Data).Bolumu)
                        && (((EgitimDurumu)heapArray[i].Deger.KisiBilgisi.Egitim_Durumu.Head.Next.Data).NotOrtalamasi == ((EgitimDurumu)k.Egitim_Durumu.Head.Next.Data).NotOrtalamasi)
                        && (((EgitimDurumu)heapArray[i].Deger.KisiBilgisi.Egitim_Durumu.Head.Next.Data).OkulAdi == ((EgitimDurumu)k.Egitim_Durumu.Head.Next.Data).OkulAdi)

                        && (((IsDeneyimi)heapArray[i].Deger.KisiBilgisi.Is_Deneyimi.Head.Data).Ad == ((IsDeneyimi)k.Is_Deneyimi.Head.Data).Ad)
                        && (((IsDeneyimi)heapArray[i].Deger.KisiBilgisi.Is_Deneyimi.Head.Data).Adres == ((IsDeneyimi)k.Is_Deneyimi.Head.Data).Adres)
                        && (((IsDeneyimi)heapArray[i].Deger.KisiBilgisi.Is_Deneyimi.Head.Data).Pozisyon == ((IsDeneyimi)k.Is_Deneyimi.Head.Data).Pozisyon)

                        && (((IsDeneyimi)heapArray[i].Deger.KisiBilgisi.Is_Deneyimi.Head.Next.Data).Ad == ((IsDeneyimi)k.Is_Deneyimi.Head.Next.Data).Ad)
                        && (((IsDeneyimi)heapArray[i].Deger.KisiBilgisi.Is_Deneyimi.Head.Next.Data).Adres == ((IsDeneyimi)k.Is_Deneyimi.Head.Next.Data).Adres)
                        && (((IsDeneyimi)heapArray[i].Deger.KisiBilgisi.Is_Deneyimi.Head.Next.Data).Pozisyon == ((IsDeneyimi)k.Is_Deneyimi.Head.Next.Data).Pozisyon))
                    {
                        deger = true;
                        break;
                    }
                    else
                    {
                        deger = false;
                    }

                }
            }

            return deger;
        }

    }
}
