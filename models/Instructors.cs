using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efcore03.models
{
    public class Instructors
    {
        public  int id { get; set; }
        public string fullname { get; set; }
        public string? Bio { get; set; }
        public DateTime datejoining { get; set; }
        public ICollection<course>? coursess = new HashSet<course>();
        



    }
}
