﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAAD
{
    public class ApplicationDocument
    {
        public int ID { get; set; }
        public string Data { get; set; }

        public ApplicationDocument(int id, string data)
        {
            this.ID = id;
            this.Data = data;
        }
    }
}
