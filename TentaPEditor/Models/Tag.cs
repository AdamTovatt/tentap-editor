using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentaPEditor.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Exercise> Exercises { get; set; }

        public Tag() { }

        public override string ToString()
        {
            return string.Format("({0}) {1}", Exercises.Count, Name);
        }
    }
}
