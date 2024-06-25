using Exo08.Models;

Deck d1 = new Deck();
d1.Initialize();

Console.WriteLine("Deck initialisé :");
Console.WriteLine("*****************");
foreach(Card card in d1.Cards!)
{
    Console.WriteLine($" - {card.GetInfo()}");
}
Console.WriteLine();

d1.Shuffle();
Console.WriteLine("Deck Mélangé 1 :");
Console.WriteLine("*****************");
foreach (Card card in d1.Cards!)
{
    Console.WriteLine($" - {card.GetInfo()}");
}