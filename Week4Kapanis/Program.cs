using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using Week4Kapanis.Abstract;
using Week4Kapanis.Concrete;

internal class Program
{
    public static void Main(string[] args)
    {

        string answer = "";

        while (answer != "hayır")           //cevap hayır olmadığı sürece bu döngüye gir
        {
            int choise;                     //Telefon veya pc seçimi atanacak değişken

            Console.WriteLine("Telefon üretmek için 1 bilgisayar üretmek için 2'ye basınız.");          
            choise = Convert.ToInt32(Console.ReadLine());

            switch (choise)
            {
                case 1:                     //1 e tıklandığında nu case e girer
                    

                    Telephone phone = new Telephone();

                    Console.WriteLine("isim giriniz");
                    phone.Name = Console.ReadLine();

                    Console.WriteLine(phone.DateOfManufacture);           

                    Console.WriteLine("Seri numarasını giriniz");
                    phone.SerialNumber = Console.ReadLine();

                    Console.WriteLine("Açıklama giriniz");
                    phone.Description = Console.ReadLine();

                    Console.WriteLine("İşletim sistemini giriniz");
                    phone.OperatingSystem = Console.ReadLine();

                    Console.WriteLine("Lisans bilgisini giriniz (true/false)");
                    phone.IsTrLicense = Convert.ToBoolean(Console.ReadLine().ToLower());

                    phone.DisplayInfo();                                //base class ta oluşturulan metotlar çağırılır
                    phone.GetProductName();

                    Console.WriteLine("Ürün Başarıyla Üretildi ! Başka bir ürün elde etmek ister misiniz ? ");      
                    answer = Console.ReadLine().ToLower();                  //kullanıcıya tekrar üretim yapıp yapmıyacağına dair soru yöneltilip verdiği cevap answer değişkenine atılır
                    Console.WriteLine("------------------");
                    break;

                case 2:
                    
                    Computer computer = new Computer();

                    Console.WriteLine("isim giriniz");
                    computer.Name = Console.ReadLine();

                    Console.WriteLine(computer.DateOfManufacture);

                    Console.WriteLine("Seri numarasını giriniz");
                    computer.SerialNumber = Console.ReadLine();

                    Console.WriteLine("Açıklama giriniz");
                    computer.Description = Console.ReadLine();

                    Console.WriteLine("USB Port sayısını giriniz");
                    computer.NumberofUSBPorts = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("İşletim sistemini giriniz");
                    computer.OperatingSystem = Console.ReadLine();

                    Console.WriteLine("Lisans bilgisini giriniz (true/false)");
                    computer.Bluetooth = Convert.ToBoolean(Console.ReadLine().ToLower());

                    computer.DisplayInfo();
                    computer.GetProductName();

                    Console.WriteLine("Ürün Başarıyla Üretildi ! Başka bir ürün elde etmek ister misiniz ? ");
                    answer = Console.ReadLine().ToLower();
                    Console.WriteLine("------------------");


                    break;
            }


        }
        if (answer == "hayır")
        {
            Console.WriteLine("İyi günler dileriz");
        }



    }
}