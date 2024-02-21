using Kodlamaio.Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.Project.DataAccess.Abstract
{
    public interface IInstructorDal
    {
        List<Instructor>GetAll();
        void Add(Instructor instructor);
        void Remove(Instructor instructor);
        void Update(Instructor updatedInstrucktor);

    }
}
