using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAAD
{
    public class VisaType
    {
        public int ID { get; set; }
        public Country Country { get; set; }

        public string Name { get; set; }

        public List<Criteria> Criterias { get; set; }


        public VisaType(int ID, Country country, string name, List<Criteria> criterias)
        {
            this.ID = ID;
            this.Country = country;
            this.Name = name;
            this.Criterias = criterias;
        }
    }

}
