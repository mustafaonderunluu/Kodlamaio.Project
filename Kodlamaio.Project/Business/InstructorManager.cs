using Kodlamaio.Project.DataAccess.Abstract;
using Kodlamaio.Project.Entities;
using System.Collections.Generic;

namespace Kodlamaio.Project.Business
{
    
    public class InstructorManager
    {
        IInstructorDal _ınstructorDal;
        public InstructorManager(IInstructorDal ınstructorDal)
        {

            _ınstructorDal = ınstructorDal;
        }
        public List<Instructor> GetAll()
        {

            return _ınstructorDal.GetAll();

        }


    }





}
