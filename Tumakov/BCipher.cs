using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov
{
    internal class BCipher : ICipher
    {
        public string decode(string str)
        {
            Console.Write("Введите ключ расшифрования: ");
            int key = int.Parse(Console.ReadLine());

            char[] letter = str.ToCharArray();
            for (int i = 0; i < str.Length; i++)
            {
                
                for(int j = 0; j < key; j++)
                {
                    if (letter[i] == ' ')
                    {
                        continue;
                    }
                    if (letter[i] == 'a' || letter[i] == 'а')
                    {
                        if (letter[i] == 'a')
                        {
                            letter[i] = 'z';
                        }
                        else
                        {
                            letter[i] = 'я';
                        }
                        continue;

                    }
                    if (letter[i] == 'A' || letter[i] == 'А')
                    {
                        if (letter[i] == 'A')
                        {
                            letter[i] = 'Z';
                        }
                        else
                        {
                            letter[i] = 'Я';
                        }
                        continue;

                    }

                    letter[i]--;
                }
                

            }
            string s = new string(letter);
            return s;
        }

        public string encode(string str)
        {
            Console.Write("Введите ключ шифрования: ");
            int key = int.Parse(Console.ReadLine());


            char[] letter = str.ToCharArray();
            for (int i = 0; i < str.Length; i++)
            {
                
                for(int j = 0; j < key; j++)
                {

                    if (letter[i] == ' ')
                    {
                        continue;
                    }
                    if (letter[i] == 'z' || letter[i] == 'я')
                    {
                        if (letter[i] == 'z')
                        {
                            letter[i] = 'a';
                        }
                        else
                        {
                            letter[i] = 'а';
                        }
                        continue;
                    }
                    if (letter[i] == 'Z' || letter[i] == 'Я')
                    {
                        if (letter[i] == 'Z')
                        {
                            letter[i] = 'A';
                        }
                        else
                        {
                            letter[i] = 'А';
                        }
                        continue;
                    }
                    letter[i]++;
                }
            }
            string s = new string(letter);
            return s;
        }
    }
}
