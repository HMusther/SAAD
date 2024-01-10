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
    public partial class CreateApplication : Form
    {
        private VisaType type;
        public CreateApplication(VisaType type)
        {
            InitializeComponent();
            this.type = type;

            InputInformation();
        }

        public void InputInformation()
        {
            label1.Text = "Apply for " + type.Name + "(" + type.Country + ")";

            comboBox1.Items.AddRange(Database.Accounts.Where(x => x.roles == Roles.Applicant).Select(x => x.name).ToArray());

            string text = "";

            foreach (Criteria criteria in type.Criterias)
            {
                text += "- " + criteria.Name + "\r\n";
            }

            richTextBox1.Text = text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VisaApplication application = new VisaApplication(0, Database.Accounts[0], Database.VisaTypes[0], "Open",new ApplicationDocument(0, "Passport supplied"));

            Database.VisaApplications.Add(application);

            this.Close();
        }
    }
}
