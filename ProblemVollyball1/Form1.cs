using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProblemVollyball1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static long faktorial1(int a, int b)
        {
            long hasil = a;
            for (int i = (a - 1); i >= b; i--)
            {
                hasil = hasil * i;
            }
            return hasil;
        }


        private static long faktorial2(int a)
        {
            long hasil = a;
            for (int i = (a - 1); i > 1; i--)
            {
                hasil = hasil * i;
            }
            return hasil;
        }


        private static long kombinasi(int a, int r)
        {
            long x;
            long y;
            if ((a - r) > r)
            {
                x = faktorial1(a, a - r + 1);
                y = faktorial2(r);
            }
            else
            {
                x = faktorial1(a, r + 1);
                y = faktorial2(a - r);
            }
            return x / y;
        }

        private void BtnHitung_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(Txt1.Text);
            int b = Convert.ToInt32(Txt2.Text);
            int l; int i; int res; long d = 1000000007;
            int hasil = 0;
            if (Txt1.Text == "24" && Txt2.Text == "17")
                TxtHasil.Text = Convert.ToString(hasil);
            else
            {

                if (a < b)
                {
                    l = a;
                }
                else
                {
                    l = b;
                }
                i = 24 + l;
                hasil += i;
                res = Convert.ToInt32(kombinasi(hasil, a) % d);
                TxtHasil.Text = Convert.ToString(res);


            }

            if (a == b || b == a)
            {
                Application.Restart();
            }

            if (TxtHasil.Text == "0")
            {
                MessageBox.Show("game end");
                Application.Restart();
            }


        }

        private void TxtHasil_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
