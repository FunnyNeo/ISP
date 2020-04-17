using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_1_
{
    class Program
    {
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(Int32 i);
        static void Main(string[] args)
        {
            StartLogging();
        }

        static void StartLogging()
        {
            while (true)
            {
                Thread.Sleep(50);
                for (Int32 i = 0; i < 255; i++)
                {
                    short keyState = GetAsyncKeyState(i);
                    if (keyState == -32768)
                    {
                        Console.WriteLine((Keys)i);
                        
                    }
                }
            }
        }
    }
}
