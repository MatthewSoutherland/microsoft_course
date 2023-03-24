// See https://aka.ms/new-console-template for more information

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);
int bonus = 0;
int total = roll1 + roll2 + roll3;

if ((roll1 == roll2) || (roll1 == roll3) || (roll2 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples! Bonus six points.");
        bonus += 6;
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles! Bonus two points.");
        bonus += 2;
        total += 2;
    }
}


Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} + Bonus: {bonus} = {total}");

if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new labtop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip!");
}
else
{
    Console.WriteLine("You suck balls!!!");
}