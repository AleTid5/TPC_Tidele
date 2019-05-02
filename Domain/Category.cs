﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Category
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public int BlockedAge { set; get; }
        public Status Status { set; get; }
    }
}
