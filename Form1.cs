using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Stack_Uygulama_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Stack yigin = new Stack();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            yigin.Push(txtAdSoyad.Text);
            Listele();
        }

        private void Listele()
        {
            ListeStack.Items.Clear();
            foreach (string eleman in yigin)
            {
                ListeStack.Items.Add(eleman);
            }
        }

        private void btnCikart_Click(object sender, EventArgs e)
        {
            yigin.Pop();
            Listele();
        }
    }
}
