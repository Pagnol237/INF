// See https://aka.ms/new-console-template for more information


using System.Runtime.CompilerServices;

Console.WriteLine("a partir de ce jour je reussi dans ce que j\'entreprend sigé franck pagnol");


// exercice 1 : Crée une méthode qui utilise yield pour retourner tous les nombres pairs entre 1 et 100.Teste-la avec un foreach.


static IEnumerable<int> Range (int a,int b)
{
    for (int i = a; i <= b; i++)
    {
        if (i % 2 == 0)
        {
            yield return i;
        }
    }
}

foreach (int items in Range(1, 100))
{
    Console.WriteLine("-" + items);
}

// exercice 2 : Écris une méthode qui prend une phrase en entrée et qui retourne, avec yield, chaque mot séparément.

static IEnumerable<string> mots (string texte)
{
    string[] liste = texte.Split(' ');
    foreach (string world in liste)
    {
        yield return world;
    }
}

string myText = " bonjour je m'apple nounjo djomini franck et je serrais milliadaire et le meilleur dans tous ce que je vais entreprendre des aujourdhuis";

foreach (string mot in mots(myText))
{
    Console.WriteLine("-" + mot);
}

//Exercice 3 
Console.WriteLine("\nentrez le nombre de joueur");
int nbrJoueurs = Convert.ToInt32(Console.ReadLine());
string[] liste_joueurs = new string[nbrJoueurs];

int i = 0;
do
{

    Console.WriteLine("entrez le nom du joueur" + (i + 1));
    string nom_Joueur = Console.ReadLine();
    liste_joueurs[i] = nom_Joueur;
    i++;


} while (i != nbrJoueurs);

Console.WriteLine("\nListe des Joueur\n=============");
foreach (string item in liste_joueurs)
{
    Console.WriteLine("-" + item);
}

