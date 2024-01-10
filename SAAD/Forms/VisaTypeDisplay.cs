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
    public partial class VisaTypeDisplay : UserControl
    {
        private VisaType type;
        
        public VisaTypeDisplay(VisaType type)
        {
            InitializeComponent();
            this.type = type;

            label1.Text = type.Name;

            string text = "";

            foreach(Criteria criteria in type.Criterias)
            {
                text += "- " + criteria.Name + "\r\n";
            }

            richTextBox1.Text = text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateApplication dialog = new CreateApplication(type);
            dialog.ShowDialog();
        }
    }
}
