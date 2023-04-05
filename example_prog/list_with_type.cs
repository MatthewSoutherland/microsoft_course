using System;
using System.Collections;

var listOfCards = new List<Card>();
listOfCards.Add(new Card("A-d"));
listOfCards.Add(new Card("J-d"));
listOfCards.Add(new Card("9-c"));
listOfCards.Add(new Card("8-s"));

foreach (var item in listOfCards)
{
    Console.WriteLine(item);
}