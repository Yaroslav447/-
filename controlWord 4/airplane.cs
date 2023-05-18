using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlWord_4
{
    class Airplane: Transport
    {
        public int Max_height_plane;

  
        public void PlaneInfo()// метод выводящий информацию о cамолете
        {
            Console.WriteLine($"Марка: {Mark} Номер:{number} Мощность: {power} Стоимость: {price} Максимальная высота полета: {Max_height_plane}");
        }
        public void PlaneExpensive()//мощность, стоимость и маркa самого дорогого самолета
        {
            Console.WriteLine($"Стоимость самого дорогого самолета {price} руб, Мощность данного самолета:{power},Марка {Mark}");//метод вывода самой дорогой машины
        }



    }
}
