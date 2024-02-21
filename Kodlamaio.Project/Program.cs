using Kodlamaio.Project.Business;
using Kodlamaio.Project.DataAccess.Abstract;
using Kodlamaio.Project.DataAccess.Concrest;
using Kodlamaio.Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.Project
{
    public class Program
    {
        static void Main(string[] args)
        {
            CourseManager courseManager = new(new CourseDal());
            List<Course> course = courseManager.GetAll();

            foreach (var courses in course) {


                Console.WriteLine("Kurslar : "+courses.Name+"*****İçerik : "+courses.Description);

            }
            Console.WriteLine( " Kurslar Listelendi ");

            InstructorManager ınstructorManager = new(new InstructorDal());
            List<Instructor> ınstructors = ınstructorManager.GetAll();
            foreach (var ınstructor in ınstructors)
            {
                Console.WriteLine("Eğitmenler : "+ınstructor.Name+"/ Eğitmen Numarası :  "+ınstructor.NotionalIdentity);
            }


        }
    }
}
