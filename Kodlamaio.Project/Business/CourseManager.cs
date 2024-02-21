using Kodlamaio.Project.DataAccess.Abstract;
using Kodlamaio.Project.DataAccess.Concrest;
using Kodlamaio.Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.Project.Business
{
    public class CourseManager
    {
        ICourseDal _courseDal;
        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }
        public CourseManager(CourseDal courseDal) {

            _courseDal = courseDal;

        }

        public List<Course> GetAll(){

            //business rules
            // CourseDal courseDal = new CourseDal();
            return _courseDal.GetAll();

}
    }


    

}
