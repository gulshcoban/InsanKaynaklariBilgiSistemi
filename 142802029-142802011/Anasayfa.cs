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
    public partial class frmAnasayfa : Form
    {
        public static HashMapChain hash = new HashMapChain();
        frmIlanVer ilan;
        public frmAnasayfa()
        {
            InitializeComponent();
        }

        private void btnIlanVer_Click(object sender, EventArgs e)
        {
            ilan = new frmIlanVer(dataGridView1);
            ilan.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string temp = "";
            if (e.RowIndex == 0)
            {
                temp = frmIlanVer.c.ilangor(frmIlanVer.dizi[0]);
            }
            else if (e.RowIndex == 1)
            {
                temp = frmIlanVer.c.ilangor(frmIlanVer.dizi[1]);
            }
            else if (e.RowIndex == 2)
            {
                temp = frmIlanVer.c.ilangor(frmIlanVer.dizi[2]);
            }
            else if (e.RowIndex == 3)
            {
                temp = frmIlanVer.c.ilangor(frmIlanVer.dizi[3]);
            }
            else if (e.RowIndex == 4)
            {
                temp = frmIlanVer.c.ilangor(frmIlanVer.dizi[4]);
            }
            else if (e.RowIndex == 5)
            {
                temp = frmIlanVer.c.ilangor(frmIlanVer.dizi[5]);
            }
            else if (e.RowIndex == 6)
            {
                temp = frmIlanVer.c.ilangor(frmIlanVer.dizi[6]);
            }
            else if (e.RowIndex == 7)
            {
                temp = frmIlanVer.c.ilangor(frmIlanVer.dizi[7]);
            }
            else if (e.RowIndex == 8)
            {
                temp = frmIlanVer.c.ilangor(frmIlanVer.dizi[8]);
            }
            else if (e.RowIndex == 9)
            {
                temp = frmIlanVer.c.ilangor(frmIlanVer.dizi[9]);
            }
            frmDetaylar Detaylar = new frmDetaylar(temp);
            Detaylar.Show();

        }

        private void btnKisiSayisi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ağaçtaki toplam eleman sayısı: " + frmBasvuruYap.ka.DugumSayisi().ToString());
        }

        private void btnDerinlik_Click(object sender, EventArgs e)
        {
            MessageBox.Show(frmBasvuruYap.ka.DerinlikBul().ToString());
        }

        private void btnIngAd_Click(object sender, EventArgs e)
        {
            frmBasvuruYap.ka.IngBilenleriBul();
            MessageBox.Show(frmBasvuruYap.ka.DugumleriYazdir());
        }

        private void btnOrtAd_Click(object sender, EventArgs e)
        {
            frmBasvuruYap.ka.OrtBul();
            MessageBox.Show(frmBasvuruYap.ka.DugumleriYazdir());
        }

        private void btnIsımAra_Click(object sender, EventArgs e)
        {
            frmBasvuruYap.ka.KisiBul(txtArananIsim.Text);
            MessageBox.Show(frmBasvuruYap.ka.DugumleriYazdir());
        }

        private void btnInorder_Click(object sender, EventArgs e)
        {
            frmBasvuruYap.ka.InOrder();
            MessageBox.Show(frmBasvuruYap.ka.DugumleriYazdir());
        }

        private void btnPreorder_Click(object sender, EventArgs e)
        {
            frmBasvuruYap.ka.PreOrder();
            MessageBox.Show(frmBasvuruYap.ka.DugumleriYazdir());
        }

        private void btnPostorder_Click(object sender, EventArgs e)
        {
            frmBasvuruYap.ka.PostOrder();
            MessageBox.Show(frmBasvuruYap.ka.DugumleriYazdir());
        }
    }
}
