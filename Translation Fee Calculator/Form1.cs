using System;
using System.Windows.Forms;

namespace Translation_Fee_Calculator
{
    public partial class Form1 : Form
    {
        // Variable declaration
        float rate, dis, total_amount;
        int extra, page, freq, pageCount, from, every;

        public void calculate()
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
                if (every > 0)
                {
                    extra = pageCount % every;
                    page = pageCount - extra;
                    freq = page / every;
                    dis *= freq;
                    total_amount = (page - dis + extra) * rate;
                }
            }

            totalLbl.Text = total_amount.ToString();

            // Times 0.8 because Fiverr take 20% from the price
            profitLbl.Text = (total_amount * 0.8).ToString(); 
        }

        // If user press Enter key, calculate
        private void pageBox_click(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calculate();
            }
        }

        public Form1()
        {
            InitializeComponent();
            // Default Value
            disFromBox.Text = "30";
            everyBox.Text = "20";
            rateBox.Text = "1";
            disBox.Text = "5";

            pageBox.Select();
        }

        // If user press the Calculate Button, calculate
        private void calBtn_Click(object sender, EventArgs e)
        {
            calculate();
        }

    }
}
