namespace Myapp
{
    public class Voiture
    {
   
        public string Marque { get; set; }
        public int Annee { get; set; }

        public Voiture(string Marque, int Annee)
        {
            Marque = Marque;
            Annee = Annee;
        }

        public void afficher()
        {
            Console.WriteLine($"marque : {Marque},\nannee:{Annee}");
        }
    }
}