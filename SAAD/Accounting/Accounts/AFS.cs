using SAAD.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAAD.Accounting
{
    public class AFS : Account
    {
        public AFS()
        {
            this.email = "afs@afs.com";
            this.name = "AFS";
            this.password = "123";
            this.country = Database.Countries[1];
            this.roles = Constants.Roles.AFS;
        }
    }
}
