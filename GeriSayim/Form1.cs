using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeriSayim
{
    public partial class Form1 : Form
    {
        public int sureToplami;    
        public bool tamam = false;
        public Form1()
        {
            InitializeComponent();
        }
        public void hesap()
        {
            tamam = false;
            try
            {
                sureToplami = (Convert.ToInt32(saat.Text) * 3600) + (Convert.ToInt32(dakika.Text) * 60) + Convert.ToInt32(saniye.Text);
                tamam = true;
            }
            catch
            {
                saat.Text = "1";
                dakika.Text = "1";
                saniye.Text = "30";
                MessageBox.Show("Sadece Rakam Yazınız");
            }
        }
        private void kapa_Click(object sender, EventArgs e)
        {
            hesap();
            if (tamam == true)
            {
                Process.Start("cmd.exe", "/c" + "shutdown -s -t " + sureToplami);
            }
        }

        private void iptal_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", "/c" + "shutdown -a");
        }

        private void yenidenbasla_Click(object sender, EventArgs e)
        {
            hesap();
            if (tamam == true)
            {
                Process.Start("cmd.exe", "/c" + "shutdown -r -t " + sureToplami);
            }
        }
        private void saat_Click(object sender, EventArgs e)
        {
            saat.Text = "";
        }
        private void dakika_Click(object sender, EventArgs e)
        {
            dakika.Text = "";
        }
        private void saniye_Click(object sender, EventArgs e)
        {
            saniye.Text = "";
        }

        
    }
}

    

