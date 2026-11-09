using Tyuiu.FedorovskikhEO.Sprint5.Task0.V28.Lib;
namespace Tyuiu.FedorovskikhEO.Sprint5.Task0.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3;

            DataService ds = new DataService();

            Console.WriteLine("**************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                *");
            Console.WriteLine("**************************************************");

            Console.WriteLine("x = " + x);


            Console.WriteLine("**************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                       *");
            Console.WriteLine("**************************************************");

            string result =ds.SaveToFileTextData(x);
            Console.WriteLine("Файл: "+result);
            Console.WriteLine("Создан!");

            Console.ReadKey();
        }
    }
}
