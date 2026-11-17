namespace efcore03.models
{
    public class enrolment
    {
        public int studentid { get; set; }
        public int courseid { get; set; }
        public statuesstudent statuesstudent { get; set; }
        public decimal? Finalgrade { get; set; } // exisit validation 
        public int  Progress { get; set; }
        public DateTime joindate{ get; set; }
        public student onestudent{ get; set; }
        public course onecourse{ get; set; }
    }
}