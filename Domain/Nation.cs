﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Nation
    {
        public string Code { set; get; }
        public string Name { set; get; }
        public int PhoneCode { set; get; }
        public Status Status { set; get; }

        override
        public String ToString()
        {
            return this.Name.ToString();
        }
    }
}
