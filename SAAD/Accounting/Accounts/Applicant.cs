using SAAD.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAAD.Accounting
{
    public class Applicant : Account
    {
        public Applicant()
        {
            this.email = "applicant@applicant.com";
            this.name = "Applicant";
            this.password = "123";
            this.country = Database.Countries[0];
            this.roles = Constants.Roles.Applicant;
            
        }

    }
}
