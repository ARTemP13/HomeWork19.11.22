using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork19._11._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во команд");
            int n = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            BigRace race = new BigRace();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите название команды: ");
                string str = Console.ReadLine();    
                Team team = new Team(str);
                teams.Add(team);
            }
            
            race.Beach(ref teams);
            Console.WriteLine(teams[0].Name + " = " + teams[0].Points + "\n "+ teams[1].Name + " = " + teams[1].Points + "\n " + teams[2].Name + " = " + teams[2].Points + "\n " + teams[3].Name + " = " + teams[3].Points);
            race.Mousetrap(ref teams);
            race.Sea(ref teams);
            race.Hill(ref teams);
            race.RockPaperScissors(ref teams);
            race.Postman(ref teams);
            race.Fishing(ref teams);

            Console.WriteLine($"Первое место: {teams[3].Name} с {teams[3].Points} баллами\nВторое место: {teams[2].Name} с {teams[2].Points} баллами\nТретье место: {teams[1].Name} с {teams[1].Points} баллами\nЧетвертое место: {teams[0].Name} с {teams[0].Points} баллами");
            Console.WriteLine("Игра закончена!");


            Console.ReadLine();
        }
    }
}
