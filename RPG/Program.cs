using System;
namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight","Steel", 50);
            Wizard wizard  = new Wizard("Jenica", 4, "Wizard", "Leather", 20);
            Assassin assassin = new Assassin("Gero", 12, "Assassin", "Leather", 35);
            Healer healer = new Healer("Anuka", 5, "Healer", "Cloth", 18);
            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack(4));
            Console.WriteLine(assassin.Attack(7));
            Console.WriteLine(healer.Attack());
        }
    }
}
