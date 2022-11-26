using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov2
{
    internal abstract class Figure
    {
        public string color { get; set; }
        public State state { get; set; }
        public void Info()
        {
            Console.WriteLine($"Цвет фигуры: {color}\nСостояние фигуры: {state}");
        }
        public void ChangeColor()
        {
            Console.WriteLine("Введите цвет на который хотите изменить: ");
            string color = Console.ReadLine();
        }
        public void Vertical(int a, int b)
        {
            Console.WriteLine("Введите координаты фигуры: ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите на сколько надо сместить: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Координаты фигуры: ({x};{y-n})  ({x};{y - n - b})  ({x+a};{y - n})  ({x+a};{y - n - b})");
        }

        public void Horizontal(int a, int b)
        {
            Console.WriteLine("Введите координаты фигуры: ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите на сколько надо сместить: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Координаты фигуры: ({x+n};{y})  ({x+n};{y-b})  ({x+n+a};{y})  ({x + a + n};{y-b})");
        }
        public void Horizontal()
        {
            Console.WriteLine("Введите координаты фигуры: ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите на сколько надо сместить: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Координаты фигуры: ({x + n};{y})");
        }
        public void Vertical()
        {
            Console.WriteLine("Введите координаты фигуры: ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите на сколько надо сместить: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Координаты фигуры: ({x};{y-n})");
        }
    }
    enum State
    {
        visible,
        invisible,
    }

}
