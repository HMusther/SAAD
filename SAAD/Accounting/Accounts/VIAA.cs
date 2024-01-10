using SAAD.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAAD.Accounting
{
    public class VIAA : Account
    {
        public VIAA()
        {
            this.email = "viaa@viaa.com";
            this.name = "VIAA";
            this.password = "123";
            this.country = Database.Countries[0];
            this.roles = Constants.Roles.VIAA;
        }
    }
}
