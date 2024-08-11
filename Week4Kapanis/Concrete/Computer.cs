using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week4Kapanis.Abstract;

namespace Week4Kapanis.Concrete
{
    public class Computer:BaseMachine
    {
        private int _numberUsbPorts;           //fields
        public int NumberofUSBPorts 
        {
            get
            {
                return _numberUsbPorts;
            }
            set
            {
                if (value == 2 || value == 4)
                {
                    _numberUsbPorts = value;
                }
                else
                {
                    Console.WriteLine("Yanlış UBS sayısı girdiniz");
                    _numberUsbPorts = -1;

                }
            }
        }       //USB giriş sayısı
        public bool Bluetooth { get; set; }             //Bluetooth var mı

        public override void DisplayInfo()  
        {
            base.DisplayInfo();
            Console.Write(Bluetooth ? "Bluetooth özelliği var" : "Bluetooth özelliği yok");
            Console.Write("USB Port sayısı : " + NumberofUSBPorts);
        }

        public override void GetProductName()           
        {
            Console.WriteLine("Bilgisayarınızın Adı --->" + Name);
        }
    }
}
