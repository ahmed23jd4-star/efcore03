using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efcore03.models
{
    public class student
    {
        public int id { get; set; }
        public string fullname { get; set; }
        public string email { get; set; }
        public DateTime datebrith { get; set; }
        public ICollection<enrolment> manyenrollment = new HashSet<enrolment>();

    }
}
