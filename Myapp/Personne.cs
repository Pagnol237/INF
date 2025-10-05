namespace Myapp
{
    public class Personne

    {

        private string _nom;
        private int _age;
        private string _ville;
        public string Nom
        {
            get { return _nom; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("etrez un nom valide");
                }
                else { _nom = value; }
            }
        }
        public int Age
        {
            get { return _age; }
            set { if (value > 0) _age = value; }
        }
        public string Ville
        {
            get { return _ville; }
            set { _ville = value; }
        }

        public void afficher()
        {
            Console.WriteLine($"Nom:\t{Nom}\nAge:\t{Age}\nVille:\t{Ville}");
        }
    }
}

