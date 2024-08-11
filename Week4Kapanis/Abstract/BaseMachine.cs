using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Kapanis.Abstract
{
    public abstract class BaseMachine
    {
        public BaseMachine() 
        {
            DateOfManufacture = DateTime.Now;                   //Base classı inheritance eden classları nesne oluşturduğunda üretim tarihi şimdiki tarihe atanacak
        }
        public string Name { get; set; }
        public DateTime DateOfManufacture { get; set; }         //üretim tarihi
        public string SerialNumber { get; set; }                //tc kimlik nosu gibi birşet olduğu için string veri tipi kullanıldı
        public string Description { get; set; }                 //açıklama
        public string OperatingSystem { get; set; }             //işletim sistemi


        public virtual void DisplayInfo()                       //bilgileri yazdırma metodu
        {
            Console.WriteLine("Makinenin ismi : " + Name + " Üretim Tarihi :  " + DateOfManufacture + " Seri Numarası : " + SerialNumber + "Açıklama : " + Description + "İşletim Sistemi : " + OperatingSystem);
        }

        public abstract void GetProductName();
        
    }
}
