using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    
    public class Bootcamp:IEntity  //Bu class bizim için bir veritabanı nesnesidir.
    {
        public int BootcampId { get; set; }
        public string BootcampName { get; set; }
        public  string Topic { get; set; }

        public string Place { get; set; }

        public  string Deadline { get; set; }

        public string Trainer { get; set; }

        public int RecordStatus { get; set; } // 1 ise Aktif 2 İse bootcampin geçmiş olduğunu anlatır.

    }
}
