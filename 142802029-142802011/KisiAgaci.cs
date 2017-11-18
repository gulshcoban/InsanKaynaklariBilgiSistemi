using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _142802029_142802011
{
    public class KisiAgaci
    {

        private TreeNode kok;
        private string dugumler;
        public KisiAgaci()
        {
        }
        public KisiAgaci(TreeNode kok)
        {
            this.kok = kok;
        }
        public int DugumSayisi()
        {
            return DugumSayisi(kok);
        }
        public int DugumSayisi(TreeNode dugum)
        {
            int count = 0;
            if (dugum != null)
            {
                count = 1;
                count += DugumSayisi(dugum.sol);
                count += DugumSayisi(dugum.sag);
            }
            return count;
        }
        public string DugumleriYazdir()
        {
            return dugumler;
        }
        public void PreOrder()
        {
            dugumler = "";
            PreOrderInt(kok);
        }
        private void PreOrderInt(TreeNode dugum)
        {
            if (dugum == null)
                return;
            Ziyaret(dugum);
            PreOrderInt(dugum.sol);
            PreOrderInt(dugum.sag);
        }
        public void InOrder()
        {
            dugumler = "";
            InOrderInt(kok);
        }
        private void InOrderInt(TreeNode dugum)
        {
            if (dugum == null)
                return;
            InOrderInt(dugum.sol);
            Ziyaret(dugum);
            InOrderInt(dugum.sag);
        }
        private void Ziyaret(TreeNode dugum)
        {
            dugumler += ((Kisi)dugum.veri).Ad + Environment.NewLine;
        }
        public void PostOrder()
        {
            dugumler = "";
            PostOrderInt(kok);
        }
        private void PostOrderInt(TreeNode dugum)
        {
            if (dugum == null)
                return;
            PostOrderInt(dugum.sol);
            PostOrderInt(dugum.sag);
            Ziyaret(dugum);
        }
        public void Ekle(Kisi deger)
        {
            //Yeni eklenecek düğümün parent'ı
            TreeNode tempParent = new TreeNode();
            //Kökten başla ve ilerle
            TreeNode tempSearch = kok;
            if (deger.Ad == "")
            {
                MessageBox.Show("Isim girilmemiştir..");
                return;
            }
            char[] chrDeger = new char[deger.Ad.Length];
            chrDeger = deger.Ad.ToCharArray();
            while (tempSearch != null)
            {
                tempParent = tempSearch;
                char[] chrTempSearch = new char[tempSearch.veri.Ad.Length];
                chrTempSearch = tempSearch.veri.Ad.ToCharArray();
                if (deger.Ad != tempSearch.veri.Ad)
                {
                    int lenght = 0;
                    if (deger.Ad.Length > tempSearch.veri.Ad.Length)
                    {
                        lenght = deger.Ad.Length;
                    }
                    else
                    {
                        lenght = tempSearch.veri.Ad.Length;
                    }

                    for (int i = 0; i < lenght; i++)
                    {
                        if ((int)chrDeger[i] == (int)chrTempSearch[i])
                        {
                            continue;
                        }
                        else if ((int)chrDeger[i] < (int)chrTempSearch[i])
                        {
                            tempSearch = tempSearch.sol;
                            break;
                        }
                        else
                        {
                            tempSearch = tempSearch.sag;
                            break;
                        }
                    }
                }
                else
                {
                    if (deger.Telefon == tempSearch.veri.Telefon)
                        return;
                    else if (deger.Telefon < tempSearch.veri.Telefon)
                        tempSearch = tempSearch.sol;
                    else
                        tempSearch = tempSearch.sag;
                }
            }
            TreeNode eklenecek = new TreeNode(deger);
            if (tempParent.veri != null)
            {
                char[] chrTempParent = new char[tempParent.veri.Ad.Length];
                chrTempParent = tempParent.veri.Ad.ToCharArray();
                //Ağaç boş, köke ekle
                if (deger.Ad != tempParent.veri.Ad)
                {
                    int boyut = 0;
                    if (deger.Ad.Length > tempParent.veri.Ad.Length)
                    {
                        boyut = deger.Ad.Length;
                    }
                    else
                    {
                        boyut = tempParent.veri.Ad.Length;
                    }

                    for (int i = 0; i < boyut; i++)
                    {
                        if (kok == null)
                        {
                            kok = eklenecek;
                            break;
                        }
                        else if ((int)chrDeger[i] == (int)chrTempParent[i])
                        {
                            continue;
                        }
                        else if ((int)chrDeger[i] < (int)chrTempParent[i])
                        {
                            tempParent.sol = eklenecek;
                            break;
                        }
                        else
                        {
                            tempParent.sag = eklenecek;
                            break;
                        }

                    }
                }
                else
                {
                    if (deger.Telefon == tempParent.veri.Telefon)
                        return;
                    else if (deger.Telefon < tempParent.veri.Telefon)
                        tempParent.sol = eklenecek;
                    else
                        tempParent.sag = eklenecek;
                }
            }
            else
                kok = eklenecek;

        }
        public TreeNode Ara(Kisi anahtar)
        {
            return AraInt(kok, anahtar);
        }
        private TreeNode AraInt(TreeNode dugum, Kisi anahtar)
        {
            if (dugum == null)
                return null;
            else if (string.Compare(dugum.veri.Ad, anahtar.Ad) == 0)
                return dugum;
            else if (string.Compare(dugum.veri.Ad, anahtar.Ad) == 1)
                return (AraInt(dugum.sol, anahtar));
            else
                return (AraInt(dugum.sag, anahtar));
        }

        private TreeNode Successor(TreeNode silDugum)
        {
            TreeNode successorParent = silDugum;
            TreeNode successor = silDugum;
            TreeNode current = silDugum.sag;
            while (current != null)
            {
                successorParent = successor;
                successor = current;
                current = current.sol;
            }
            if (successor != silDugum.sag)
            {
                successorParent.sol = successor.sag;
                successor.sag = silDugum.sag;
            }
            return successor;
        }
        public bool Sil(Kisi deger)
        {
            TreeNode current = kok;
            TreeNode parent = kok;
            bool issol = true;
            //DÜĞÜMÜ BUL
            while (current.veri.Ad != deger.Ad)
            {
                parent = current;
                if (string.Compare(deger.Ad, current.veri.Ad) == -1)
                {
                    issol = true;
                    current = current.sol;
                }
                else if (string.Compare(deger.Ad, current.veri.Ad) == 1)
                {
                    issol = false;
                    current = current.sag;
                }
                else
                {
                    current.veri = deger;
                }
                if (current == null)
                    return false;
            }
            //DURUM 1: YAPRAK DÜĞÜM
            if (current.sol == null && current.sag == null)
            {
                if (current == kok)
                    kok = null;
                else if (issol)
                    parent.sol = null;
                else
                    parent.sag = null;
            }
            //DURUM 2: TEK ÇOCUKLU DÜĞÜM
            else if (current.sag == null)
            {
                if (current == kok)
                    kok = current.sol;
                else if (issol)
                    parent.sol = current.sol;
                else
                    parent.sag = current.sol;
            }
            else if (current.sol == null)
            {
                if (current == kok)
                    kok = current.sag;
                else if (issol)
                    parent.sol = current.sag;
                else
                    parent.sag = current.sag;
            }
            //DURUM 3: İKİ ÇOCUKLU DÜĞÜM
            else
            {
                TreeNode successor = Successor(current);
                if (current == kok)
                    kok = successor;
                else if (issol)
                    parent.sol = successor;
                else
                    parent.sag = successor;
                successor.sol = current.sol;
            }
            return true;
        }

        public void IngBilenleriBul()
        {
            dugumler = "";
            IngBilenleriBulInt(kok);
        }
        private void IngBilenleriBulInt(TreeNode dugum)
        {
            if (dugum == null)
                return;
            if (dugum.veri.YabanciDil == "Ingilizce" || dugum.veri.YabanciDil == "ingilizce")
            {
                Ziyaret(dugum);
            }
            IngBilenleriBulInt(dugum.sol);
            IngBilenleriBulInt(dugum.sag);
        }
        public void OrtBul()
        {
            dugumler = "";
            OrtBulInt(kok);
        }
        private void OrtBulInt(TreeNode dugum)
        {
            if (dugum == null)
                return;
            if ((((EgitimDurumu)dugum.veri.Egitim_Durumu.Head.Data).NotOrtalamasi) >= 90 || (((EgitimDurumu)dugum.veri.Egitim_Durumu.Head.Next.Data).NotOrtalamasi) >= 90)
            {
                Ziyaret(dugum);
            }
            OrtBulInt(dugum.sol);
            OrtBulInt(dugum.sag);
        }

        private void Ziyaret2(TreeNode dugum)
        {
            dugumler += "Ad: " + ((Kisi)dugum.veri).Ad +
                "\nAdres: " + ((Kisi)dugum.veri).Adres +
               "\nDoğum Tarihi: " + ((Kisi)dugum.veri).DogumTarihi.ToShortDateString() +
               "\nDoğum Yeri: " + ((Kisi)dugum.veri).DogumYeri +
               "\nE-posta: " + ((Kisi)dugum.veri).Eposta +
               "\nIlgi Alanları: " + ((Kisi)dugum.veri).IlgiAlanlari +
            "\nMedeni Durum: " + ((Kisi)dugum.veri).MedeniDurum +
            "\nReferans Olan Kişiler: " + ((Kisi)dugum.veri).ReferansOlanKisiler +
            "\nTelefon: " + ((Kisi)dugum.veri).Telefon.ToString() +
             "\nUygunluk: " + ((Kisi)dugum.veri).Uygunluk.ToString() +
            "\nUyruk: " + ((Kisi)dugum.veri).Uyrugu +
             "\nYabancı Dil: " + ((Kisi)dugum.veri).YabanciDil +
            "\nLise Başlangıç Tarihi: " + ((EgitimDurumu)dugum.veri.Egitim_Durumu.Head.Data).BaslangicTarihi.ToShortDateString() +
            "\nLise Bitiş Tarihi: " + ((EgitimDurumu)dugum.veri.Egitim_Durumu.Head.Data).BitisTarihi.ToShortDateString() +
            "\nBölüm: " + ((EgitimDurumu)dugum.veri.Egitim_Durumu.Head.Data).Bolumu +
            "\nNot Ortalaması: " + ((EgitimDurumu)dugum.veri.Egitim_Durumu.Head.Data).NotOrtalamasi.ToString() +
            "\nOkul Adı: " + ((EgitimDurumu)dugum.veri.Egitim_Durumu.Head.Data).OkulAdi +
            "\nÜniversite Başlangıç Tarihi: " + ((EgitimDurumu)dugum.veri.Egitim_Durumu.Head.Next.Data).BaslangicTarihi.ToShortDateString() +
            "\nÜniversite Bitiş Tarihi: " + ((EgitimDurumu)dugum.veri.Egitim_Durumu.Head.Next.Data).BitisTarihi.ToShortDateString() +
            "\nBölüm: " + ((EgitimDurumu)dugum.veri.Egitim_Durumu.Head.Next.Data).Bolumu +
            "\nNot Ortalaması: " + ((EgitimDurumu)dugum.veri.Egitim_Durumu.Head.Next.Data).NotOrtalamasi.ToString() +
            "\nOkul Adı: " + ((EgitimDurumu)dugum.veri.Egitim_Durumu.Head.Next.Data).OkulAdi +
            "\nİlk İş Adı: " + ((IsDeneyimi)dugum.veri.Is_Deneyimi.Head.Data).Ad +
            "\nİlk İş Adresi: " + ((IsDeneyimi)dugum.veri.Is_Deneyimi.Head.Data).Adres +
            "\nİlk İş Pozisyonu: " + ((IsDeneyimi)dugum.veri.Is_Deneyimi.Head.Data).Pozisyon +
            "\nİkinci İş Adı: " + ((IsDeneyimi)dugum.veri.Is_Deneyimi.Head.Next.Data).Ad +
            "\nİkinci İş Adresi: " + ((IsDeneyimi)dugum.veri.Is_Deneyimi.Head.Next.Data).Adres +
            "\nİkinci İş Pozisyonu: " + ((IsDeneyimi)dugum.veri.Is_Deneyimi.Head.Next.Data).Pozisyon + Environment.NewLine;
        }
        public void KisiBul(string anahtar)
        {
            dugumler = "";
            KisiBulInt(kok, anahtar);
        }
        private void KisiBulInt(TreeNode dugum, string anahtar)
        {
            if (dugum == null)
                return;
            if (string.Compare(dugum.veri.Ad, anahtar) == 0)
            {
                Ziyaret2(dugum);
            }
            KisiBulInt(dugum.sol, anahtar);
            KisiBulInt(dugum.sag, anahtar);
        }

        public int DerinlikBul()
        {
            return DerinlikBulInt(kok);
        }

        private int DerinlikBulInt(TreeNode dugum)
        {
            if (dugum == null)
                return -1;
            else
            {
                int solDerinlik = DerinlikBulInt(dugum.sol);
                int sagDerinlik = DerinlikBulInt(dugum.sag);
                if (solDerinlik > sagDerinlik)
                    return (solDerinlik + 1);
                else
                    return (sagDerinlik + 1);
            }
        }
    }
}
