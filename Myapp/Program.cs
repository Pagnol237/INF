// See https://aka.ms/new-console-template for more information


using System.Runtime.CompilerServices;

Console.WriteLine("a partir de ce jour je reussi dans ce que j\'entreprend sigé franck pagnol");


IEnumerable<int> nbrPair()
{
    
    for (int i=1; i <= 10; i++)
    {
        if (i % 2 == 0)
        {
            yield return i;
        }
    }
}

foreach (int s in nbrPair())
{
    Console.WriteLine(s);
}

