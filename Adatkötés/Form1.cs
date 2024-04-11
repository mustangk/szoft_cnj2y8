using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace Adatkötés
{
    public partial class Form1 : Form
    {
        BindingList<CountryData> countryList = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            countryDataBindingSource.DataSource = countryList;

            StreamReader sr = new("orszagok.csv");
            var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
            var tömb = csv.GetRecords<CountryData>();
            foreach (var item in tömb)
            {
                countryList.Add(item);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            countryDataBindingSource.RemoveCurrent();
        }

        private void buttonHozzáadás_Click(object sender, EventArgs e)
        {
            FormHozzáadás formHozzáadás = new();

            if (formHozzáadás.ShowDialog() == DialogResult.OK)
            {
                countryDataBindingSource.Add(
                    formHozzáadás.CountryData);
            }
        }
    }
}