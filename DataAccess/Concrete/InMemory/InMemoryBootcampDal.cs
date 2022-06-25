using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    //BootCamp ile ilgili veri erişim kodlarını yazıcam
    public class InMemoryBootcampDal : IBootcampDal
    {
        List<Bootcamp> _bootcamps; // Global değişkenini oluşturdum

        public InMemoryBootcampDal() //Bellekte referans aldığı zaman çalışıcak olan constructor bloğu
        {
            //Veritabanından geliyormuş gibi simüle edicem ilk etapta
            _bootcamps = new List<Bootcamp>();
            new Bootcamp {BootcampId=1,BootcampName="Arvato.Net",Topic=".Net Core",Trainer="Serkan Çayır",Deadline="03.07.2022",Place="Online",RecordStatus=1};
            new Bootcamp { BootcampId = 2, BootcampName = "Logo Spring Bootcamp",Topic="Java + Springboot", Trainer = "Ali Bişey", Deadline = "03.03.2022", Place = "Online",RecordStatus=2 };

        }
        public List<Bootcamp> GetAll()
        {
            return _bootcamps;
        }
    }
}
