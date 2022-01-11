using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentaPEditor.Models
{
    public class Source
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", Date.ToShortDateString(), Author);
        }
    }
}
