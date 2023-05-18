using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlWord_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Показать все команды:(Help)");
            string start = Console.ReadLine();
            //создание объектов машина, и добалвение их в список.
            Auto car1 = new Auto();
            car1.Mark = "Audi";
            car1.power = 12000;
            car1.number = "o250пр";
            car1.price = 1500;
            car1.Probeg = 934012;
            car1.techosmotr = "No";
            Auto car2 = new Auto();
            car2.Mark = "Stx";
            car2.power = 120000;
            car2.number = "с670рк";
            car2.price = 3020000;
            car2.Probeg = 0;
            car2.techosmotr = "Yes";
            Auto car3 = new Auto();
            car3.Mark = "Honda";
            car3.power = 12300032;
            car3.number = "х301ра";
            car3.price = 5000000;
            car3.Probeg = 100000;
            car3.techosmotr = "Yes";

            List<Auto> cars = new List<Auto>();
            cars.Add(car1);
            cars.Add(car2);
            cars.Add(car3);     
            //Создание объектов самолет, добавление их в список 
            Airplane airplane1 = new Airplane();
            airplane1.Mark = "Boeing";
            airplane1.power = 123000324;
            airplane1.price = 123100000;
            airplane1.Max_height_plane = 6000;
            airplane1.number = "12TTlG1";
            Airplane airplane2 = new Airplane();
            airplane2.Mark = "МС-21";
            airplane2.power = 12300000;
            airplane2.price = 93100000;
            airplane2.Max_height_plane = 4000;
            airplane2.number = "DF98JE";
            Airplane airplane3 = new Airplane();
            airplane3.Mark = "Ил-96-300";
            airplane3.power = 1500000;
            airplane3.price = 173100000;
            airplane3.Max_height_plane = 8000;
            airplane3.number = "KO62PS";

            List<Airplane> airplanes = new List<Airplane>();
            airplanes.Add(airplane1);
            airplanes.Add(airplane2);
            airplanes.Add(airplane3);       
            while (start != "Exit")//цикл в котором находится вся программа 
            {
               
                if(start=="Help")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Вывод всей информации о машинах в базе данных (Car)");
                    Console.WriteLine("Вывод всей информации о самолетах в базе данных (Plane)");           
                    Console.WriteLine("Вывод самой дорогой машины, с проверкой имеются ли техосмотр(Price_Expensive)");              
                    Console.WriteLine("Вывод стоимости, мощности, марки самого дорогого самолета(Info_Plane)");                
                    Console.WriteLine("Вывод пробег и стоимость выбранного автомобиля(Info_Сar) ");                  
                    Console.WriteLine("Вывод налога на все машины (Tax_Car)");                  
                    Console.WriteLine("Вывод налога на все самолеты(Tax_Plane)");                  
                    Console.WriteLine("Закончить программу(Exit)");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                
                if (start == "Car")//вывод БД машин
                {
                    foreach (Auto automobil in cars)
                    {
                        Console.WriteLine($"Марка:{automobil.Mark}, Цена:{automobil.price} руб, Номер:{automobil.number}, Мощность:{automobil.power}, Пробег:{automobil.Probeg} км, Техосмотр:{automobil.techosmotr}");
                    }
                        start = null;
                    start = Console.ReadLine();
                }
                if (start == "Plane")//вывод БД о самолетах
                {
                    foreach(Airplane airplane in airplanes) 
                    {
                        Console.WriteLine($"Марка: {airplane.Mark}, Номер:{airplane.number}, Мощность: {airplane.power}, Стоимость: {airplane.price} руб, Максимальная высота полета: {airplane.Max_height_plane} м");
                    }                 
                    start = null;
                    start = Console.ReadLine();
                }
                if (start == "Price_Expensive")//поиск самой дорогой машины, проверка пройден ли техосмотр
                {
                    if(car1.price>car2.price && car1.price >car3.price)
                    {
                        car1.CarExpensive();
                        car1.CarTexocmotr();
                    }
                    if (car2.price > car1.price && car2.price > car3.price)
                    {
                        car2.CarExpensive();
                        car2.CarTexocmotr();
                    }
                    if (car3.price > car1.price && car3.price > car2.price)
                    {
                        car3.CarExpensive();
                        car3.CarTexocmotr();
                    }
                    start = null;
                    start = Console.ReadLine();
                }
                if (start == "Info_Plane")//мощность, стоимость и маркa самого дорогого самолета 
                {
                    if (airplane1.price > car2.price && airplane1.price > car3.price)
                    {
                        airplane1.PlaneExpensive();
                       
                    }
                    if (airplane2.price > car1.price && airplane2.price > car3.price)
                    {
                        airplane2.PlaneExpensive();

                    }
                    if (airplane3.price > car2.price && airplane3.price > car1.price)
                    {
                        airplane3.PlaneExpensive();

                    }
                    start = null;
                    start = Console.ReadLine();
                }
                if (start =="Info_Car")//узнать пробег и стоимость выбранного авто
                {
                    Console.WriteLine($"Какой из {cars.Count} автомобилей интересует по стоимости и пробегу?(1/2/3)");
                    start = null;
                    start = Console.ReadLine();
                    if (start == "1")
                    {
                        car1.CarСhoice();
                    }
                    if (start == "2")
                    {
                        car2.CarСhoice();
                    }
                    if (start == "3")
                    {
                        car3.CarСhoice();
                    }
                    start = null;
                    start = Console.ReadLine();
                }
                if(start == "Tax_Car")//Налог на машину
                {
                    Console.WriteLine("Hалогооблажение на машины составляет 5% от стоимости");
                    Console.WriteLine();
                    foreach (Auto automobil in cars)
                    {
                        double TaxCar;
                        TaxCar = automobil.price * 5 / 100;
                        Console.WriteLine($"Марка:{automobil.Mark}, Cтоимость:{automobil.price} руб, Налог cоставляет: {TaxCar} руб");
                    }
                    start = null;
                    start = Console.ReadLine();
                }
                if (start == "Tax_Plane") //Налог с регистрации самолета
                { 
                   Console.WriteLine("Регистрация самолета  составляет 3% от стоимости");
                   Console.WriteLine();
                   foreach (Airplane airplane in airplanes)
                   {
                    double TaxPlane;
                    TaxPlane = airplane.price * 3 / 100;
                    Console.WriteLine($"Марка:{airplane.Mark}, Cтоимость:{airplane.price} руб, Налог cоставляет: {TaxPlane} руб");
                   }
                    start = null;
                    start = Console.ReadLine();
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Показать все команды:(Help)");
                Console.ForegroundColor = ConsoleColor.White;
                start = Console.ReadLine();
            }
        }
    }
}

