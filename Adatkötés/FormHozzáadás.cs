using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adatkötés
{
    public partial class FormHozzáadás : Form
    {
        public CountryData CountryData = new CountryData();
        public FormHozzáadás()
        {
            InitializeComponent();
        }

        private void FormHozzáadás_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = CountryData;
        }
    }
}
