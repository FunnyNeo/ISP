using System;
using System.Collections.Generic;
using Cars.Models;

namespace Cars
{
    public delegate void GetName(Car c);
    
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            cars.Add(new Bmw("Bmw Car", new List<string>(new []{"black", "white"}), 250, "Offroad", 2500));
            cars.Add(new Ford("Ford Car", new List<string>(new []{"black", "white"}), 400, "City", 4500));
            cars.Add(new Ferrari("Ferrari Car", new List<string>(new []{"black", "white"}), 600, "City", 9500));
            cars.Add(new Volkswagen("Volkswagen Car", new List<string>(new []{"black", "white"}), 320, "Offroad", 3500));
            cars.Add(new Audi("Audi Car", new List<string>(new []{"black", "white"}), 300, "Offroad", 1500));
            cars.Add(new Opel("Opel Car", new List<string>(new []{"black", "white"}), 250, "City", 1500));
            cars.Add(new Porsche("Porsche Car", new List<string>(new []{"black", "white"}), 150, "City", 5500));

            foreach (Car c in cars)
            {
                c.SlapRoof();
                Console.WriteLine($"{c}\n");
            }
            
            
            // Events
            Ford f = new Ford("Ford Car", new List<string>(new[] {"black", "white"}), 400, "City", 4500);
            
            f.ChangeColor(0);
            f.ChangeColor(1);

            //подписываем функцию ColorChanged
            f.ColorChanged += (s, e) => Console.WriteLine($"Смена цвета на: {e.Color} в {((Ford) s).Name} / лямбда - выражение");


            f.ChangeColor(0);
            f.ChangeColor(1);
            //Делегат
            f.ColorChanged += delegate(object? s, ColorEventArgs e)
            {
                Console.WriteLine($"Смена цвета на: {e.Color} в {((Ford) s).Name} / анонимной функции");
            };
            
            f.ChangeColor(0);
            f.ChangeColor(1);
            
            // Анонимная функция
            GetName gn = delegate(Car c)
            {
                Console.WriteLine($"{c.Name} / анонимная функция");
            };
            
            // Лямбда - выражение
            GetName gnAnonymous = car => Console.WriteLine($"{car.Name} / лямбда - выражение");
            
            foreach (Car c in cars)
            {
                gn(c);
                gnAnonymous(c);
            }
            
            // Исключения
            for (int i = 0; i <= 10; i++)
            {
                try
                {
                    int _ = 0 / i;
                }
                catch (ArithmeticException ex)
                {
                    // Арифметиеское исключение
                    Console.WriteLine($"Division error by: {i}");
                }
                catch
                {
                    // Пустой catch, который ловит все что не было выше
                    Console.WriteLine("I dont know wtf is happende");
                }
                finally
                {
                    //Выполняется всегда
                    Console.WriteLine($"current number {i}");
                }
            }
        }
    }
}