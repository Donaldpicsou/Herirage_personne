using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
      /// <summary>
      /// PErmet d'insérer nb personne dans un tableau de Personne à partir de la position begin
      /// </summary>
      /// <param name="personne"></param>
      /// <param name="begin"></param>
      /// <param name="nb"></param>
        public static void insertPersonne(Personne[] personne, int begin, int nb) {
            Console.Out.WriteLine("Inserction de " + (nb) + " personnes");
            for (int i = begin; i < nb+begin; i++) {
                Console.WriteLine("Donner les informations de la personne N° " + (i - begin + 1));
                Console.Write("Nom : "); 
                String nom = Console.ReadLine();
                Console.Write("Prénoms : ");
                String prenom = Console.ReadLine();
                DateTime date = DateTime.Now;
                personne[i] = new Personne(nom, prenom, date);
            }
            Console.WriteLine("Insertion terminée...\n Tapez sur une touche pour continuer ...");
            Console.Read();
            System.Console.Clear();
        }


        /// <summary>
        /// PErmet d'insérer nb Employé dans un tableau de Personne à partir de la position begin
        /// </summary>
        /// <param name="personne"></param>
        /// <param name="begin"></param>
        /// <param name="nb"></param>
        public static void insertEmploye(Personne[] personne, int begin, int nb)
        {
            Console.Out.WriteLine("Inserction de " + (nb) + " employés");
            for (int i = begin; i < nb+ begin; i++)
            {
                Console.WriteLine("Donner les informations de l'employé N° " + (i - begin + 1));
                Console.Write("Nom : ");
                String nom = Console.ReadLine();
                Console.Write("Prénoms : ");
                String prenom = Console.ReadLine();
                DateTime date = DateTime.Now;
                Console.Write("Salaire : ");
                double salaire = Double.Parse(Console.ReadLine());
                personne[i] = new Employee(nom, prenom, date, salaire);
            }

            Console.WriteLine("Insertion terminée...\n Tapez sur une touche pour continuer ...");
            Console.Read();
            System.Console.Clear();
            Console.Read();
        }

        /// <summary>
        /// PErmet d'insérer nb chefs dans un tableau de Personne à partir de la position begin
        /// </summary>
        /// <param name="personne"></param>
        /// <param name="begin"></param>
        /// <param name="nb"></param>
        public static void insertChef(Personne[] personne, int begin, int nb)
        {
            Console.Out.WriteLine("Inserction de " + (nb) + " Chefs");
            for (int i = begin; i < nb + begin; i++)
            {
                Console.WriteLine("Donner les informations du chef N° " + (i - begin + 1));
                Console.Write("Nom : ");
                String nom = Console.ReadLine();
                Console.Write("Prénoms : ");
                String prenom = Console.ReadLine();
                DateTime date = DateTime.Now;
                Console.Write("Salaire : ");
                double salaire = Double.Parse(Console.ReadLine());
                Console.Write("Service : ");
                String service = Console.ReadLine();
                personne[i] = new Chef(nom, prenom, date, salaire, service);
            }
            Console.WriteLine("Insertion terminée...\n Tapez sur une touche pour continuer ...");
            Console.Read();
            System.Console.Clear();
            Console.Read();
        }

        /// <summary>
        /// PErmet d'insérer nb directeur dans un tableau de Personne à partir de la position begin
        /// </summary>
        /// <param name="personne"></param>
        /// <param name="begin"></param>
        /// <param name="nb"></param>
        public static void insertDirecteur(Personne[] personne, int begin, int nb)
        {
            Console.Out.WriteLine("Inserction de " + (nb) + " Directeur(s)");
            for (int i = begin; i < begin +nb; i++)
            {
                Console.WriteLine("Donner les informations du Directeur N° " + (i - begin + 1));
                Console.Write("Nom : ");
                String nom = Console.ReadLine();
                Console.Write("Prénoms : ");
                String prenom = Console.ReadLine();
                DateTime date = DateTime.Now;
                Console.Write("Salaire : ");
                double salaire = Double.Parse(Console.ReadLine());
                Console.Write("Service : ");
                String service = Console.ReadLine();
                Console.Write("Société : ");
                String societe = Console.ReadLine();
                personne[i] = new Directeur(nom, prenom, date, salaire, service, societe);
            }
            Console.WriteLine("Insertion terminée...\n Tapez sur une touche pour continuer ...");
            Console.Read();
            System.Console.Clear();
            Console.Read();
        }
        
        static void Main(string[] args)
        {
            Personne[] personnes = new Personne[8];
            insertEmploye(personnes, 0, 5);
            insertChef(personnes, 5, 2);
            insertDirecteur(personnes, 7, 1);
            for (int i = 0; i < personnes.Length; i++) {
                System.Console.Out.WriteLine(personnes[i].Afficher());
            }
            Console.Read();
            Console.Read();

        }
    }
}
