using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Rodionov
{
    public class App
    {
        public string Name;
        public string Manufacturer;
        public int DiskSize;

        //метод для обращения к данным класса App
        public App(string name, string manufacturer, int diskSize)
        {
            this.Name = name;
            this.Manufacturer = manufacturer;
            this.DiskSize = diskSize;
        }

        public string ToString() // Данные массива которые переводятся в текстовый файл
        {
            return string.Format("Наименование приложения: {0}  Производитель: {1} Размер на диске: {2}", Name, Manufacturer, DiskSize);
        }

    }
}
