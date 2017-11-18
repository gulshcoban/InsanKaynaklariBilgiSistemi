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
    public partial class frmIlanVer : Form
    {
        public static Object c;
        public static Heap heap1 = new Heap(10);
        public static Heap heap2 = new Heap(10);
        public static Heap heap3 = new Heap(10);
        public static Heap heap4 = new Heap(10);
        public static Heap heap5 = new Heap(10);
        public static Heap heap6 = new Heap(10);
        public static Heap heap7 = new Heap(10);
        public static Heap heap8 = new Heap(10);
        public static Heap heap9 = new Heap(10);
        public static Heap heap10 = new Heap(10);
        DataGridView d;
        public frmIlanVer(DataGridView dgv)
        {
            d = dgv;
            InitializeComponent();
        }
        public frmIlanVer()
        {
            // TODO: Complete member initialization
        }
        public static Sirket s;
        public static Ilan ilan;
        public static int count = 0;
        public static Ilan[] dizi = new Ilan[10];
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            s = new Sirket();
            ilan = new Ilan();
            c = new Object();
            s.IsyeriAdi = txtIsYeriAdi.Text;
            s.TamAdresi = txtTamAdres.Text;
            s.Eposta = txtEposta.Text;
            s.Faks = txtFaks.Text;
            s.Telefon = Convert.ToInt64(txtTelefon.Text);
            ilan.SirketBilgileri = s;
            ilan.IsTanimi = txtIsTanimi.Text;
            ilan.ArananElamanOzellikleri = txtIstenenOzellikler.Text;

            Random rnd = new Random();
            ilan.IlanNo = rnd.Next(1, 20);
            lblIlanNoGoster.Text = ilan.IlanNo.ToString();
            DosyayaYaz(ilan);
            dizi[count] = c.IlanBilgisi = DosyayıOku();
            count++;

            d.Rows.Add(1);
            int toplam = d.Rows.Count;
            d.Rows[toplam - 2].Cells[0].Value = ilan.IlanNo.ToString();
            d.Rows[toplam - 2].Cells[1].Value = s.IsyeriAdi;
            d.Rows[toplam - 2].Cells[2].Value = ilan.IsTanimi;
            d.Rows[toplam - 2].Cells[3].Value = "Detaylar";
            txtEposta.ReadOnly = txtFaks.ReadOnly = txtIsTanimi.ReadOnly = txtIstenenOzellikler.ReadOnly
                = txtIsYeriAdi.ReadOnly = txtTamAdres.ReadOnly = txtTelefon.ReadOnly = true;
            MessageBox.Show("Kaydedildi..");
        }

        private void rdbtnGuncelle_CheckedChanged(object sender, EventArgs e)
        {

            txtEposta.ReadOnly = txtFaks.ReadOnly = txtIsTanimi.ReadOnly = txtIstenenOzellikler.ReadOnly
            = txtIsYeriAdi.ReadOnly = txtTamAdres.ReadOnly = txtTelefon.ReadOnly = false;
        }

        private void btnIlanGuncelle_Click(object sender, EventArgs e)
        {
            c = new Object();
            if (s.IsyeriAdi != txtIsYeriAdi.Text)
                s.IsyeriAdi = txtIsYeriAdi.Text;
            if (s.Eposta != txtEposta.Text)
                s.Eposta = txtEposta.Text;
            if (s.Faks != txtFaks.Text)
                s.Faks = txtFaks.Text;
            if (s.TamAdresi != txtTamAdres.Text)
                s.TamAdresi = txtTamAdres.Text;
            if (s.Telefon != Convert.ToInt64(txtTelefon.Text))
                s.Telefon = Convert.ToInt64(txtTelefon.Text);
            if (ilan.ArananElamanOzellikleri != txtIstenenOzellikler.Text)
                ilan.ArananElamanOzellikleri = txtIstenenOzellikler.Text;
            if (ilan.IsTanimi != txtIsTanimi.Text)
                ilan.IsTanimi = txtIsTanimi.Text;
            ilan.SirketBilgileri = s;
            DosyayaYaz(ilan);
            dizi[--count] = c.IlanBilgisi = DosyayıOku();
            count++;

            int toplam = d.Rows.Count;
            d.Rows[toplam - 2].Cells[0].Value = ilan.IlanNo.ToString();
            d.Rows[toplam - 2].Cells[1].Value = s.IsyeriAdi;
            d.Rows[toplam - 2].Cells[2].Value = ilan.IsTanimi;
            d.Rows[toplam - 2].Cells[3].Value = "Detaylar";

            txtEposta.ReadOnly = txtFaks.ReadOnly = txtIsTanimi.ReadOnly = txtIstenenOzellikler.ReadOnly
               = txtIsYeriAdi.ReadOnly = txtTamAdres.ReadOnly = txtTelefon.ReadOnly = true;
            MessageBox.Show("Güncelleme başarıyla gerçekleşmiştir..");
        }
        private static void DosyayaYaz(Ilan i)
        {
            string dosya_yolu = @"C:\Users\Hüseyin\Desktop\142802029-142802011\sirket.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(i.ArananElamanOzellikleri);
            sw.WriteLine(i.IlanNo);
            sw.WriteLine(i.IsTanimi);
            sw.WriteLine(i.SirketBilgileri.Eposta);
            sw.WriteLine(i.SirketBilgileri.Faks);
            sw.WriteLine(i.SirketBilgileri.IsyeriAdi);
            sw.WriteLine(i.SirketBilgileri.TamAdresi);
            sw.WriteLine(i.SirketBilgileri.Telefon);

            sw.Flush();
            sw.Close();
            fs.Close();
        }

        private static Ilan DosyayıOku()
        {
            Ilan a = new Ilan();
            Sirket sirket = new Sirket();
            string dosya_yolu = @"C:\Users\Hüseyin\Desktop\142802029-142802011\sirket.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);

            a.ArananElamanOzellikleri = sr.ReadLine();
            a.IlanNo = Convert.ToInt32(sr.ReadLine());
            a.IsTanimi = sr.ReadLine();
            sirket.Eposta = sr.ReadLine();
            sirket.Faks = sr.ReadLine();
            sirket.IsyeriAdi = sr.ReadLine();
            sirket.TamAdresi = sr.ReadLine();
            sirket.Telefon = Convert.ToInt64(sr.ReadLine());
            a.SirketBilgileri = sirket;
            sr.Close();
            fs.Close();
            File.Delete(@"C:\Users\Hüseyin\Desktop\142802029-142802011\sirket.txt");
            return a;
        }
    }
}
