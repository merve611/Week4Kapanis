using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Week4Kapanis.Abstract;

namespace Week4Kapanis.Concrete
{
    public class Telephone:BaseMachine
    {
        public bool IsTrLicense { get; set; }               //tr lisansı var mı

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.Write(IsTrLicense ? "Tr lisansı var" : "Tr lisansı yok");
        }

        public override void GetProductName()               //Base class tan ımplemente edi
        {
            Console.WriteLine("Telefonunuzun Adı --->" + Name);
        }
    }
}
