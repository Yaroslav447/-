using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlWord_4
{
    class Auto : Transport
    {
        public int Probeg;
        public string techosmotr;


        public void CarWrite()
        {
            Console.WriteLine($"Марка:{Mark} Цена:{price} Номер:{number} Мощность:{power} Пробег:{Probeg} Техосмотр:{techosmotr}");
        }
        public void CarExpensive()
        {
            Console.WriteLine($"Стоимость самой дорогой машины {price} руб");//метод вывода самой дорогой машины
        }

        public void CarСhoice()
        {
            Console.WriteLine($"Стоимость  машины {price} руб, пробег машины:{Probeg} км");
        }

        public void CarTexocmotr() 
        {
            Console.WriteLine($"Пройден ли техосмотр: {techosmotr}");
        }
    }
           
}

