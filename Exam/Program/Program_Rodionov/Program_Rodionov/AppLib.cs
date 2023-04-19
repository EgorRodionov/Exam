using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Program_Rodionov
{
    public class AppLib
    {
        int cntApp;
        public App[] app;

        public AppLib(int cntApp)
        {
            this.cntApp = cntApp;
            app = new App[cntApp];
        }

        public void Fill() //заполнение массива
        {
            string name;
            string manufacturer;
            int diskSize;
            try
            {
                for (int i = 0; i < this.cntApp; i++)
                {
                    Console.WriteLine("[Наименование приложения:");
                    name = Console.ReadLine();
                    Console.WriteLine("Введите производителя приложения:");
                    manufacturer = Console.ReadLine();
                    Console.WriteLine("Введите размер диска:");
                    diskSize = Convert.ToInt32(Console.ReadLine());
                    this.app[i] = new App(name, manufacturer, diskSize);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Введенные данные некорректны");
                Console.WriteLine("Введите данные заново:");
                Fill();
            }
        }
        public void Sort() // Функция сортировки
        {
            //Array.Sort(this.app);
        }

        public void PrintToFile() // Функция вывода в текстовый файл. Находится в Debug
        {
            using (StreamWriter file = new StreamWriter("result.txt", false, Encoding.UTF8))
            {
                foreach (App compared in this.app)
                {
                    file.WriteLine(compared.ToString());
                }
            }
        }


    }
}
