using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
     
      
        private void button1_Click(object sender, EventArgs e)
        {
            DesExecute des = new DesExecute();
            //banma.Text = des.mahoa("0123456789ABCDEF", "133457799BBCDFF1");
            string khoa1 = des.chuyennhiphan(khoa.Text.ToString());
            string[] kq = des.CnDn(khoa1);
            string[] k = des.sinhk(kq);
            string[] lr = des.LiRi(banro.Text.ToString(), k);
            cndn.Clear();
            khoak.Clear();
            liri.Clear();
            foreach(string x in kq)
            {
                cndn.Text += x + '\n';
            }
            foreach (string x in k)
            {
                khoak.Text += x + '\n';
            }
            foreach (string x in lr)
            {
                liri.Text += x + '\n';
            }
            banma.Text = des.mahoa(banro.Text.ToString(), khoa.Text.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DesExecute des = new DesExecute();
            //banro.Text = des.giaima(banma.Text.ToString(), "133457799BBCDFF1");
            string khoa1 = des.chuyennhiphan(khoa.Text.ToString());
            string[] kq = des.CnDn(khoa1);
            string[] k = des.sinhk(kq);
            string[] kdao = new string[17];
            int c = 1;
            for (int i = 16; i >= 1; i--)
            {
                kdao[c] = k[i];
                c++;
            }
            string[] lr = des.LiRi(banma.Text.ToString(), kdao);
            cndn.Clear();
            khoak.Clear();
            liri.Clear();
            foreach (string x in kq)
            {
                cndn.Text += x + '\n';
            }
            foreach (string x in kdao)
            {
                khoak.Text += x + '\n';
            }
            foreach (string x in lr)
            {
                liri.Text += x + '\n';
            }
            banro.Text = des.giaima(banma.Text.ToString(), khoa.Text.ToString());
        }
    }
}
