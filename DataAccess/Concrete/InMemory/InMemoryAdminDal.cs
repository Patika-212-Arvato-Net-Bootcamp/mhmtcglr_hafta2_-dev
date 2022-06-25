using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryAdminDal : IAdminDal
    {
       
        List<Bootcamp> _bootcamps;
        List<Student> _students;
        public InMemoryAdminDal()
        {
            _bootcamps = new List<Bootcamp>();
            _students = new List<Student>();    
            new Bootcamp { BootcampId = 1, BootcampName = "Arvato.Net", Topic = ".Net Core", Trainer = "Serkan Çayır", Deadline = "03.07.2022", Place = "Online", RecordStatus = 1 };
            new Bootcamp { BootcampId = 2, BootcampName = "Logo Spring Bootcamp", Topic = "Java + Springboot", Trainer = "Ali Bişey", Deadline = "03.03.2022", Place = "Online", RecordStatus = 2 };
            new Student {StudentId=1,StudentName="Mehmet",StudentSurname="Çağlar",Age=23};
            new Student {StudentId=2,StudentName="Ali",StudentSurname="Veli",Age=24 };
        }

        public void Add(Bootcamp bootcamp)
        {
            _bootcamps.Add(bootcamp);
        }

        public void Add(Student student)
        {

            _students.Add(student);   
        }

        public void Delete(Bootcamp bootcamp)
        {
            Bootcamp bootcampToDelete = _bootcamps.SingleOrDefault(b=>b.BootcampId==bootcamp.BootcampId);
            _bootcamps.Remove(bootcampToDelete); // benim gönderdiğim bootcampid eşit değilse siler     
        }

        public void Delete(Student student)
        {
            Student studentToDelete = _students.SingleOrDefault(s=>s.StudentId==student.StudentId);
            _students.Remove(studentToDelete);
        }
    }
}
