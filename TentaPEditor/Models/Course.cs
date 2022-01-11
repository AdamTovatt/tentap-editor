﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentaPEditor.Models
{
    public class Course
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual List<Module> Modules { get; set; }

        public override string ToString()
        {
            return string.Format("({0}) {1}", Modules.Count, Name);
        }
    }
}
