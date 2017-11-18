using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _142802029_142802011
{
    public partial class frmDetaylar : Form
    {
        public string id;
        public static int count1 = 0;
        public static int count2 = 0;
        public static int count3 = 0;
        public static int count4 = 0;
        public static int count5 = 0;
        public static int count6 = 0;
        public static int count7 = 0;
        public static int count8 = 0;
        public static int count9 = 0;
        public static int count10 = 0;
        public frmDetaylar(string id)
        {
            this.id = id;
            InitializeComponent();
            listBoxIlanlar.Items.Add(id);
        }

        private void btnTumKisileriGor_Click(object sender, EventArgs e)
        {
            if (frmIlanVer.dizi[0] == frmIlanVer.c.IlanBilgisi)
            {
                frmIlanVer.heap1.DisplayHeap(count1);
            }
            if (frmIlanVer.dizi[1] == frmIlanVer.c.IlanBilgisi)
            {
                frmIlanVer.heap2.DisplayHeap(count2);
            }
            if (frmIlanVer.dizi[2] == frmIlanVer.c.IlanBilgisi)
            {
                frmIlanVer.heap3.DisplayHeap(count3);
            }
            if (frmIlanVer.dizi[3] == frmIlanVer.c.IlanBilgisi)
            {
                frmIlanVer.heap4.DisplayHeap(count4);
            }
            if (frmIlanVer.dizi[4] == frmIlanVer.c.IlanBilgisi)
            {
                frmIlanVer.heap5.DisplayHeap(count5);
            }
            if (frmIlanVer.dizi[5] == frmIlanVer.c.IlanBilgisi)
            {
                frmIlanVer.heap6.DisplayHeap(count6);
            }
            if (frmIlanVer.dizi[6] == frmIlanVer.c.IlanBilgisi)
            {
                frmIlanVer.heap7.DisplayHeap(count7);
            }
            if (frmIlanVer.dizi[7] == frmIlanVer.c.IlanBilgisi)
            {
                frmIlanVer.heap8.DisplayHeap(count8);
            }
            if (frmIlanVer.dizi[8] == frmIlanVer.c.IlanBilgisi)
            {
                frmIlanVer.heap9.DisplayHeap(count9);
            }
            if (frmIlanVer.dizi[9] == frmIlanVer.c.IlanBilgisi)
            {
                frmIlanVer.heap10.DisplayHeap(count10);
            }
        }

        private void btnBasvuruYap_Click(object sender, EventArgs e)
        {
            frmBasvuruYap BasvuruYap = new frmBasvuruYap();
            BasvuruYap.Show();
            this.Close();
        }
        Kisi k;
        private void btnIseAl_Click(object sender, EventArgs e)
        {
            if (frmIlanVer.dizi[0] == frmIlanVer.c.IlanBilgisi)
            {
                k = frmIlanVer.heap1.Root();
                MessageBox.Show(frmIlanVer.heap1.GetMax());
                frmBasvuruYap.ka.Sil(k);
                count1--;
            }
            if (frmIlanVer.dizi[1] == frmIlanVer.c.IlanBilgisi)
            {
                k = frmIlanVer.heap2.Root();
                MessageBox.Show(frmIlanVer.heap2.GetMax());
                frmBasvuruYap.ka.Sil(k);
                count2--;
            }
            if (frmIlanVer.dizi[2] == frmIlanVer.c.IlanBilgisi)
            {
                k = frmIlanVer.heap3.Root();
                MessageBox.Show(frmIlanVer.heap3.GetMax());
                frmBasvuruYap.ka.Sil(k);
                count3--;
            }
            if (frmIlanVer.dizi[3] == frmIlanVer.c.IlanBilgisi)
            {
                k = frmIlanVer.heap4.Root();
                MessageBox.Show(frmIlanVer.heap4.GetMax());
                frmBasvuruYap.ka.Sil(k);
                count4--;
            }
            if (frmIlanVer.dizi[4] == frmIlanVer.c.IlanBilgisi)
            {
                k = frmIlanVer.heap5.Root();
                MessageBox.Show(frmIlanVer.heap5.GetMax());
                frmBasvuruYap.ka.Sil(k);
                count5--;
            }
            if (frmIlanVer.dizi[5] == frmIlanVer.c.IlanBilgisi)
            {
                k = frmIlanVer.heap6.Root();
                MessageBox.Show(frmIlanVer.heap6.GetMax());
                frmBasvuruYap.ka.Sil(k);
                count6--;
            }
            if (frmIlanVer.dizi[6] == frmIlanVer.c.IlanBilgisi)
            {
                k = frmIlanVer.heap7.Root();
                MessageBox.Show(frmIlanVer.heap7.GetMax());
                frmBasvuruYap.ka.Sil(k);
                count7--;
            }
            if (frmIlanVer.dizi[7] == frmIlanVer.c.IlanBilgisi)
            {
                k = frmIlanVer.heap8.Root();
                MessageBox.Show(frmIlanVer.heap8.GetMax());
                frmBasvuruYap.ka.Sil(k);
                count8--;
            }
            if (frmIlanVer.dizi[8] == frmIlanVer.c.IlanBilgisi)
            {
                k = frmIlanVer.heap9.Root();
                MessageBox.Show(frmIlanVer.heap9.GetMax());
                frmBasvuruYap.ka.Sil(k);
                count9--;
            }
            if (frmIlanVer.dizi[9] == frmIlanVer.c.IlanBilgisi)
            {
                k = frmIlanVer.heap10.Root();
                MessageBox.Show(frmIlanVer.heap10.GetMax());
                frmBasvuruYap.ka.Sil(k);
                count10--;
            }
        }
    }
}
