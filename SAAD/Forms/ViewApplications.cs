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
    public partial class ViewApplications : Form
    {
        private Account Account;
        private List<VisaApplication> Applications = new List<VisaApplication>();
        public ViewApplications(Account account)
        {
            InitializeComponent();
            this.Account = account;
            GetApplications();
        }

        public void GetApplications()
        {
            if (Account.roles == Roles.Applicant)
            {
                Applications = Database.VisaApplications.Where(x => x.Applicant == Account).ToList();
            }
            else if (Account.roles == Roles.AFS)
            {
                Applications = Database.VisaApplications;
            }
            else
            {
                return;
            }

            List<ViewApplicationsDisplay> displays = new List<ViewApplicationsDisplay>();

            for (int i = 0; i < Applications.Count; i++)
            {
                ViewApplicationsDisplay newDisplay = new ViewApplicationsDisplay(Applications[i], Account.roles == Roles.AFS ? true : false); ;

                Point point = new Point(0, i * 55);
                newDisplay.Location = point;
                displays.Add(newDisplay);
            }

            foreach (ViewApplicationsDisplay display in displays)
            {
                this.Controls.Add(display);
            }
        }
    }
}
