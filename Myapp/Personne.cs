namespace Myapp
{
    public class Personne
    {
        public string Nom
        {
            get { return Nom; }
            set{ Nom = value; }
        }
        public int Age
        {
            get { return Age; }
            set { if (Age > 0) Age = value; }
        }
        public string Ville
        {
            get { return Ville; }
            set { Ville = value; }
        }

        public void afficher()
        {
            Console.WriteLine($"Nom:\t{Nom}\nAge:\t{Age}\nVille:\t{Ville}");
        }
    }
}