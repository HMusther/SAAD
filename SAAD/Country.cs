using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAAD
{
    public class Country
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public Country(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }
    }
}
