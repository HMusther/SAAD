using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAAD
{
    public class Criteria
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public Criteria(int ID, string name)
        {
            this.ID = ID;
            this.Name = name;
        }
    }
}
