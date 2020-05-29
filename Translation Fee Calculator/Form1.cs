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
        float rate, dis, total_amount;
        int extra, page, freq, pageCount, from, every;

        public Form1()
        {
            InitializeComponent();
            // Default Value
            disFromBox.Text = "30";
            everyBox.Text = "20";
            rateBox.Text = "1";
            disBox.Text = "5";
        }

        private void calBtn_Click(object sender, EventArgs e)
        {
            // Get value from each textbox
            int.TryParse(pageBox.Text, out pageCount);
            int.TryParse(disFromBox.Text, out from);
            int.TryParse(everyBox.Text, out every);

            float.TryParse(rateBox.Text, out rate);
            float.TryParse(disBox.Text, out dis);

            total_amount = pageCount * rate;
            if (pageCount >= from)
            {
                if(every > 0)
                {
                    extra = pageCount % every;
                    page = pageCount - extra;
                    freq = page / every;
                    dis *= freq;
                    total_amount = (page - dis + extra) * rate;
                }
            }

            totalLbl.Text = total_amount.ToString();
        }
    }
}
