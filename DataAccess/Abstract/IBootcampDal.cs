using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IBootcampDal //Burada veri tabanı operasyonlarını yapıcam ekle sil güncelle vb
    {
        List<Bootcamp> GetAll();


       
        
    }
}
