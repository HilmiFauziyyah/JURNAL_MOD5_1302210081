namespace MODUL5_1302210081
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleDataBase<float> data = new SimpleDataBase<float>();
            data.addNewData(13);
            data.addNewData(02);
            data.addNewData(21);
            data.addNewData(81);
            data.PrintAllData();
        }
    }
}