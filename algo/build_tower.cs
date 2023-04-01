using System;

/* Build a pyramid-shaped tower, as an array/list of strings, given a positive integer 
number of floors. A tower block is represented with "*" character. */

static string[] TowerBuilder(int nFloors)
{
    string[] tower = new string[nFloors];
    string star = "*";
    int spaces = (nFloors * 2 - 1) / 2;
    string space = " ";
    for (int i = 0; i < tower.Length; i++)
    {

        for (int x = 0; x < spaces; x++)
        {
            tower[i] += space;
        }

        tower[i] += star;

        for (int y = 0; y < spaces; y++)
        {
            tower[i] += space;
        }

        Console.WriteLine(tower[i]);
        star += "*";
        star += "*";
        spaces--;
    }
    return tower;
}
TowerBuilder(6);

