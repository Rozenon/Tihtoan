using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tihtoan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btcong_Click(object sender, EventArgs e)
        {
            int kq;
            int a = int.Parse(txta.Text);
            int b = int.Parse(txtb.Text);
            Class1 c = new Class1(a, b);
            kq = c.Execute("+");
            txtkq.Text = kq.ToString();

        }

        private void bttru_Click(object sender, EventArgs e)
        {
            int kq;
            int a = int.Parse(txta.Text);
            int b = int.Parse(txtb.Text);
            Class1 c = new Class1(a, b);
            kq = c.Execute("-");
            txtkq.Text = kq.ToString();
        }

        private void btnnhan_Click(object sender, EventArgs e)
        {
            int kq;
            int a = int.Parse(txta.Text);
            int b = int.Parse(txtb.Text);
            Class1 c = new Class1(a, b);
            kq = c.Execute("*");
            txtkq.Text = kq.ToString();
        }

        private void btchia_Click(object sender, EventArgs e)
        {
            int kq;
            int a = int.Parse(txta.Text);
            int b = int.Parse(txtb.Text);
            Class1 c = new Class1(a, b);
            kq = c.Execute("/");
            txtkq.Text = kq.ToString();
        }
    }
}
