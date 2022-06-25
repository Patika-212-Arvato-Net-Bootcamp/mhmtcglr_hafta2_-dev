using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Admin:IEntity //Bu class bizim için bir veritabanı nesnesidir.
    {
        public int AdminId { get; set; }

        public string AdminName { get; set; }
        public string AdminSurname { get; set; }
    }
}
