using SAAD.Accounting;
using SAAD.Constants;
using SAAD.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAAD
{
    public partial class Home : Form
    {
        private Account CurrentAccount;
        public Home()
        {
            InitializeComponent();

            comboBox1.Items.AddRange(Database.Accounts.Select(x => x.name).ToArray());
            comboBox1.SelectedIndex = 0;
        }

        private void viewCountriesBtn_Click(object sender, EventArgs e)
        {
            ViewCountriesFrm frm = new ViewCountriesFrm();
            
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Country country = frm.ReturnCountry;


                ViewVisaTypesForCountry viewTypesFrm = new ViewVisaTypesForCountry(country);
                viewTypesFrm.ShowDialog();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentAccount = Database.Accounts.Where(x => x.name == comboBox1.SelectedItem.ToString()).FirstOrDefault();

            if (CurrentAccount.roles != Roles.VIAA)
            {
                button3.Enabled = false;
            }
            else
            {
                button3.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewApplications viewApplicationsDialog = new ViewApplications(CurrentAccount);
            viewApplicationsDialog.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddVisaType addVisa = new AddVisaType(CurrentAccount);
            addVisa.ShowDialog();
        }
    }
}
