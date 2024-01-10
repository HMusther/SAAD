using SAAD.Accounting;
using SAAD.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAAD.Forms
{
    public partial class AddVisaType : Form
    {
        private Account account;
        public AddVisaType(Account account)
        {
            this.account = account;
            InitializeComponent();
            LoadDetails();
        }

        public void LoadDetails()
        {
            comboBox1.Items.AddRange(Database.Criterias.Select(x => x.Name).ToArray());
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Criteria criteria = Database.Criterias.Where(x => x.Name == comboBox1.SelectedItem.ToString()).First();

            VisaType newType = new VisaType(3, account.country, textBox1.Text, new List<Criteria>() { criteria });

            Database.VisaTypes.Add(newType);

            this.DialogResult = DialogResult.OK;
            return;
        }
    }
}
