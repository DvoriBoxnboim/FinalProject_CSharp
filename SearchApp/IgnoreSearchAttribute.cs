﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchApp
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    class IgnoreSearchAttribute : Attribute
    {

    }
}
