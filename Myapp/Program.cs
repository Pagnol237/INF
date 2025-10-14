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

            foreach(var item in number)
            {
                Console.WriteLine(item);
            }
        }
    }

    
}