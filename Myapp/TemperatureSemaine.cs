/*
Exercice 1 : Gestion d’un tableau de températures

Crée une classe TemperatureSemaine qui permet de stocker les températures quotidiennes d’une semaine (7 jours).

Consignes :

Déclare un tableau privé de 7 éléments pour stocker les températures en degrés Celsius.

Ajoute un indexeur pour permettre d’accéder et de modifier la température d’un jour à partir d’un index (0 pour lundi, 6 pour dimanche).

Dans le programme principal :

Crée un objet TemperatureSemaine.

Demande à l’utilisateur d’entrer les 7 températures.

Affiche toutes les températures de la semaine à l’aide d’une boucle et de l’indexeur.
*/

namespace Myapp
{
    class TemperatureSemaine
    {
        private double[] temperature = new double[7];

        public double this[int index]
        {
            get { return temperature[index]; }
            set{ temperature[index] = value; }
        }
    }
}