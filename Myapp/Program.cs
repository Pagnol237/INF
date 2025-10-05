// See https://aka.ms/new-console-template for more information


using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Myapp;


Console.WriteLine("a partir de ce jour je reussi dans ce que j\'entreprend sigé franck pagnol");


// chapitre 3

CompteBancaire cout1 = new CompteBancaire("NOUF27369500","franck pagnol",10000000000000);
CompteBancaire cout2 = new CompteBancaire("NMF27365651", "manuella forturne", 10000000000000);

cout2.Retirer(2586000000);

cout1.AfficherInfos();
Console.WriteLine("----------");
cout2.AfficherInfos();
Console.WriteLine("====================================");

Personne user1 = new Personne();
Personne user2 = new Personne();

user1.Nom = "Franck Pagnol Nounjo Djomini";
user1.Age = 29;
user1.Ville = "Trois riviere";

user2.Nom = "";
user2.Age = 27;
user2.Ville = "moscou";
user1.afficher();
Console.WriteLine("====================================");
user2.afficher();

