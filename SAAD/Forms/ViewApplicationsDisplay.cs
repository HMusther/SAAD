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
    public partial class ViewApplicationsDisplay : UserControl
    {
        VisaApplication Application;
        public ViewApplicationsDisplay(VisaApplication application, bool canUpdate)
        {
            InitializeComponent();
            this.Application = application;

            button1.Visible = canUpdate;

            SetupInformation();
        }

        public void SetupInformation()
        {
            label1.Text = Application.VisaType.Name;
            label2.Text = Application.Status;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateStatus updateStatusFrm = new UpdateStatus(Application);
            updateStatusFrm.ShowDialog();
        }
    }
}
