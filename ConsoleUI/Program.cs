using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    // Test etmek için bu alanı oluşturdum.
    class Program
    {
        static void Main(string[] args) 
        {
            BootcampManager bootcampManager = new BootcampManager(new InMemoryBootcampDal()); //In Memory Çalışcam

            foreach (var bootcamp in bootcampManager.GetAll())
            {
                Console.WriteLine(bootcamp.BootcampName);
            }
        
        }


    }

}