using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            bulan.SelectedItem = "Januari";
            DateTime awal = new DateTime(2016, 1, 1);
            DateTime akhir = new DateTime(2017, 12, 31);
            TimeSpan jarak = akhir - awal;
            int day = jarak.Days;
            for(var i = 0; i <= day; i++)
            {
                var bolddate = awal.AddDays(i);
                switch (bolddate.DayOfWeek)
                {
                    case DayOfWeek.Saturday:
                        kalender.AddBoldedDate(bolddate);
                        break;
                    case DayOfWeek.Sunday:
                        kalender.AddBoldedDate(bolddate);
                        break;
                }

            }
            kalender.AddAnnuallyBoldedDate(new DateTime(1996, 05, 31));
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tambah_Click(object sender, EventArgs e)
        {
            kalender.AddAnnuallyBoldedDate(new DateTime(2016, bulan.SelectedIndex + 1, Convert.ToInt32(tanggal.Value)));
            kalender.UpdateBoldedDates();
        }

        private void hapus_Click(object sender, EventArgs e)
        {
            kalender.RemoveAnnuallyBoldedDate(new DateTime(2016, bulan.SelectedIndex + 1, Convert.ToInt32(tanggal.Value)));
            kalender.UpdateBoldedDates();
        }
    }
}
