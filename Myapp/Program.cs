// See https://aka.ms/new-console-template for more information


using System.Runtime.CompilerServices;

namespace Myapp
{
    public class Program

    {

        public delegate void MyDeleg(string msg);
        public static void MyFonc (string message)
        {
            Console.WriteLine(message);
        }
        public static void Main(string[] arg)
        {
            /* MyDeleg del1 = MyFonc;
             MyDeleg del2 = x => { Console.Write(" le milliadaire"); };
             MyDeleg del3 = del1 + del2;
             del3("Franck pagnol");
             */

            /*
                exercice: Pour une série de nombres entiers dans une
                liste,
                – Implémenter une λ permettant de trier le tableau
                de manières croissante et décroissante. (utiliser
                Sort).

            */

            List<int> number = new List<int>();

            number.Add(20);
            number.Add(7);
            number.Add(8);
            number.Add(48);
            number.Add(354);
            number.Add(34);

            number.Sort((a, b) =>
            {
                if (a % 2 == 0 && b % 2 != 0) return -1;
                if (a % 2 != 0 && b % 2 == 0) return 1;
                return 0;
            });
            foreach (var item in number)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"le nombre d'element de la liste est {number.Count()}");


            /*
                Pour une List d’objets Etudiant,
            – utiliser Where pour filtrer uniquement des
            étudiants dont le nom commence par « a » ou
            « A ».

            */

            List<string> user = new List<string>();

            user.Add("franck");
            user.Add("Adele");
            user.Add("gigi");
            user.Add("andorphine");
            user.Add("alice");


            var listeA = user.Where(str => str[0] == 'a' || str[0] == 'A');
            

            foreach(var nom in listeA){
                Console.WriteLine(nom);
            }







        }
    }

    
}