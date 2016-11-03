using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DateTime now = DateTime.Now;
        private void vmin_Scroll_1(object sender, ScrollEventArgs e)
        {
            minteks.Text = (vmin.Maximum - vmin.Value).ToString();
            if (vmax.Value > vmin.Value)
            {
                vmax.Value = vmin.Value;
                minteks.Text = (vmax.Maximum - vmax.Value).ToString();
            }
            tgl.MinDate = now.AddYears(vmax.Value - vmax.Maximum);
            tgl.MaxDate = now.AddYears(vmin.Value - vmin.Maximum);

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tgl.MaxDate = now.AddYears(vmin.Value - vmin.Maximum);
            tgl.MinDate = now.AddYears(vmax.Value - vmax.Maximum);
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void minteks_Click(object sender, EventArgs e)
        {

        }

        private void vmax_Scroll(object sender, ScrollEventArgs e)
        {
            maxteks.Text = (vmax.Maximum - vmax.Value).ToString();
            if (vmax.Value > vmin.Value)
            {
                vmin.Value = vmax.Value;
                minteks.Text = (vmin.Maximum - vmin.Value).ToString();
            }
            tgl.MaxDate = now.AddYears(vmin.Value - vmin.Maximum);
            tgl.MinDate = now.AddYears(vmax.Value - vmax.Maximum);

        }
    }
}
