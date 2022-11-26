using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            ACipher aCipher = new ACipher();
            Console.WriteLine("Введите строку которую хотите зашифровать: ");
            string str1 = Console.ReadLine();
            string enstr1 = aCipher.encode(str1);
            Console.WriteLine($"Зашифрованная надпись: {enstr1}");
            string destr1 = aCipher.decode(enstr1);
            Console.WriteLine($"Расшифрованная надпись: {destr1}");

            BCipher bCipher = new BCipher();
            Console.WriteLine("Введите строку которую хотите зашифровать: ");
            string str2 = Console.ReadLine();
            string enstr2 = bCipher.encode(str2);
            Console.WriteLine($"Зашифрованная надпись: {enstr2}");
            string destr2 = bCipher.decode(enstr2);
            Console.WriteLine($"Расшифрованная надпись: {destr2}");

            Console.ReadKey();
        }
    }
}
