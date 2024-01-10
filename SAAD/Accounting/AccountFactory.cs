using SAAD.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAAD.Accounting
{
    public class AccountFactory
    {
        public Account Create(AccountType type)
        {
            switch (type)
            {
                case AccountType.Applicant:
                    return new Applicant();
                    break;
                case AccountType.AFS:
                    return new AFS();
                    break;
                case AccountType.VIAA:
                    return new VIAA();
                    break;
                default:
                    return default(Account);
            }
        }
    }
}
