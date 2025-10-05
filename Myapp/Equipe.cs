namespace Myapp
{
    class Equipe
    {
        private string[] nom = new string[5];

        public string this[int index]
        {
            get { return nom[index]; }
            set{ nom[index] = value; }
        }
    }
}