namespace Myapp
{
    public class CompteBancaire
    {
        private string _numeroCompte;
        private string _titulaire;
        private double _solde;

        public CompteBancaire(string numeroCompte, string titulaire, double solde)
        {
            this._numeroCompte = numeroCompte;
            this._titulaire = titulaire;
            this._solde = solde;
        }

        public void AfficherInfos()
        {
            Console.WriteLine($"Infos\n*****\nNum:\t{_numeroCompte}\nNom:\t{_titulaire}\nSolde:\t{_solde}");
        }

        public void Deposer(double montan)
        {
            this._solde += montan;
            
        }

        public void Retirer(double montan)
        {
            if (this._solde > montan)
            {
                this._solde -= montan;
            }
            else
            {
                Console.WriteLine("montan du retrait supperieur a vos avoir ");
            }
        }


    }


}