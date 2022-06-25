using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAdminService
    {
        void Add(Bootcamp bootcamp);
        void Add(Student student);

        void Delete(Student student);   
        void Delete(Bootcamp bootcamp);
    }
}
