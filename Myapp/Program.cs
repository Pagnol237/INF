// See https://aka.ms/new-console-template for more information


using System.Runtime.CompilerServices;
using Myapp;

Equipe team = new Equipe();
var i = 0;

do
{
    Console.WriteLine($"saisir le nom du joueur -{i + 1}");
    string namejoueur = Console.ReadLine();
    team[i] = namejoueur;
    i++;
} while (i <5);

for (int x = 0; x < 5; x++)
{
    Console.WriteLine($"joueur {x + 1}:\t{team[x]}");
}

