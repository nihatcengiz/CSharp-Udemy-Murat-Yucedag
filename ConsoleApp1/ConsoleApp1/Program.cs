using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad;
            Console.WriteLine("ogrenci adi: ");
            ad = Console.ReadLine();

            string soyad;
            Console.WriteLine("ogrenci soyadi: ");
            soyad = Console.ReadLine();

            Ogrenci ogr= new Ogrenci(ad, soyad);
            Console.Read();
           
        }
    }
}
