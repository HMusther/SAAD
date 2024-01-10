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
    public partial class UpdateStatus : Form
    {
        VisaApplication app;
        public UpdateStatus(VisaApplication application)
        {
            InitializeComponent();
            app = application;
            textBox1.Text = application.Status;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            app.Status = textBox1.Text;
        }
    }
}
