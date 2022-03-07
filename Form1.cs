using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Arraylist_Uygulama_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList sehirler = new ArrayList();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            sehirler.Add(txtSehirler.Text);
            Listele();
        }

         public void Listele()
        {
            Şehirler.Items.Clear();
            foreach (string sehir in sehirler)
            {
                Şehirler.Items.Add(sehir);
            }
        }

         private void btnAra_Click(object sender, EventArgs e)
         {
             if (sehirler.Contains(txtSehirler.Text))
             {
                 label2.Text = "Aranan Değer Bulundu.";
                 Şehirler.SelectedIndex = sehirler.IndexOf(txtSehirler.Text);
             }
             else
             {
                 label2.Text = "Aranan Değer Bulunamadı.";
             }
         }

         private void btnSil_Click(object sender, EventArgs e)
         {
             int indexNo = Şehirler.SelectedIndex;
             sehirler.RemoveAt(indexNo);
             Listele();
         }

         private void btnGüncelle_Click(object sender, EventArgs e)
         {
             int indexNo = Şehirler.SelectedIndex;
             sehirler[indexNo] = txtSehirler.Text;
             Listele();
         }

         private void btnArayaEkle_Click(object sender, EventArgs e)
         {
             int indexNo = Şehirler.SelectedIndex;
             sehirler.Insert(indexNo,txtSehirler.Text);
             Listele();
         }
    }
}
