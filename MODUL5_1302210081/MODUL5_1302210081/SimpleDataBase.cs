using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODUL5_1302210081
{
    internal class SimpleDataBase
    {
        List <T> storedData { get; set; }
        List<DataTime> inputdates { get; set; }
        public SimpleDataBase()
        {
            storageData = new List<Task>();
            inputdates = new list<DataTime>();
        }
        public void addNewData(Task data)
        {
            storageData.add(data);
            inputdates.add(DateTime.new);
        }
        public void PrintAll Data()
        {
            for(int 1 = 0; int < storedData.Count; int++)
            {
                Console.WriteLine("Data ")
            }
        }
    }
}
