using SAAD.Accounting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAAD.Constants
{
    public static class Database
    {
        public static List<Country> Countries = new List<Country>()
        {
            new Country(0, "England"),
            new Country(1, "USA"),
            new Country(2, "Norway")
        };
        public static List<Account> Accounts = new List<Account>()
        {
            new AccountFactory().Create(AccountType.Applicant),
            new AccountFactory().Create(AccountType.AFS),
            new AccountFactory().Create(AccountType.VIAA)
         };



        public static List<Criteria> Criterias = new List<Criteria>()
        {
            new Criteria(0, "Passport Documentation"),
            new Criteria(1, "Driving Licence")
        };

        public static List<VisaType> VisaTypes = new List<VisaType>()
        {
            new VisaType(0, Countries[0], "Student Visa", new List<Criteria>() {Criterias[0] }),
            new VisaType(1, Countries[0], "Tourist Visa", new List<Criteria>() {Criterias[1] }),
            new VisaType(2, Countries[1], "Student Visa", new List<Criteria>() {Criterias[1] }),
            new VisaType(3, Countries[1], "Tourist Visa", new List<Criteria>() {Criterias[0] }),
            new VisaType(4, Countries[2], "Random Visa", new List<Criteria>() {Criterias[0] }),
            new VisaType(5, Countries[2], "Temporary Visa", new List<Criteria>() {Criterias[1] }),
        };

        public static List<VisaApplication> VisaApplications = new List<VisaApplication>()
        {

        };

    }

}
