using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volleyball_Problem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public const int Mod = 1000000007; 

        static bool Valid(int a, int b)
        {
            if(a < 25)
            {
                return false;
            }
            if(a == 25)
            {
                return b < 24;
            }
            return b == (a - 2);

        }
        public static void Swap<T>(ref T Left, ref T Right)
        {
            T temp;
            temp = Left;
            Left = Right;
            Right = temp;
        }
        public static int nCr(int n, int r, int mod)
        {
            if(n < r)
            {
                Swap(ref n, ref r);
            }
            if(n < 1 || r < 1)
            {
                return 1;
            }
            var row = new int[r];
            for (var i = 0; i < r; i++)
            {
                row[i] = 1;
            }
            for (int i = 2; i < r; ++i)
            {
                for (int j = i - 1; j > 0; --j)
                {
                    row[j] = (row[j] + row[j - 1]) % mod;
                }
            }
            --r;
            int sum = row[r];
            for (int i = 0; i < n; ++i)
            {
                for (int j = r; j > 0; --j)
                {
                    row[j] = (row[j] + row[j - 1]) % mod;
                }
                sum = (sum + row[r]) % mod;
            }
            return sum;
        }

        private static int ModulusPow(int basis, int pangkat, int mod)
        {
            if(pangkat < 2)
            {
                if(pangkat < 1)
                {
                    return 1;
                }
                else
                {
                    return basis;
                }
            }
            long resModulusPow = ModulusPow(basis, pangkat >> 1, mod);

            resModulusPow = (resModulusPow * resModulusPow) % mod;
            if ((pangkat & 1) == 1)
            {
                return (int)((resModulusPow * basis) % mod);
            }
            else
            {
                return (int)(resModulusPow);
            }
        }

        private void BtnHitung_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(Txt1.Text);
            int b = Convert.ToInt32(Txt2.Text);
            int res;
            if(a < b)
            {
                Swap(ref a, ref b);
            }
            if (!Valid(a,b))
            {
                res = 0;
            }
            else
            {
                if(a > 25)
                {
                    res = nCr(24, 24, Mod);
                    res = (int)((((long)res) * ModulusPow(2, b - 24, Mod)) % Mod);

                }
                else
                {
                    res = nCr(a - 1, b, Mod);
                }

            }
            TxtHasil.Text = Convert.ToString(res);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
