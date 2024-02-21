using Kodlamaio.Project.DataAccess.Abstract;
using Kodlamaio.Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.Project.DataAccess.Concrest
{
    public class InstructorDal:IInstructorDal
    {
        List<Instructor> instructors;
        public InstructorDal()
        {
            Instructor ınstructor1 = new Instructor();
            ınstructor1.Name = "Engin Demiroğ";
            ınstructor1.Id= 1;
            ınstructor1.NotionalIdentity = "123";


            Instructor ınstructor2 = new Instructor();
            ınstructor2.Name = "Salih ";
            ınstructor2.Id = 2;
            ınstructor2.NotionalIdentity = "14";


            instructors = new List<Instructor> { ınstructor1, ınstructor2 };
        }
        public List<Instructor>GetAll()
        {
            return instructors;
        }
        public void Add(Instructor instructor) { 
        
        instructors.Add(instructor);
        }
        public void Remove(Instructor instructor) {  instructors.Remove(instructor); }
        public void Update(Instructor updatedInstructors)
        {
            // Güncellenecek öğeyi bul
            Instructor existingInstrucktor = instructors.FirstOrDefault(i => i.Id == updatedInstructors.Id); ;
            //Eğer bulursa
            if (existingInstrucktor != null)
            {


                existingInstrucktor.Name = updatedInstructors.Name;
                existingInstrucktor.NotionalIdentity = updatedInstructors.NotionalIdentity;
            }
            else {
                throw new ArgumentException("Güncellenecek öğe bulunamadı");
            
            
            
            }
        }

    }
}
