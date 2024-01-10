using SAAD.Accounting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAAD
{
    public class VisaApplication
    {
        public int ID { get; set; }
        public Account Applicant { get; set; }
        public VisaType VisaType { get; set; }

        public string Status { get; set; }

        public ApplicationDocument document { get; set; }

        public VisaApplication(int ID, Account applicant, VisaType type, string status, ApplicationDocument doc)
        {
            this.ID = ID;
            this.Applicant = applicant;
            this.VisaType = type;
            this.Status = status;
            this.document = doc;

        }
    }
}
