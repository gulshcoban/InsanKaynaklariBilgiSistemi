using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _142802029_142802011
{
    public partial class frmBasvuruYap : Form
    {
        public static Object a;
        public static Kisi k;

        public frmBasvuruYap()
        {
            InitializeComponent();
        }
        public static KisiAgaci ka = new KisiAgaci();
        
        private static void DosyayaYaz(Kisi n)
        {
            string dosya_yolu = @"C:\Users\Hüseyin\Desktop\142802029-142802011\eleman.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(n.Ad);
            sw.WriteLine(n.Adres);
            sw.WriteLine(n.DogumTarihi);
            sw.WriteLine(n.DogumYeri);
            sw.WriteLine(n.Eposta);
            sw.WriteLine(n.IlgiAlanlari);
            sw.WriteLine(n.MedeniDurum);
            sw.WriteLine(n.ReferansOlanKisiler);
            sw.WriteLine(n.Telefon);
            sw.WriteLine(n.Uygunluk);
            sw.WriteLine(n.Uyrugu);
            sw.WriteLine(n.YabanciDil);
            sw.WriteLine(((EgitimDurumu)n.Egitim_Durumu.Head.Data).BaslangicTarihi);
            sw.WriteLine(((EgitimDurumu)n.Egitim_Durumu.Head.Data).BitisTarihi);
            sw.WriteLine(((EgitimDurumu)n.Egitim_Durumu.Head.Data).Bolumu);
            sw.WriteLine(((EgitimDurumu)n.Egitim_Durumu.Head.Data).NotOrtalamasi);
            sw.WriteLine(((EgitimDurumu)n.Egitim_Durumu.Head.Data).OkulAdi);

            sw.WriteLine(((EgitimDurumu)n.Egitim_Durumu.Head.Next.Data).BaslangicTarihi);
            sw.WriteLine(((EgitimDurumu)n.Egitim_Durumu.Head.Next.Data).BitisTarihi);
            sw.WriteLine(((EgitimDurumu)n.Egitim_Durumu.Head.Next.Data).Bolumu);
            sw.WriteLine(((EgitimDurumu)n.Egitim_Durumu.Head.Next.Data).NotOrtalamasi);
            sw.WriteLine(((EgitimDurumu)n.Egitim_Durumu.Head.Next.Data).OkulAdi);

            sw.WriteLine(((IsDeneyimi)n.Is_Deneyimi.Head.Data).Ad);
            sw.WriteLine(((IsDeneyimi)n.Is_Deneyimi.Head.Data).Adres);
            sw.WriteLine(((IsDeneyimi)n.Is_Deneyimi.Head.Data).Pozisyon);

            sw.WriteLine(((IsDeneyimi)n.Is_Deneyimi.Head.Next.Data).Ad);
            sw.WriteLine(((IsDeneyimi)n.Is_Deneyimi.Head.Next.Data).Adres);
            sw.WriteLine(((IsDeneyimi)n.Is_Deneyimi.Head.Next.Data).Pozisyon);
            
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        private static Kisi DosyayıOku()
        {
            Kisi kisi = new Kisi();
            EgitimDurumu e = new EgitimDurumu();
            EgitimDurumu e2 = new EgitimDurumu();
            IsDeneyimi i = new IsDeneyimi();
            IsDeneyimi i2 = new IsDeneyimi();
            string dosya_yolu = @"C:\Users\Hüseyin\Desktop\142802029-142802011\eleman.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);

            kisi.Ad = sr.ReadLine();
            kisi.Adres = sr.ReadLine();
            kisi.DogumTarihi = Convert.ToDateTime(sr.ReadLine());
            kisi.DogumYeri = sr.ReadLine();
            kisi.Eposta = sr.ReadLine();
            kisi.IlgiAlanlari = sr.ReadLine();
            kisi.MedeniDurum = sr.ReadLine();
            kisi.ReferansOlanKisiler = sr.ReadLine();
            kisi.Telefon = Convert.ToInt64(sr.ReadLine());
            kisi.Uygunluk = Convert.ToDouble(sr.ReadLine());
            kisi.Uyrugu = sr.ReadLine();
            kisi.YabanciDil = sr.ReadLine();

            e.BaslangicTarihi = Convert.ToDateTime(sr.ReadLine());
            e.BitisTarihi = Convert.ToDateTime(sr.ReadLine());
            e.Bolumu = Convert.ToString(sr.ReadLine());
            e.NotOrtalamasi = Convert.ToDouble(sr.ReadLine());
            e.OkulAdi = Convert.ToString(sr.ReadLine());

            e2.BaslangicTarihi = Convert.ToDateTime(sr.ReadLine());
            e2.BitisTarihi = Convert.ToDateTime(sr.ReadLine());
            e2.Bolumu = Convert.ToString(sr.ReadLine());
            e2.NotOrtalamasi = Convert.ToDouble(sr.ReadLine());
            e2.OkulAdi = Convert.ToString(sr.ReadLine());

            e.InsertLast(e);
            e.InsertLast(e2);
            kisi.Egitim_Durumu = e;

            i.Ad = Convert.ToString(sr.ReadLine());
            i.Adres = Convert.ToString(sr.ReadLine());
            i.Pozisyon = Convert.ToString(sr.ReadLine());

            i2.Ad = Convert.ToString(sr.ReadLine());
            i2.Adres = Convert.ToString(sr.ReadLine());
            i2.Pozisyon = Convert.ToString(sr.ReadLine());

            i.InsertLast(i);
            i.InsertLast(i2);
            kisi.Is_Deneyimi = i;

            sr.Close();
            fs.Close();
            File.Delete(@"C:\Users\Hüseyin\Desktop\142802029-142802011\eleman.txt");
            return kisi;
        }
        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Heap h = new Heap(10);
            EgitimDurumu ed = new EgitimDurumu();
            ed.OkulAdi = txtLiseAdi.Text;
            ed.Bolumu = txtBolum.Text;
            ed.BaslangicTarihi = Convert.ToDateTime(dateTimeBaslangic.Text);
            ed.BitisTarihi = Convert.ToDateTime(dateTimeBitis.Text);
            ed.NotOrtalamasi = Convert.ToDouble(txtNotOrt.Text);
            ed.InsertLast(ed);

            EgitimDurumu ed2 = new EgitimDurumu();
            ed2.OkulAdi = txtUniAdi.Text;
            ed2.Bolumu = txtBolum2.Text;
            ed2.BaslangicTarihi = Convert.ToDateTime(dateTimeBaslangic2.Text);
            ed2.BitisTarihi = Convert.ToDateTime(dateTimeBitis2.Text);
            ed2.NotOrtalamasi = Convert.ToDouble(txtNotOrt2.Text);
            ed.InsertLast(ed2);


            IsDeneyimi id = new IsDeneyimi();
            id.Ad = txtIsAdi.Text;
            id.Adres = txtIsAdresi.Text;
            id.Pozisyon = txtPozisyon.Text;
            id.InsertLast(id);

            IsDeneyimi id2 = new IsDeneyimi();
            id2.Ad = txtIsAdi2.Text;
            id2.Adres = txtIsAdresi2.Text;
            id2.Pozisyon = txtPozisyon2.Text;
            id.InsertLast(id2);


            k = new Kisi();
            a = new Object();
            k.Ad = txtAd.Text;
            k.Adres = txtAdres.Text;
            k.DogumTarihi = Convert.ToDateTime(dateTimePicker1.Text);
            k.DogumYeri = txtDogumYeri.Text;
            k.Eposta = txtEposta.Text;
            k.IlgiAlanlari = txtIlgiAlanlari.Text;
            k.MedeniDurum = txtMedeniDurum.Text;
            k.ReferansOlanKisiler = txtReferans.Text;
            k.Telefon = Convert.ToInt64(txtTelefon.Text);
            k.Uyrugu = txtUyrugu.Text;
            k.YabanciDil = txtYabanciDil.Text;
            k.Egitim_Durumu = ed;
            k.Is_Deneyimi = id;
            DosyayaYaz(k);
            a.KisiBilgisi = DosyayıOku();
            bool isApply = false;

            a.IlanBilgisi = frmIlanVer.c.IlanBilgisi;

            if (frmIlanVer.dizi[0] == frmIlanVer.c.IlanBilgisi)
            {
                isApply = frmIlanVer.heap1.Basvuranlar(k);
                if (isApply == false)
                {
                    frmDetaylar.count1++;
                    frmIlanVer.heap1.Insert(a);
                    h = frmIlanVer.heap1;
                    ka.Ekle(a.KisiBilgisi);
                    MessageBox.Show("Kaydedildi!");
                }
                else
                    MessageBox.Show("Daha önce böyle bir başvuru alınmıştır. Tekrar aynı ilana başvuru yapamazsınız.");

            }
            if (frmIlanVer.dizi[1] == frmIlanVer.c.IlanBilgisi)
            {
                isApply = frmIlanVer.heap2.Basvuranlar(k);
                if (isApply == false)
                {
                    frmDetaylar.count2++;
                    frmIlanVer.heap2.Insert(a);
                    h = frmIlanVer.heap2;
                    ka.Ekle(a.KisiBilgisi);
                    MessageBox.Show("Kaydedildi!");

                }
                else
                    MessageBox.Show("Daha önce böyle bir başvuru alınmıştır. Tekrar aynı ilana başvuru yapamazsınız.");

            }
            if (frmIlanVer.dizi[2] == frmIlanVer.c.IlanBilgisi)
            {
                isApply = frmIlanVer.heap3.Basvuranlar(k);
                if (isApply == false)
                {
                    frmDetaylar.count3++;
                    frmIlanVer.heap3.Insert(a);
                    h = frmIlanVer.heap3;
                    ka.Ekle(a.KisiBilgisi);
                    MessageBox.Show("Kaydedildi!");
                }
                else
                    MessageBox.Show("Daha önce böyle bir başvuru alınmıştır. Tekrar aynı ilana başvuru yapamazsınız.");
            }
            if (frmIlanVer.dizi[3] == frmIlanVer.c.IlanBilgisi)
            {
                isApply = frmIlanVer.heap4.Basvuranlar(k);
                if (isApply == false)
                {
                    frmDetaylar.count4++;
                    frmIlanVer.heap4.Insert(a);
                    h = frmIlanVer.heap4;
                    ka.Ekle(a.KisiBilgisi);
                    MessageBox.Show("Kaydedildi!");
                }
                else
                    MessageBox.Show("Daha önce böyle bir başvuru alınmıştır. Tekrar aynı ilana başvuru yapamazsınız.");
            }
            if (frmIlanVer.dizi[4] == frmIlanVer.c.IlanBilgisi)
            {
                isApply = frmIlanVer.heap5.Basvuranlar(k);
                if (isApply == false)
                {
                    frmDetaylar.count5++;
                    frmIlanVer.heap5.Insert(a);
                    h = frmIlanVer.heap5;
                    ka.Ekle(a.KisiBilgisi);
                    MessageBox.Show("Kaydedildi!");
                }
                else
                    MessageBox.Show("Daha önce böyle bir başvuru alınmıştır. Tekrar aynı ilana başvuru yapamazsınız.");
            }
            if (frmIlanVer.dizi[5] == frmIlanVer.c.IlanBilgisi)
            {
                isApply = frmIlanVer.heap6.Basvuranlar(k);
                if (isApply == false)
                {
                    frmDetaylar.count6++;
                    frmIlanVer.heap6.Insert(a);
                    h = frmIlanVer.heap6;
                    ka.Ekle(a.KisiBilgisi);
                    MessageBox.Show("Kaydedildi!");
                }
                else
                    MessageBox.Show("Daha önce böyle bir başvuru alınmıştır. Tekrar aynı ilana başvuru yapamazsınız.");
            }
            if (frmIlanVer.dizi[6] == frmIlanVer.c.IlanBilgisi)
            {
                isApply = frmIlanVer.heap7.Basvuranlar(k);
                if (isApply == false)
                {
                    frmDetaylar.count7++;
                    frmIlanVer.heap7.Insert(a);
                    h = frmIlanVer.heap7;
                    ka.Ekle(a.KisiBilgisi);
                    MessageBox.Show("Kaydedildi!");
                }
                else
                    MessageBox.Show("Daha önce böyle bir başvuru alınmıştır. Tekrar aynı ilana başvuru yapamazsınız.");
            }
            if (frmIlanVer.dizi[7] == frmIlanVer.c.IlanBilgisi)
            {
                isApply = frmIlanVer.heap8.Basvuranlar(k);
                if (isApply == false)
                {
                    frmDetaylar.count8++;
                    frmIlanVer.heap8.Insert(a);
                    h = frmIlanVer.heap8;
                    ka.Ekle(a.KisiBilgisi);
                    MessageBox.Show("Kaydedildi!");
                }
                else
                    MessageBox.Show("Daha önce böyle bir başvuru alınmıştır. Tekrar aynı ilana başvuru yapamazsınız.");
            }
            if (frmIlanVer.dizi[8] == frmIlanVer.c.IlanBilgisi)
            {
                isApply = frmIlanVer.heap9.Basvuranlar(k);
                if (isApply == false)
                {
                    frmDetaylar.count9++;
                    frmIlanVer.heap9.Insert(a);
                    h = frmIlanVer.heap9;
                    ka.Ekle(a.KisiBilgisi);
                    MessageBox.Show("Kaydedildi!");
                }
                else
                    MessageBox.Show("Daha önce böyle bir başvuru alınmıştır. Tekrar aynı ilana başvuru yapamazsınız.");
            }
            if (frmIlanVer.dizi[9] == frmIlanVer.c.IlanBilgisi)
            {
                isApply = frmIlanVer.heap10.Basvuranlar(k);
                if (isApply == false)
                {
                    frmDetaylar.count10++;
                    frmIlanVer.heap10.Insert(a);
                    h = frmIlanVer.heap10;
                    ka.Ekle(a.KisiBilgisi);
                    MessageBox.Show("Kaydedildi!");
                }
                else
                    MessageBox.Show("Daha önce böyle bir başvuru alınmıştır. Tekrar aynı ilana başvuru yapamazsınız.");
            }

            frmAnasayfa.hash.AddBilgi(frmIlanVer.c.IlanBilgisi.IlanNo, h);
            txtAd.ReadOnly = txtAdres.ReadOnly = txtBolum.ReadOnly = txtBolum2.ReadOnly = txtDogumYeri.ReadOnly =
                txtEposta.ReadOnly = txtIlgiAlanlari.ReadOnly = txtIsAdi.ReadOnly = txtIsAdi2.ReadOnly = txtIsAdresi.ReadOnly
                = txtIsAdresi2.ReadOnly = txtLiseAdi.ReadOnly = txtMedeniDurum.ReadOnly = txtNotOrt.ReadOnly = txtNotOrt2.ReadOnly
                = txtPozisyon.ReadOnly = txtPozisyon2.ReadOnly = txtReferans.ReadOnly = txtTelefon.ReadOnly = txtUniAdi.ReadOnly
                = txtUyrugu.ReadOnly = txtYabanciDil.ReadOnly = true;
            dateTimeBaslangic.Enabled = dateTimeBaslangic2.Enabled = dateTimeBitis.Enabled = dateTimeBitis2.Enabled
                = dateTimePicker1.Enabled = false;

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int temp = 0;
            if (frmIlanVer.dizi[0] == frmIlanVer.c.IlanBilgisi)
            {
                temp = frmIlanVer.heap1.DeletePosition(a);
                frmIlanVer.heap1.Sil(temp);
                ka.Sil(k);
                temp = 0;
                frmDetaylar.count1--;
            }
            if (frmIlanVer.dizi[1] == frmIlanVer.c.IlanBilgisi)
            {
                temp = frmIlanVer.heap2.DeletePosition(a);
                frmIlanVer.heap2.Sil(temp);
                ka.Sil(k);
                temp = 0;
                frmDetaylar.count2--;
            }
            if (frmIlanVer.dizi[2] == frmIlanVer.c.IlanBilgisi)
            {
                temp = frmIlanVer.heap3.DeletePosition(a);
                frmIlanVer.heap3.Sil(temp);
                ka.Sil(k);
                temp = 0;
                frmDetaylar.count3--;
            }
            if (frmIlanVer.dizi[3] == frmIlanVer.c.IlanBilgisi)
            {
                temp = frmIlanVer.heap4.DeletePosition(a);
                frmIlanVer.heap4.Sil(temp);
                ka.Sil(k);
                temp = 0;
                frmDetaylar.count4--;
            }
            if (frmIlanVer.dizi[4] == frmIlanVer.c.IlanBilgisi)
            {
                temp = frmIlanVer.heap5.DeletePosition(a);
                frmIlanVer.heap5.Sil(temp);
                ka.Sil(k);
                temp = 0;
                frmDetaylar.count5--;
            }
            if (frmIlanVer.dizi[5] == frmIlanVer.c.IlanBilgisi)
            {
                temp = frmIlanVer.heap6.DeletePosition(a);
                frmIlanVer.heap6.Sil(temp);
                ka.Sil(k);
                temp = 0;
                frmDetaylar.count6--;
            }
            if (frmIlanVer.dizi[6] == frmIlanVer.c.IlanBilgisi)
            {
                temp = frmIlanVer.heap7.DeletePosition(a);
                frmIlanVer.heap7.Sil(temp);
                ka.Sil(k);
                temp = 0;
                frmDetaylar.count7--;
            }
            if (frmIlanVer.dizi[7] == frmIlanVer.c.IlanBilgisi)
            {
                temp = frmIlanVer.heap8.DeletePosition(a);
                frmIlanVer.heap8.Sil(temp);
                ka.Sil(k);
                temp = 0;
                frmDetaylar.count8--;
            }
            if (frmIlanVer.dizi[8] == frmIlanVer.c.IlanBilgisi)
            {
                temp = frmIlanVer.heap9.DeletePosition(a);
                frmIlanVer.heap9.Sil(temp);
                ka.Sil(k);
                temp = 0;
                frmDetaylar.count9--;
            }
            if (frmIlanVer.dizi[9] == frmIlanVer.c.IlanBilgisi)
            {
                temp = frmIlanVer.heap10.DeletePosition(a);
                frmIlanVer.heap10.Sil(temp);
                ka.Sil(k);
                temp = 0;
                frmDetaylar.count10--;
            }
            
            MessageBox.Show("Kişi silindi..");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ka.Sil(a.KisiBilgisi);

            if (k.Ad != txtAd.Text)
                k.Ad = txtAd.Text;
            if (k.Adres != txtAdres.Text)
                k.Adres = txtAdres.Text;
            if (k.DogumTarihi != Convert.ToDateTime(dateTimePicker1.Text))
                k.DogumTarihi = Convert.ToDateTime(dateTimePicker1.Text);
            if (k.DogumYeri != txtDogumYeri.Text)
                k.DogumYeri = txtDogumYeri.Text;
            if (k.Eposta != txtEposta.Text)
                k.Eposta = txtEposta.Text;
            if (k.IlgiAlanlari != txtIlgiAlanlari.Text)
                k.IlgiAlanlari = txtIlgiAlanlari.Text;
            if (k.MedeniDurum != txtMedeniDurum.Text)
                k.MedeniDurum = txtMedeniDurum.Text;
            if (k.ReferansOlanKisiler != txtReferans.Text)
                k.ReferansOlanKisiler = txtReferans.Text;
            if (k.Telefon != Convert.ToInt64(txtTelefon.Text))
                k.Telefon = Convert.ToInt64(txtTelefon.Text);
            if (k.Uyrugu != txtUyrugu.Text)
                k.Uyrugu = txtUyrugu.Text;
            if (k.YabanciDil != txtYabanciDil.Text)
                k.YabanciDil = txtYabanciDil.Text;
            if (((EgitimDurumu)k.Egitim_Durumu.Head.Data).BaslangicTarihi.ToShortDateString() != dateTimeBaslangic.Text)
                (((EgitimDurumu)k.Egitim_Durumu.Head.Data).BaslangicTarihi) = Convert.ToDateTime(dateTimeBaslangic.Text);
            if (((EgitimDurumu)k.Egitim_Durumu.Head.Data).BitisTarihi.ToShortDateString() != dateTimeBitis.Text)
                (((EgitimDurumu)k.Egitim_Durumu.Head.Data).BitisTarihi) = Convert.ToDateTime(dateTimeBitis.Text);
            if (((EgitimDurumu)k.Egitim_Durumu.Head.Data).Bolumu != txtBolum.Text)
                ((EgitimDurumu)k.Egitim_Durumu.Head.Data).Bolumu = txtBolum.Text;
            if (((EgitimDurumu)k.Egitim_Durumu.Head.Data).NotOrtalamasi != Convert.ToInt32(txtNotOrt.Text))
                ((EgitimDurumu)k.Egitim_Durumu.Head.Data).NotOrtalamasi = Convert.ToInt32(txtNotOrt.Text);
            if (((EgitimDurumu)k.Egitim_Durumu.Head.Data).OkulAdi != txtLiseAdi.Text)
                ((EgitimDurumu)k.Egitim_Durumu.Head.Data).OkulAdi = txtLiseAdi.Text;

            if (((EgitimDurumu)k.Egitim_Durumu.Head.Next.Data).BaslangicTarihi.ToShortDateString() != dateTimeBaslangic2.Text)
                (((EgitimDurumu)k.Egitim_Durumu.Head.Next.Data).BaslangicTarihi) = Convert.ToDateTime(dateTimeBaslangic2.Text);
            if (((EgitimDurumu)k.Egitim_Durumu.Head.Next.Data).BitisTarihi.ToShortDateString() != dateTimeBitis2.Text)
                (((EgitimDurumu)k.Egitim_Durumu.Head.Next.Data).BitisTarihi) = Convert.ToDateTime(dateTimeBitis2.Text);
            if (((EgitimDurumu)k.Egitim_Durumu.Head.Next.Data).Bolumu != txtBolum2.Text)
                ((EgitimDurumu)k.Egitim_Durumu.Head.Next.Data).Bolumu = txtBolum2.Text;
            if (((EgitimDurumu)k.Egitim_Durumu.Head.Next.Data).NotOrtalamasi != Convert.ToInt32(txtNotOrt2.Text))
                ((EgitimDurumu)k.Egitim_Durumu.Head.Next.Data).NotOrtalamasi = Convert.ToInt32(txtNotOrt2.Text);
            if (((EgitimDurumu)k.Egitim_Durumu.Head.Next.Data).OkulAdi != txtUniAdi.Text)
                ((EgitimDurumu)k.Egitim_Durumu.Head.Next.Data).OkulAdi = txtUniAdi.Text;


            if (((IsDeneyimi)k.Is_Deneyimi.Head.Data).Ad != txtIsAdi.Text)
                ((IsDeneyimi)k.Is_Deneyimi.Head.Data).Ad = txtIsAdi.Text;
            if (((IsDeneyimi)k.Is_Deneyimi.Head.Data).Adres != txtIsAdresi.Text)
                ((IsDeneyimi)k.Is_Deneyimi.Head.Data).Adres = txtIsAdresi.Text;
            if (((IsDeneyimi)k.Is_Deneyimi.Head.Data).Pozisyon != txtPozisyon.Text)
                ((IsDeneyimi)k.Is_Deneyimi.Head.Data).Pozisyon = txtPozisyon.Text;


            if (((IsDeneyimi)k.Is_Deneyimi.Head.Next.Data).Ad != txtIsAdi2.Text)
                ((IsDeneyimi)k.Is_Deneyimi.Head.Next.Data).Ad = txtIsAdi2.Text;
            if (((IsDeneyimi)k.Is_Deneyimi.Head.Next.Data).Adres != txtIsAdresi2.Text)
                ((IsDeneyimi)k.Is_Deneyimi.Head.Next.Data).Adres = txtIsAdresi2.Text;
            if (((IsDeneyimi)k.Is_Deneyimi.Head.Next.Data).Pozisyon != txtPozisyon2.Text)
                ((IsDeneyimi)k.Is_Deneyimi.Head.Next.Data).Pozisyon = txtPozisyon2.Text;
            
            DosyayaYaz(k);
            int temp = 0;

            
            if (frmIlanVer.dizi[0] == frmIlanVer.c.IlanBilgisi)
            {
                temp = frmIlanVer.heap1.DeletePosition(a);
                a.KisiBilgisi = DosyayıOku();
                a.IlanBilgisi = frmIlanVer.c.IlanBilgisi;
                frmIlanVer.heap1.InsertPosition(temp, a);
                temp = 0;
            }
            if (frmIlanVer.dizi[1] == frmIlanVer.c.IlanBilgisi)
            {
                temp = frmIlanVer.heap2.DeletePosition(a);
                a.KisiBilgisi = DosyayıOku();
                a.IlanBilgisi = frmIlanVer.c.IlanBilgisi;
                frmIlanVer.heap2.InsertPosition(temp, a);
                temp = 0;
            }
            if (frmIlanVer.dizi[2] == frmIlanVer.c.IlanBilgisi)
            {
                temp = frmIlanVer.heap3.DeletePosition(a);
                a.KisiBilgisi = DosyayıOku();
                a.IlanBilgisi = frmIlanVer.c.IlanBilgisi;
                frmIlanVer.heap3.InsertPosition(temp, a);
                temp = 0;
            }
            if (frmIlanVer.dizi[3] == frmIlanVer.c.IlanBilgisi)
            {
                temp = frmIlanVer.heap4.DeletePosition(a);
                a.KisiBilgisi = DosyayıOku();
                a.IlanBilgisi = frmIlanVer.c.IlanBilgisi;
                frmIlanVer.heap4.InsertPosition(temp, a);
                temp = 0;
            }
            if (frmIlanVer.dizi[4] == frmIlanVer.c.IlanBilgisi)
            {
                temp = frmIlanVer.heap5.DeletePosition(a);
                a.KisiBilgisi = DosyayıOku();
                a.IlanBilgisi = frmIlanVer.c.IlanBilgisi;
                frmIlanVer.heap5.InsertPosition(temp, a);
                temp = 0;
            }
            if (frmIlanVer.dizi[5] == frmIlanVer.c.IlanBilgisi)
            {
                temp = frmIlanVer.heap6.DeletePosition(a);
                a.KisiBilgisi = DosyayıOku();
                a.IlanBilgisi = frmIlanVer.c.IlanBilgisi;
                frmIlanVer.heap6.InsertPosition(temp, a);
                temp = 0;
            }
            if (frmIlanVer.dizi[6] == frmIlanVer.c.IlanBilgisi)
            {
                temp = frmIlanVer.heap7.DeletePosition(a);
                a.KisiBilgisi = DosyayıOku();
                a.IlanBilgisi = frmIlanVer.c.IlanBilgisi;
                frmIlanVer.heap7.InsertPosition(temp, a);
                temp = 0;
            }
            if (frmIlanVer.dizi[7] == frmIlanVer.c.IlanBilgisi)
            {
                temp = frmIlanVer.heap8.DeletePosition(a);
                a.KisiBilgisi = DosyayıOku();
                a.IlanBilgisi = frmIlanVer.c.IlanBilgisi;
                frmIlanVer.heap8.InsertPosition(temp, a);
                temp = 0;
            }
            if (frmIlanVer.dizi[8] == frmIlanVer.c.IlanBilgisi)
            {
                temp = frmIlanVer.heap9.DeletePosition(a);
                a.KisiBilgisi = DosyayıOku();
                a.IlanBilgisi = frmIlanVer.c.IlanBilgisi;
                frmIlanVer.heap9.InsertPosition(temp, a);
                temp = 0;
            }
            if (frmIlanVer.dizi[9] == frmIlanVer.c.IlanBilgisi)
            {
                temp = frmIlanVer.heap10.DeletePosition(a);
                a.KisiBilgisi = DosyayıOku();
                a.IlanBilgisi = frmIlanVer.c.IlanBilgisi;
                frmIlanVer.heap10.InsertPosition(temp, a);
                temp = 0;
            }
            ka.Ekle(a.KisiBilgisi);
            MessageBox.Show("Başarı ile Güncellendi..");
        }
        private void rdbtnGuncelle_CheckedChanged(object sender, EventArgs e)
        {
            txtAd.ReadOnly = txtAdres.ReadOnly = txtBolum.ReadOnly = txtBolum2.ReadOnly = txtDogumYeri.ReadOnly =
              txtEposta.ReadOnly = txtIlgiAlanlari.ReadOnly = txtIsAdi.ReadOnly = txtIsAdi2.ReadOnly = txtIsAdresi.ReadOnly
              = txtIsAdresi2.ReadOnly = txtLiseAdi.ReadOnly = txtMedeniDurum.ReadOnly = txtNotOrt.ReadOnly = txtNotOrt2.ReadOnly
              = txtPozisyon.ReadOnly = txtPozisyon2.ReadOnly = txtReferans.ReadOnly = txtTelefon.ReadOnly = txtUniAdi.ReadOnly
              = txtUyrugu.ReadOnly = txtYabanciDil.ReadOnly = false;
            dateTimeBaslangic.Enabled = dateTimeBaslangic2.Enabled = dateTimeBitis.Enabled = dateTimeBitis2.Enabled
                = dateTimePicker1.Enabled = true;
        }
    }
}
