using System;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Translation_Fee_Calculator
{
    public partial class Form1 : Form
    {
        // Variable declaration
        String fromCurrency = "USD";
        String toCurrency = "MYR";

        float rate, dis, total_amount;
        float profitUSD, profitMYR;

        int extra, page, freq, pageCount, from, every;
        int duration;

        public void calculateUSD()
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
            profitUSD = (float)(total_amount * 0.8);
            profitLbl.Text = profitUSD.ToString();
            
            calculateDuration();
        }

        public Task<String> calculateMYR()
        {
            
            profitMYR = CurrencyConverter.GetExchangeRate(fromCurrency, toCurrency, profitUSD);
            return Task.FromResult(profitMYR.ToString("0.00"));
        }

        public async void calculateMYRAsync()
        {
            rmLbl.Text = "    Loading";
            profitLblMyr.Text = "";
            var task = Task.Run(() => calculateMYR());
            profitLblMyr.Text = await task;
            rmLbl.Text = "RM";
        }

        public void calculateDuration()
        {
            duration = 0;

            for (int i=4;i<pageCount; i+=10)
                duration++;

            durationLbl.Text = duration.ToString();
        }


        public Form1()
        {
            InitializeComponent();
            MaximizeBox = false;

            // Default Value
            disFromBox.Text = "30";
            everyBox.Text = "20";
            rateBox.Text = "1";
            disBox.Text = "5";

            pageBox.Select();
        }

        // If user press Enter key, calculate
        private void pageBox_click(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calculateUSD();
                calculateMYRAsync();
            }
        }

        // If user press the Calculate Button, calculate
        private void calBtn_Click(object sender, EventArgs e)
        {
            calculateUSD();
            calculateMYRAsync();
        }

    }
}
