using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class Furniture//Класс мебели
    {
        private string type;
        private string name;
        private string model;
        private string product_code;
        private string color;
        private double price;
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
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
        public string ProductCode
        {
            get
            {
                return product_code;
            }
            set
            {
                product_code = value;
            }
        }
        public string Color
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
        public virtual void AboutFurniture()
        {

        }
    }
    public class Table : Furniture//Класс столов
    {
        static int count = 0;     

        public Table( string name, string model, string product_code, string color, double price)
        {       
            Type = "Стол";
            Name = name;
            Model = model;
            ProductCode = product_code;
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

            set
            {
                count = value;
            }
        }
        public override void AboutFurniture()
        {
            Type = Type;
            Name = Name;
            Model = Model;
            ProductCode = ProductCode;
            Color = Color;
            Price = Price;
            Count = count;
        }
    }
    public class Chair : Furniture//Класс стульев
    {
        static int count = 0;

        public Chair( string name, string model, string product_code, string color, double price)
        {
            Type = "Стул";
            Name = name;
            Model = model;
            ProductCode = product_code;
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

            set
            {
                count = value;
            }
        }
        public override void AboutFurniture()
        {
            Type = Type;
            Name = Name;
            Model = Model;
            ProductCode = ProductCode;
            Color = Color;
            Price = Price;
            Count = count;
        }
    }
    public class Shelf : Furniture//Класс полок
    {
        static int count = 0;

        public Shelf(string name, string model, string product_code, string color, double price)
        {
            Type = "Полка";
            Name = name;
            Model = model;
            ProductCode = product_code;
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
        public override void AboutFurniture()
        {
            Type = Type;
            Name = Name;
            form.ModelLB.Text = Model;
            form.ProductCodeLB.Text = ProductCode;
            form.ColorLB.Text = Color;
            form.PriceLB.Text = Price.ToString();
            Count = count;
        }
    }
    public class Сupboard : Furniture//Класс шкафов
    {
        static int count = 0;
        Form1 form;

        public Сupboard(Form1 frm, string name, string model, string product_code, string color, double price)
        {
            form = frm;
            Type = "Шкаф";
            Name = name;
            Model = model;
            ProductCode = product_code;
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
        public override void AboutFurniture()
        {
            form.TypeLB.Text = Type;
            form.NameLB.Text = Name;
            form.ModelLB.Text = Model;
            form.ProductCodeLB.Text = ProductCode;
            form.ColorLB.Text = Color;
            form.PriceLB.Text = Price.ToString();
            form.CountLB.Text = count.ToString();
        }
    }
    public class Nightstand : Furniture//Класс тумбочек
    {
        static int count = 0;
        Form1 form;

        public Nightstand(Form1 frm, string name, string model, string product_code, string color, double price)
        {
            form = frm;
            Type = "Тумба";
            Name = name;
            Model = model;
            ProductCode = product_code;
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
        public override void AboutFurniture()
        {
            form.TypeLB.Text = Type;
            form.NameLB.Text = Name;
            form.ModelLB.Text = Model;
            form.ProductCodeLB.Text = ProductCode;
            form.ColorLB.Text = Color;
            form.PriceLB.Text = Price.ToString();
            form.CountLB.Text = count.ToString();
        }
    }
}

class Program
    {
        static void Main(string[] args)
        {
        }
    }

