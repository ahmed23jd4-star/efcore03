namespace efcore03.models
{
    public class course
    {
        public int id{ get; set; }
        public string title{ get; set; }
        public string? describe{ get; set; }
        public decimal price{ get; set; }
        public levelcouse level { get; set; }
        public Boolean flag{ get; set; }
        public DateTime? date{ get; set; }  // viladation if flag true don,t forget 
        public Instructors oneInstructors { get; set; } // done
        public int ?  instrucrorid { get; set; }  // done
        public Categories oneCategory { get; set; } // done
        public int catagoryid { get; set; } // done
        public ICollection<enrolment> manyenrolment = new HashSet<enrolment>();//done




    }
}