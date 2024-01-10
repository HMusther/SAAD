using SAAD.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAAD
{
    public partial class ViewCountriesFrm : Form
    {
        private string SelectedName = "";
        public Country ReturnCountry = null;
        public ViewCountriesFrm()
        {
            InitializeComponent();
        }

        private void ViewCountriesFrm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(Database.Countries.Select(x => x.Name).ToArray());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedName = comboBox1.SelectedItem.ToString();

            ReturnCountry = Database.Countries.Where(x => x.Name == SelectedName).First();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
