using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork19._11._22
{
    
    internal class BigRace
    {
        public void Beach(ref List<Team> teams)
        {
            Console.WriteLine("Началась игра Пляж");
            Random random = new Random();

            int[] point = new int[4];
            for (int i = 0; i < 4; i++)
            {
                point[i] = random.Next(0, 5);
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 4; j++)
                {
                    if (point[i] > point[j])
                    {
                        int a = point[i];
                        point[i] = point[j];
                        point[j] = a;
                        string a1 = teams[i].Name;
                        teams[i].Name = teams[j].Name;
                        teams[j].Name = a1;
                    }
                }
            }
            int r = 0;
            int[] ints = new int[4];
            int k = 0;
            int l = 3;
            while (l != 0)
            {
                if (point[l] == point[l - 1])
                {
                    ints[k]++;
                    l--;
                }
                else
                {
                    k++;
                    l--;
                }
            }
            for (int i = 0; i < 4; ++i)
            {
                if (ints[i] == 1)
                {
                    r++;
                }
                if (ints[i] == 2)
                {
                    r += 2;
                }
                if (ints[i] == 3)
                {
                    r += 3;
                }
            }
            if (ints[0] == 0 && ints[1] == 0 && ints[2] == 0 && ints[3] == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine($"{i + 1} место заняла команда: ");
                    for (int j = 0; j <= 0; j++)
                    {
                        Console.WriteLine($"{teams[3 - i].Name}");
                        teams[3 - i].Points += 3 - i;
                    }
                }
            }
            else
            {

                int u = 0;
                for (int i = 0; i < 4 - r; k++)
                {
                    Console.WriteLine($"{++i} место заняла команда: ");
                    for (int j = 0; j <= ints[i]; j++)
                    {
                        Console.WriteLine($"{teams[3 - u].Name}");
                        teams[3 - u].Points += 3 - i + 1;
                        u++;
                    }
                }
            }

        }

        
        public void Mousetrap(ref List<Team> teams)
        {
            Console.WriteLine("Началась игра Мышеловка");
            Random random = new Random();

            int[] point = new int[4];
            for (int i = 0; i < 4; i++)
            {
                point[i] = random.Next(0, 5);
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 4; j++)
                {
                    if (point[i] > point[j])
                    {
                        int a = point[i];
                        point[i] = point[j];
                        point[j] = a;
                        string a1 = teams[i].Name;
                        teams[i].Name = teams[j].Name;
                        teams[j].Name = a1;
                    }
                }
            }
            int r = 0;
            int[] ints = new int[4];
            int k = 0;
            int l = 3;
            while (l != 0)
            {
                if (point[l] == point[l - 1])
                {
                    ints[k]++;
                    l--;
                }
                else
                {
                    k++;
                    l--;
                }
            }
            for (int i = 0; i < 4; ++i)
            {
                if (ints[i] == 1)
                {
                    r++;
                }
                if (ints[i] == 2)
                {
                    r += 2;
                }
                if (ints[i] == 3)
                {
                    r += 3;
                }
            }
            if (ints[0] == 0 && ints[1] == 0 && ints[2] == 0 && ints[3] == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine($"{i + 1} место заняла команда: ");
                    for (int j = 0; j <= 0; j++)
                    {
                        Console.WriteLine($"{teams[3 - i].Name}");
                        teams[3 - i].Points += 3 - i;
                    }
                }
            }
            else
            {

                int u = 0;
                for (int i = 0; i < 4 - r; k++)
                {
                    Console.WriteLine($"{++i} место заняла команда: ");
                    for (int j = 0; j <= ints[i]; j++)
                    {
                        Console.WriteLine($"{teams[3 - u].Name}");
                        teams[3 - u].Points += 3 - i + 1;
                        u++;
                    }
                }
            }
        }
        public void Sea(ref List<Team> teams)
        {
            Console.WriteLine("Началась игра Море");
            Random random = new Random();

            int[] point = new int[4];
            for (int i = 0; i < 4; i++)
            {
                point[i] = random.Next(0, 5);
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 4; j++)
                {
                    if (point[i] > point[j])
                    {
                        int a = point[i];
                        point[i] = point[j];
                        point[j] = a;
                        string a1 = teams[i].Name;
                        teams[i].Name = teams[j].Name;
                        teams[j].Name = a1;
                    }
                }
            }
            int r = 0;
            int[] ints = new int[4];
            int k = 0;
            int l = 3;
            while (l != 0)
            {
                if (point[l] == point[l - 1])
                {
                    ints[k]++;
                    l--;
                }
                else
                {
                    k++;
                    l--;
                }
            }
            for (int i = 0; i < 4; ++i)
            {
                if (ints[i] == 1)
                {
                    r++;
                }
                if (ints[i] == 2)
                {
                    r += 2;
                }
                if (ints[i] == 3)
                {
                    r += 3;
                }
            }
            if (ints[0] == 0 && ints[1] == 0 && ints[2] == 0 && ints[3] == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine($"{i + 1} место заняла команда: ");
                    for (int j = 0; j <= 0; j++)
                    {
                        Console.WriteLine($"{teams[3 - i].Name}");
                        teams[3 - i].Points += 3 - i;
                    }
                }
            }
            else
            {

                int u = 0;
                for (int i = 0; i < 4 - r; k++)
                {
                    Console.WriteLine($"{++i} место заняла команда: ");
                    for (int j = 0; j <= ints[i]; j++)
                    {
                        Console.WriteLine($"{teams[3 - u].Name}");
                        teams[3 - u].Points += 3 - i + 1;
                        u++;
                    }
                }
            }
        }
        public void Fishing(ref List<Team> teams)
        {
            Console.WriteLine("Началась игра Рыбалка");
            Random random = new Random();

            int[] point = new int[4];
            for (int i = 0; i < 4; i++)
            {
                point[i] = random.Next(0, 5);
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 4; j++)
                {
                    if (point[i] > point[j])
                    {
                        int a = point[i];
                        point[i] = point[j];
                        point[j] = a;
                        string a1 = teams[i].Name;
                        teams[i].Name = teams[j].Name;
                        teams[j].Name = a1;
                    }
                }
            }
            int r = 0;
            int[] ints = new int[4];
            int k = 0;
            int l = 3;
            while (l != 0)
            {
                if (point[l] == point[l - 1])
                {
                    ints[k]++;
                    l--;
                }
                else
                {
                    k++;
                    l--;
                }
            }
            for (int i = 0; i < 4; ++i)
            {
                if (ints[i] == 1)
                {
                    r++;
                }
                if (ints[i] == 2)
                {
                    r += 2;
                }
                if (ints[i] == 3)
                {
                    r += 3;
                }
            }
            if (ints[0] == 0 && ints[1] == 0 && ints[2] == 0 && ints[3] == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine($"{i + 1} место заняла команда: ");
                    for (int j = 0; j <= 0; j++)
                    {
                        Console.WriteLine($"{teams[3 - i].Name}");
                        teams[3 - i].Points += 3 - i;
                    }
                }
            }
            else
            {

                int u = 0;
                for (int i = 0; i < 4 - r; k++)
                {
                    Console.WriteLine($"{++i} место заняла команда: ");
                    for (int j = 0; j <= ints[i]; j++)
                    {
                        Console.WriteLine($"{teams[3 - u].Name}");
                        teams[3 - u].Points += 3 - i + 1;
                        u++;
                    }
                }
            }
        }
        public void Postman(ref List<Team> teams)
        {
            Console.WriteLine("Началась игра Почтальоны");
            Random random = new Random();

            int[] point = new int[4];
            for (int i = 0; i < 4; i++)
            {
                point[i] = random.Next(0, 5);
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 4; j++)
                {
                    if (point[i] > point[j])
                    {
                        int a = point[i];
                        point[i] = point[j];
                        point[j] = a;
                        string a1 = teams[i].Name;
                        teams[i].Name = teams[j].Name;
                        teams[j].Name = a1;
                    }
                }
            }
            int r = 0;
            int[] ints = new int[4];
            int k = 0;
            int l = 3;
            while (l != 0)
            {
                if (point[l] == point[l - 1])
                {
                    ints[k]++;
                    l--;
                }
                else
                {
                    k++;
                    l--;
                }
            }
            for (int i = 0; i < 4; ++i)
            {
                if (ints[i] == 1)
                {
                    r++;
                }
                if (ints[i] == 2)
                {
                    r += 2;
                }
                if (ints[i] == 3)
                {
                    r += 3;
                }
            }
            if (ints[0] == 0 && ints[1] == 0 && ints[2] == 0 && ints[3] == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine($"{i + 1} место заняла команда: ");
                    for (int j = 0; j <= 0; j++)
                    {
                        Console.WriteLine($"{teams[3 - i].Name}");
                        teams[3 - i].Points += 3 - i;
                    }
                }
            }
            else
            {

                int u = 0;
                for (int i = 0; i < 4 - r; k++)
                {
                    Console.WriteLine($"{++i} место заняла команда: ");
                    for (int j = 0; j <= ints[i]; j++)
                    {
                        Console.WriteLine($"{teams[3 - u].Name}");
                        teams[3 - u].Points += 3 - i + 1;
                        u++;
                    }
                }
            }
        }
        public void Hill(ref List<Team> teams)
        {
            Console.WriteLine("Началась игра Горка");
            Random random = new Random();

            int[] point = new int[4];
            for (int i = 0; i < 4; i++)
            {
                point[i] = random.Next(0, 5);
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 4; j++)
                {
                    if (point[i] > point[j])
                    {
                        int a = point[i];
                        point[i] = point[j];
                        point[j] = a;
                        string a1 = teams[i].Name;
                        teams[i].Name = teams[j].Name;
                        teams[j].Name = a1;
                    }
                }
            }
            int r = 0;
            int[] ints = new int[4];
            int k = 0;
            int l = 3;
            while (l != 0)
            {
                if (point[l] == point[l - 1])
                {
                    ints[k]++;
                    l--;
                }
                else
                {
                    k++;
                    l--;
                }
            }
            for (int i = 0; i < 4; ++i)
            {
                if (ints[i] == 1)
                {
                    r++;
                }
                if (ints[i] == 2)
                {
                    r += 2;
                }
                if (ints[i] == 3)
                {
                    r += 3;
                }
            }
            if (ints[0] == 0 && ints[1] == 0 && ints[2] == 0 && ints[3] == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine($"{i + 1} место заняла команда: ");
                    for (int j = 0; j <= 0; j++)
                    {
                        Console.WriteLine($"{teams[3 - i].Name}");
                        teams[3 - i].Points += 3 - i;
                    }
                }
            }
            else
            {

                int u = 0;
                for (int i = 0; i < 4 - r; k++)
                {
                    Console.WriteLine($"{++i} место заняла команда: ");
                    for (int j = 0; j <= ints[i]; j++)
                    {
                        Console.WriteLine($"{teams[3 - u].Name}");
                        teams[3 - u].Points += 3 - i + 1;
                        u++;
                    }
                }
            }
        }
        public void RockPaperScissors(ref List<Team> teams)
        {
            Console.WriteLine("Началась игра Камень ножницы бумага");
            Random random = new Random();

            int[] point = new int[4];
            for (int i = 0; i < 4; i++)
            {
                point[i] = random.Next(0, 4);
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 4; j++)
                {
                    if (point[i] > point[j])
                    {
                        int a = point[i];
                        point[i] = point[j];
                        point[j] = a;
                        string a1 = teams[i].Name;
                        teams[i].Name = teams[j].Name;
                        teams[j].Name = a1;
                    }
                }
            }
            int r = 0;
            int[] ints = new int[4];
            int k = 0;
            int l = 3;
            while (l != 0)
            {
                if (point[l] == point[l - 1])
                {
                    ints[k]++;
                    l--;
                }
                else
                {
                    k++;
                    l--;
                }
            }
            for (int i = 0; i < 4; ++i)
            {
                if (ints[i] == 1)
                {
                    r++;
                }
                if (ints[i] == 2)
                {
                    r += 2;
                }
                if (ints[i] == 3)
                {
                    r += 3;
                }
            }
            if (ints[0] == 0 && ints[1] == 0 && ints[2] == 0 && ints[3] == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine($"{i + 1} место заняла команда: ");
                    for (int j = 0; j <= 0; j++)
                    {
                        Console.WriteLine($"{teams[3 - i].Name}");
                        teams[3 - i].Points += 3 - i;
                    }
                }
            }
            else
            {

                int u = 0;
                for (int i = 0; i < 4 - r; k++)
                {
                    Console.WriteLine($"{++i} место заняла команда: ");
                    for (int j = 0; j <= ints[i]; j++)
                    {
                        Console.WriteLine($"{teams[3 - u].Name}");
                        teams[3 - u].Points += 3 - i + 1;
                        u++;
                    }
                }
            }
        }

        
    }
}
