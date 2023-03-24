using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MODUL5_1302210081
{
    public class penjumlahan
    {
        private dynamic data;
        public penjumlahan() { }
        public void PenjumlahanTigaAngka<T>(T a, T b, T c)
        {
            dynamic aa = a;
            dynamic bb = b;
            dynamic cc = c;

            data = aa + bb + cc;
        }

        public void Print()
        {
            Console.WriteLine($"hasil penjumlahan: {this.data}");
        }
    }
}
