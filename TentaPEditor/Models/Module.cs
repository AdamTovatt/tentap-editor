using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentaPEditor.Models
{
    public class Module
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Tag> Tags { get; set; }

        public Module() { }

        public override string ToString()
        {
            return string.Format("({0}) {1}", Tags.Count, Name);
        }
    }
}
