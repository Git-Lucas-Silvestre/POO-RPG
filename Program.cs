using System;
using JogoRPG.src.Entities;

namespace JogoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight hero = new Knight("Taivas", 23, "Knight", 230, 90);
            Whitewizard whitewizard = new Whitewizard("Cresnick", 23, "White Wizard", 140, 330);
            Ninja ninja = new Ninja("Reagen", 23, "White Wizard", 140, 330);
            Blackmage blackmage = new Blackmage("Mediana", 23, "White Wizard", 140, 330);

            Rat rat = new Rat("Rat", 5, "Beast", 30, 10);
            Wolf wolf = new Wolf("Wolf", 10, "Beast", 90, 50);
            Werewolf werewolf = new Werewolf("Werewolf", 30, "Humanoid", 300, 100);
            Chimera chimera = new Chimera("Chimera", 50, "Beast", 600, 150);
            Dragon dragon = new Dragon("Dragon", 60, "Dragon", 650, 400);

            Shadow shadow = new Shadow("Shadow", 30, "Beast", 350, 250);
            Dalahan dalahan = new Dalahan("Dalahan", 50, "Demon", 500, 300);
            Death death = new Death("Death", 90, "Undead", 1500, 900);
        

            Console.WriteLine(whitewizard.Support());
            Console.WriteLine(hero.Attack());
            Console.WriteLine(ninja.Attack());
            Console.WriteLine(blackmage.AttackSpecial());

        }
    }

}