using System;
using System.Collections.Generic;
using System.Drawing;

namespace Cars.Models
{
    //Класс содержащий аргументы
    public class ColorEventArgs : EventArgs
    {
        public ColorEventArgs(string color)
        {
            Color = color;
        }

        public string Color;
    }

    public class Ford : Car
    {
        public string currentColor;
        
        //События
        public event EventHandler<ColorEventArgs> ColorChanged;

        protected virtual void OnColorChanged(ColorEventArgs e)
        {
            ColorChanged?.Invoke(this, e);//Invoke вызывает все подписанные события с параметрами которые есть в Invoke
        }

        public Ford(string name, List<string> colors, int horsePower, string carType, int cost) : base(name, Model.Ford,
            colors, horsePower, carType, cost)
        {
            currentColor = colors[0];
            ColorChanged += (s, e) =>
                Console.WriteLine($"Old color: {((Ford) s).currentColor}\nNew color: {e.Color}");
        }

        //Вызывает Event
        public void ChangeColor(int i)
        {
            OnColorChanged(new ColorEventArgs(Colors[i]));
        }
    }
}