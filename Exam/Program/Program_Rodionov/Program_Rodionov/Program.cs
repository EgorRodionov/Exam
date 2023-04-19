using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Rodionov
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                int cntApp = 0;
                Console.WriteLine("Количество приложений:");
                cntApp = Convert.ToInt32(Console.ReadLine());
                if (cntApp < 1)
                {
                    Console.WriteLine("Кол-во приложений меньше единицы!");
                }
                else
                {
                    AppLib appLib = new AppLib(cntApp);
                    appLib.Fill();
                    //appLib.Sort();
                    appLib.PrintToFile();
                }
            }
            catch (Exception ex) // Повторение предыдущего кода
            {
                int cntApp = 0;
                Console.WriteLine("Количество приложений:");
                cntApp = Convert.ToInt32(Console.ReadLine());
                if (cntApp < 1)
                {
                    Console.WriteLine("Кол-во приложений меньше единицы!");
                }
                else
                {
                    AppLib appLib = new AppLib(cntApp);
                    appLib.Fill();
                    //appLib.Sort();
                    appLib.PrintToFile();
                }
            }

        }
    }
}
