using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Translation_Fee_Calculator
{
    public partial class Form1 : Form
    {
        int rate, pageCount, dis, from;
        int extra, page, freq, total_amount;

        public Form1()
        {
            InitializeComponent();
            rateBox.Text = "1";
            disBox.Text = "5";
            disFromBox.Text = "30";
        }

        private void calBtn_Click(object sender, EventArgs e)
        {
            rate = int.Parse(rateBox.Text);
            pageCount = int.Parse(pageBox.Text);
            dis = int.Parse(disBox.Text);
            from = int.Parse(disFromBox.Text);

            total_amount = pageCount * rate;
            if (pageCount >= from)
            {
                extra = pageCount % (from - 10);
                page = pageCount - extra;
                freq = page / (from - 10);
                dis *= freq;
                total_amount = page - dis + extra;
            }

            totalLbl.Text = total_amount.ToString();
        }
    }
}
