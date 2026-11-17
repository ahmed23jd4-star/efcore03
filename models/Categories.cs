using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efcore03.models
{
    public class Categories
    {
        public int id{ get; set; }
        public string name{ get; set; }
        public string? describe{ get; set; }
        public int? parentid{ get; set; }
        public Categories? parentcatefory{ get; set; } // done
        public ICollection<Categories> manyCategories = new HashSet<Categories>(); //done

        public ICollection<course>? manycourse = new HashSet<course>(); // done 
        
    }
}
