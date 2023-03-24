using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODUL5_1302210081
{
    internal class SimpleDataBase<T>
    {
        List <T> storedData { get; set; }
        List<DateTime> inputdates { get; set; }
        public SimpleDataBase()
        {
            storedData = new List<T>();
            inputdates = new List<DateTime>();
        }
        public void addNewData(T data)
        {
            storedData.Add(data);
            inputdates.Add(DateTime.Now);
        }
        public void PrintAllData()
        {
            for(int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine("Data "+(i+1) + " Berisi " + storedData.ElementAt(i)+ " yang disimpan pada waktu " + inputdates.ElementAt(i));
            }
        }
    }
}
