using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IAdminDal
    {
        void Add(Bootcamp bootcamp);
        void Delete(Bootcamp bootcamp);

        void Add(Student student);

        void Delete(Student student);  
    }
}
