using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace Labaaa3
    {
        class Program
        {
            static public List<Bmw> BmwList;//List - это шаблон
            static public List<Mersedes> MersedesList;
            static public List<Bentley> BentleyList;
            static public List<Nissan> NissanList;
            static public List<Mazda> MazdaList;
            static void Main(string[] args)
            {
                BmwList = new List<Bmw>();
                MersedesList = new List<Mersedes>();
                BentleyList = new List<Bentley>();
                NissanList = new List<Nissan>();
                MazdaList = new List<Mazda>(); 
            start: Console.WriteLine("Программа учета автомобилей");
                Console.WriteLine("1 - посмотреть автомобиль");
                Console.WriteLine("2 - посмотреть автомобиль(подробная информация)");
                Console.WriteLine("3 - добавить автомобиль");
                Console.WriteLine("4 - выход");
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        foreach (Bmw item in BmwList)
                        {
                            item.AboutCar();
                        }
                        foreach (Mersedes item in MersedesList)
                        {
                            item.AboutCar();
                        }
                        foreach (Bentley item in BentleyList)
                        {
                            item.AboutCar();
                        }
                        foreach (Nissan item in NissanList)
                        {
                            item.AboutCar();
                        }
                        foreach (Mazda item in MazdaList)
                        {
                            item.AboutCar();
                        }
                        goto start;
                    case 2:
                        foreach (Bmw item in BmwList)
                        {
                            item.AboutCar(true);
                        }
                        foreach (Mersedes item in MersedesList)
                        {
                            item.AboutCar(true);
                        }
                        foreach (Bentley item in BentleyList)
                        {
                            item.AboutCar(true);
                        }
                        foreach (Nissan item in NissanList)
                        {
                            item.AboutCar(true);
                        }
                        foreach (Mazda item in MazdaList)
                        {
                            item.AboutCar(true);
                        }
                        goto start;
                    case 3:
                        Console.WriteLine("Укажите марку автомобиля:");
                        Console.WriteLine("1 - BMW");
                        Console.WriteLine("2 - Mersedes");
                        Console.WriteLine("3 - Bentley");
                        Console.WriteLine("4 - Nissan");
                        Console.WriteLine("5 - Mazda");
                        n = Convert.ToInt32(Console.ReadLine());                      
                        Types type;
                        string name;
                        string model;
                        string car_code;
                        string color;
                        double price;
                        switch (n)
                        {
                            case 1:
                                Console.WriteLine("Имеющееся типы:");
                                type = Types.Passenger;
                                Console.WriteLine(type);
                                Console.WriteLine("Укажите название:");
                                name = Console.ReadLine();
                                Console.WriteLine("Укажите тип:");
                                model = Console.ReadLine();
                                Console.WriteLine("Укажите код автомобиля:");
                                car_code = Console.ReadLine();
                                Console.WriteLine("Укажите цвет:");
                                color = Console.ReadLine();
                                Console.WriteLine("Укажите цену:");
                                price = Convert.ToDouble(Console.ReadLine());
                                Bmw item = new Bmw(type, name, model, car_code, new string[] { color }, price);
                                BmwList.Add(item);
                                Console.WriteLine("Автомобиль успешно добавлен!");
                                goto start;
                            case 2:
                                Console.WriteLine("Укажите название:");
                                name = Console.ReadLine();
                                Console.WriteLine("Укажите тип:");
                                model = Console.ReadLine();
                                Console.WriteLine("Укажите код автомобиля:");
                                car_code = Console.ReadLine();
                                Console.WriteLine("Укажите цвет:");
                                color = Console.ReadLine();
                                Console.WriteLine("Укажите цену:");
                                price = Convert.ToDouble(Console.ReadLine());
                                Mersedes item2 = new Mersedes(name, model, car_code, new string[] { color }, price);
                                MersedesList.Add(item2);
                                Console.WriteLine("Автомобиль успешно добавлен!");
                                goto start;
                            case 3:
                                Console.WriteLine("Укажите название:");
                                name = Console.ReadLine();
                                Console.WriteLine("Укажите тип:");
                                model = Console.ReadLine();
                                Console.WriteLine("Укажите код автомобиля:");
                                car_code = Console.ReadLine();
                                Console.WriteLine("Укажите цвет:");
                                color = Console.ReadLine();
                                Console.WriteLine("Укажите цену:");
                                price = Convert.ToDouble(Console.ReadLine());
                                Bentley item3 = new Bentley(name, model, car_code, new string[] { color }, price);
                                BentleyList.Add(item3);
                                Console.WriteLine("Автомобиль успешно добавлен!");
                                goto start;
                            case 4:
                                Console.WriteLine("Укажите название:");
                                name = Console.ReadLine();
                                Console.WriteLine("Укажите тип:");
                                model = Console.ReadLine();
                                Console.WriteLine("Укажите код автомобиля:");
                                car_code = Console.ReadLine();
                                Console.WriteLine("Укажите цвет:");
                                color = Console.ReadLine();
                                Console.WriteLine("Укажите цену:");
                                price = Convert.ToDouble(Console.ReadLine());
                                Nissan item4 = new Nissan(name, model, car_code, new string[] { color }, price);
                                NissanList.Add(item4);
                                Console.WriteLine("Автомобиль успешно добавлен!");
                                goto start;
                            case 5:
                                Console.WriteLine("Укажите название:");
                                name = Console.ReadLine();
                                Console.WriteLine("Укажите тип:");
                                model = Console.ReadLine();
                                Console.WriteLine("Укажите код автомобиля:");
                                car_code = Console.ReadLine();
                                Console.WriteLine("Укажите цвет:");
                                color = Console.ReadLine();
                                Console.WriteLine("Укажите цену:");
                                price = Convert.ToDouble(Console.ReadLine());
                                Mazda item5 = new Mazda(name, model, car_code, new string[] { color }, price);
                                MazdaList.Add(item5);
                                Console.WriteLine("Автомобиль успешно добавлен!");
                                goto start;
                            default:
                                Console.WriteLine("Вы не указали марку автомобиля!");
                                goto start;
                        }
                    case 4:
                        break;
                    default:
                        goto start;
                }
            }
        }
         public enum Types { Jeep, Passenger, Truck, Minivan }
         public class Car//Класс автомобилей
         {
            public Types types;
            private string name;
            private string model;
            private string car_code;
            private string[] color;
            private double price;

            public Types Type
            {
                get
                {
                    return types;
                }
                set
                {
                    types = value;
                }
            }
            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }
            public string Model
            {
                get
                {
                    return model;
                }
                set
                {
                    model = value;
                }
            }
            public string this[int index] 
            {
                get
                {
                    return color[index];
                }
                set
                {
                    color[index] = value;
                }
            }
            public string[] Color 
            {
                get
                {
                    return color;
                }
                set
                {
                   color = value;
                }
            }
            public string CarCode
            {
                get
                {
                     return car_code;
                }
                set
                {
                      car_code = value;
                }
            }
            public double Price
            { 
                get
                {
                    return price;
                }
                set
                {
                    price = value;
                }
            }
            public virtual void AboutCar()
            {

            }
            public virtual void AboutCar(bool check)
            {
            
            }
         }


        public class Bmw : Car
        {
            static int count = 0;
        
        public Bmw(Types type ,string name, string model, string car_code, string[] color, double price)
        {
            Type = Type;
            Name = "BMW";
            Model = model;
            CarCode = car_code;
            Color = color;
            Price = price;
            count++;
            }
            public int Count
            {
                get
                {
                    return count;
                }
            }
            public override void AboutCar()
            {
                Console.WriteLine("");
                Console.WriteLine("Название: " + Name);
                Console.WriteLine("Тип: " + Type);
                Console.WriteLine("");
            }
            public override void AboutCar(bool check)
            {
                Console.WriteLine("");
                Console.WriteLine("Название: " + Name);
                Console.WriteLine("Тип: " + Type);
                Console.WriteLine("Модель: " + Model);
                Console.WriteLine("Код автомобиля: " + CarCode);
                Console.WriteLine("Цвет: " + String.Join(" ", Color));
                Console.WriteLine("Цена: " + Price);
                Console.WriteLine("В наличии: " + Count);
                Console.WriteLine("");
            }
        }
        public class Mersedes : Car
        {
            static int count = 0;

            public Mersedes(string name, string model, string car_code, string[] color, double price)
            {
                Type = Type;
                Name = "Mersedes";
                Model = model;
                CarCode = car_code;
                Color = color;
                Price = price;
                count++;
            }
            public int Count
            {
                get
                {
                    return count;
                }
            }
            public override void AboutCar()
            {
                Console.WriteLine("");
                Console.WriteLine("Название: " + Name);
                Console.WriteLine("Тип: " + Type);
                Console.WriteLine("");
            }
            public override void AboutCar(bool check)
            {
                Console.WriteLine("");
                Console.WriteLine("Название: " + Name);
                Console.WriteLine("Тип: " + Type);
                Console.WriteLine("Модель: " + Model);
                Console.WriteLine("Код автомобиля: " + CarCode);
                Console.WriteLine("Цвет: " + String.Join(" ", Color));
                Console.WriteLine("Цена: " + Price);
                Console.WriteLine("В наличии: " + Count);
                Console.WriteLine("");
            }
        }
        public class Bentley : Car
        {
            static int count = 0;

            public Bentley(string name, string model, string car_code, string[] color, double price)
            {
                Type = Type;
                Name = "Bentley";
                Model = model;
                CarCode = car_code;
                Color = color;
                Price = price;
                count++;
            }
            public int Count
            {
                get
                {
                    return count;
                }
            }
            public override void AboutCar()
            {
                Console.WriteLine("");
                Console.WriteLine("Название: " + Name);
                Console.WriteLine("Тип: " + Type);
                Console.WriteLine("");
            }
            public override void AboutCar(bool check)
            {
                Console.WriteLine("");
                Console.WriteLine("Название: " + Name);
                Console.WriteLine("Тип: " + Type);
                Console.WriteLine("Модель: " + Model);
                Console.WriteLine("Код автомобиля: " + CarCode);
                Console.WriteLine("Цвет: " + String.Join(" ", Color));
                Console.WriteLine("Цена: " + Price);
                Console.WriteLine("В наличии: " + Count);
                Console.WriteLine("");
            }
        }
        public class Nissan : Car
        {
            static int count = 0;

            public Nissan(string name, string model, string car_code, string[] color, double price)
            {
                Type = Type;
                Name = "Nissan";
                Model = model;
                CarCode = car_code;
                Color = color;
                Price = price;
                count++;
            }
            public int Count
            {
                get
                {
                    return count;
                }
            }
            public override void AboutCar()
            {
                Console.WriteLine("");
                Console.WriteLine("Название: " + Name);
                Console.WriteLine("Тип: " + Type);
                Console.WriteLine("");
            }
            public override void AboutCar(bool check)
            {
                Console.WriteLine("");
                Console.WriteLine("Название: " + Name);
                Console.WriteLine("Тип: " + Type);
                Console.WriteLine("Модель: " + Model);
                Console.WriteLine("Код автомобиля: " + CarCode);
                Console.WriteLine("Цвет: " + String.Join(" ", Color));
                Console.WriteLine("Цена: " + Price);
                Console.WriteLine("В наличии: " + Count);
                Console.WriteLine("");
            }
        }
        public class Mazda : Car
        {
            static int count = 0;

            public Mazda(string name, string model, string car_code, string[] color, double price)
            {
                Type = Type;
                Name = "Mazda";
                Model = model;
                CarCode = car_code;
                Color = color;
                Price = price;
                count++;
            }
            public int Count
            {
                get
                {
                    return count;
                }
            }
            public override void AboutCar()
            {
                Console.WriteLine("");
                Console.WriteLine("Название: " + Name);
                Console.WriteLine("Тип: " + Type);
                Console.WriteLine("");
            }
            public override void AboutCar(bool check)
            {
                Console.WriteLine("");
                Console.WriteLine("Название: " + Name);
                Console.WriteLine("Тип: " + Type);
                Console.WriteLine("Модель: " + Model);
                Console.WriteLine("Код автомобиля: " + CarCode);
                Console.WriteLine("Цвет: " + String.Join(" ", Color));
                Console.WriteLine("Цена: " + Price);
                Console.WriteLine("В наличии: " + Count);
                Console.WriteLine("");
            }
        }
    }
