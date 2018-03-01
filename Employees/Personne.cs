using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Personne
    {
        /// <summary>
        /// Déclaration des attributs d'une personne
        /// </summary>
        string nom; // Nom d'une personne
        string prenom; // Prenom d'une personne
        DateTime date_naissance; // Date de naissance de la personne

        /// <summary>
        /// Propriété de l'attribut nom
        /// </summary>
        public String Nom {
            get { return nom; }
            set { nom = value; }
        }
        
        /// <summary>
        /// Propriété de l'attribut prenom
        /// </summary>
        public String Prenom {
            get { return prenom; }
            set { prenom = value; }
        }
        
        /// <summary>
        /// Propriété de l'attribut date_naissance
        /// </summary>
        public DateTime Date_naissance {
            get { return date_naissance; }
            set { date_naissance = value; }
        }
        
        /// <summary>
        /// Méthode Afficher de la classe Personne
        /// </summary>
        /// <returns></returns>
        public String Afficher (){
            return "Nom : " + this.nom + "\nPrenom : " + this.prenom + "Date_naissance : " + this.date_naissance.ToString();
        }

        /// <summary>
        /// Constructeur d'initialisation de la classe Personne
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="date_naissance"></param>
        public Personne(String nom, String prenom, DateTime date_naissance) {
            this.nom = nom;
            this.prenom = prenom;
            this.date_naissance = date_naissance;
        }

        /// <summary>
        /// Constructeur par défaut de la classe Personne
        /// </summary>
        public Personne() {
            this.nom = "";
            this.prenom = "";
            this.date_naissance = DateTime.Now;
        }

    }
}
