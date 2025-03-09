using CurrencyConverterBackend;
using System.Drawing.Text;

namespace CurrencyConverterItSchoolProject
{
    public partial class Form1 : Form
    {
        private CurrencyRepository currencyRepository = new CurrencyRepository();

        public Form1()
        {
            InitializeComponent();
            comboBox1.DataSource = currencyRepository.GetCurrencies();
            comboBox1.DisplayMember = "Abbreviation";
            comboBox2.DataSource = currencyRepository.GetCurrencies();
            comboBox2.DisplayMember = "Abbreviation";
            numericUpDown1.Controls[0].Visible = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Currency fromCurrency = (Currency)comboBox1.SelectedItem;
            Currency toCurrency = (Currency)comboBox2.SelectedItem;

            decimal baseValue = 1;
            decimal exchangeToBaseCurrency = baseValue / fromCurrency.Value;
            decimal resultConvertion = exchangeToBaseCurrency * toCurrency.Value * numericUpDown1.Value;
            textBox1.Text = $"{resultConvertion:F} {toCurrency.Name}";

            string historyText = $"{numericUpDown1.Value} {fromCurrency.Name} was exchanged to {resultConvertion:F} {toCurrency.Name}";
            textBox2.AppendText(historyText);
            textBox2.AppendText("\r\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int euro = currencyRepository.GetCurrencyIndexByAbbreviation("EUR");
            int ron = currencyRepository.GetCurrencyIndexByAbbreviation("RON");

            comboBox1.SelectedIndex = euro;
            comboBox2.SelectedIndex = ron;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ron = currencyRepository.GetCurrencyIndexByAbbreviation("RON");
            int euro = currencyRepository.GetCurrencyIndexByAbbreviation("EUR");

            comboBox1.SelectedIndex = ron;
            comboBox2.SelectedIndex = euro;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int dollar = currencyRepository.GetCurrencyIndexByAbbreviation("USD");
            int ron = currencyRepository.GetCurrencyIndexByAbbreviation("RON");

            comboBox1.SelectedIndex = dollar;
            comboBox2.SelectedIndex = ron;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int pound = currencyRepository.GetCurrencyIndexByAbbreviation("GBP");
            int ron = currencyRepository.GetCurrencyIndexByAbbreviation("RON");

            comboBox1.SelectedIndex = pound;
            comboBox2.SelectedIndex = ron;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int franc = currencyRepository.GetCurrencyIndexByAbbreviation("CFH");
            int ron = currencyRepository.GetCurrencyIndexByAbbreviation("RON");

            comboBox1.SelectedIndex = franc;
            comboBox2.SelectedIndex = ron;
        }
    }
}
