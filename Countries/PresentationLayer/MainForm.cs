using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Countries;

namespace PresentationLayer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            _tableBindingSource.DataSource = _countryRepository.GetCountries();
        }

        private CountryRepository _countryRepository = new CountryRepository();
        private BindingSource _tableBindingSource = new BindingSource();

        List<Country> countries = new List<Country>();

        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridViewCountries.DataSource = _tableBindingSource;
            var regions = _countryRepository.GetRegions();
            foreach (string region in regions)
            {
                comboBoxRegions.Items.Add(region);
            }
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
           _tableBindingSource.DataSource = _countryRepository.Filter(countries, comboBoxRegions.Text, textBoxName.Text, textBoxCapital.Text,Convert.ToInt32(numericUpDownMin.Value), Convert.ToInt32(numericUpDownMax.Value));
            
        }

        private void buttonSpremi_Click(object sender, EventArgs e)
        {
            countries.Add(new Country
            {
                Code = textBoxInputCode.Text,
                Name = textBoxInputName.Text,
                Capital = textBoxInputCapital.Text,
                Population = Convert.ToInt32(textBoxInputPopulation.Text),
                Area = textBoxInputArea.Text,
                Region = textBoxInputRegion.Text
            });

            _tableBindingSource.DataSource = countries;
        }
    }
}
