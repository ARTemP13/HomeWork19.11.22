using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ширину прямоугольника: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите длину прямоугольника: ");
            int a = int.Parse(Console.ReadLine());
            Rectangle r = new Rectangle(a,b);
            Console.Write("Введите цвет: ");
            r.color = Console.ReadLine();
            Console.Write("Введите visible/invisible: ");
            string h = Console.ReadLine();
            if(h == "visible")
            {
                r.state = State.visible;
            }
            else
            {
                r.state = State.invisible;
            }


            Console.Write("Введите радиус круга: ");
            double R = double.Parse(Console.ReadLine());
            Circle circle = new Circle();
            Console.Write("Введите цвет: ");
            circle.color = Console.ReadLine();
            Console.Write("Введите visible/invisible: ");
            string h1 = Console.ReadLine();
            if (h1 == "visible")
            {
                circle.state = State.visible;
            }
            else
            {
                circle.state = State.invisible;
            }

            circle.ChangeColor();
            r.Vertical(a,b);
            circle.Horizontal();
            r.Info();
            circle.Info();
            circle.Scircle(R);
            r.Srectangle(a, b);







        }
    }
}
