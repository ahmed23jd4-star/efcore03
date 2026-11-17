using efcore03.confiquearating;
using efcore03.dbcontext;
using efcore03.models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Channels;

namespace efcore03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using projectdbcontex contex = new projectdbcontex();
            contex.Database.Migrate();
            if (!contex.Set<student>().Any())
            {
                contex.Set<student>().AddRange(
                new student {fullname = "Mohamed Adel", email = "mohamed@mail.com" },
                 new student { fullname = "Nour Ibrahim", email = "nour@mail.com" },
                 new student {fullname = "Youssef Tarek", email = "youssef@mail.com" },
                    new student { fullname = "Mariam Samy", email = "mariam@mail.com" },
                    new student { fullname = "Hana Mostafa", email = "hana@mail.com" });

                contex.SaveChanges();
            }
            if (!contex.Set<enrolment>().Any())
            {
                contex.Set<enrolment>().AddRange(
        new enrolment { studentid = 2, courseid = 1, statuesstudent = statuesstudent.Completed },
        new enrolment { studentid = 1, courseid = 3, statuesstudent = statuesstudent.Active },
        new enrolment { studentid = 1, courseid = 1, statuesstudent = statuesstudent.Active },
        new enrolment { studentid = 2, courseid = 2, statuesstudent = statuesstudent.Completed },
        new enrolment { studentid = 3, courseid = 6, statuesstudent = statuesstudent.Active },
        new enrolment { studentid = 2, courseid = 3, statuesstudent = statuesstudent.Dropped },
        new enrolment { studentid = 3, courseid = 2, statuesstudent = statuesstudent.Active },
        new enrolment { studentid = 4, courseid = 1, statuesstudent = statuesstudent.Dropped });
                contex.SaveChanges();
            }

            //Instructors instructors01 = new Instructors() { fullname="ahmedashraf" , datejoining = new DateTime(2000,05,11)};
            //Console.WriteLine(contex.Entry(instructors01).State);
            //contex.Set<Instructors>().Add(instructors01);
            //Console.WriteLine(contex.Entry(instructors01).State);
            //Console.WriteLine(instructors01.id);
            //contex.SaveChanges();

            //Update
            var course01 = new course() { id = 1, title = "aaaa" };
            contex.Set<course>().Update(course01);

            //deleate 
            var enroll01 = contex.Set<enrolment>().Find(1,1);
            contex.Set<enrolment>().Remove(enroll01);
            // bulk
            var course002 = contex.Set<course>().Where(c => c.price > 0).ExecuteUpdate<course>(c => c.SetProperty(c=>c.price ,c=> c.price* 2)) ;
            //Bulk delete:
            var enrolment002 = contex.Set<enrolment>().Where(e => e.statuesstudent == statuesstudent.Completed).ExecuteDelete();
        }
    }
}
