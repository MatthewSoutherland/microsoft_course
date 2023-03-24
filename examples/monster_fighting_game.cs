using System;

Random dice = new Random();
int roll = dice.Next(1, 7);

int monsterHealth = 10;
int heroHealth = 10;

Console.WriteLine("Name your hero: ");
string name = Console.ReadLine();
Console.WriteLine("Ready to fight " + name + "!");
Console.WriteLine("");
bool herosTurn = true;

while (monsterHealth > 0 && heroHealth > 0)
{
    roll = dice.Next(1, 7);
    if (herosTurn)
    {
        monsterHealth -= roll;
        Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monsterHealth} health.");
        herosTurn = false;
    }
    else
    {
        heroHealth -= roll;
        Console.WriteLine($"{name} was damaged and lost {roll} health and now has {heroHealth} health.");
        herosTurn = true;
    }
    Thread.Sleep(1000);
}