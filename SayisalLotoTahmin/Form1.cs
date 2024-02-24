using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//ReSharper disable all

namespace SayisalLotoTahmin
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_TahminEt_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int[] sayilar = new int[6];
            for (int i = 0; i < sayilar.Length; i++)
            {
                burayadon:
                int tahminedilen=rnd.Next(1, 50);
                foreach (var item in sayilar)
                {
                    if (item == tahminedilen)
                    {
                        goto burayadon;
                    }
                }
                sayilar[i] = tahminedilen;
            }
            Array.Sort(sayilar);

            textEdit1.Text = sayilar[0].ToString();
            textEdit2.Text = sayilar[1].ToString();
            textEdit3.Text = sayilar[2].ToString();
            textEdit4.Text = sayilar[3].ToString();
            textEdit5.Text = sayilar[4].ToString();
            textEdit6.Text = sayilar[5].ToString();

        }
    }
}
