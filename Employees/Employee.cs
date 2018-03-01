using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Employee : Personne
    {
        /// <summary>
        /// Déclaration des attributs de la classe Employee
        /// </summary>
        private double salaire; // Le salaire de l'employe

        /// <summary>
        /// Propriété de l'attribut salaire 
        /// </summary>
        public double Salaire {
            get { return salaire; }
            set { salaire = value; }
        }
        
        /// <summary>
        /// Redéfinition de la méthode Afficher
        /// </summary>
        /// <returns></returns>
        public String Afficher () {
            return base.Afficher()+"Salaire : "+this.salaire;
        }

        /// <summary>
        /// Constructeur d'initailisation de la calsse Employee
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="date_naissance"></param>
        /// <param name="salaire"></param>
        public Employee(String nom, String prenom, DateTime date_naissance, double salaire)
            : base(nom, prenom, date_naissance)
        {
            this.salaire = salaire;
        }

        /// <summary>
        /// Constructeur par défaut de la classe Employee
        /// </summary>
        public Employee() : base() {
            this.salaire = 0.0;
        }

    }
}
