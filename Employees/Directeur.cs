using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Directeur:Chef
    {
        /// <summary>
        /// Déclaration des attributs de la classe Chef
        /// </summary>
        String societe; // société du Directeur

        /// <summary>
        /// Propriété de l'attribut societe
        /// </summary>
        public String Societe {
            get { return societe; }
            set { societe = value; }
        }

        /// <summary>
        /// Constructeur d'initialisation de la classe Directeur
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="date_naissance"></param>
        /// <param name="salaire"></param>
        /// <param name="service"></param>
        /// <param name="societe"></param>
        public Directeur (String nom, String prenom, DateTime date_naissance, double salaire, String service, String societe): base(nom, prenom, date_naissance, salaire, service){
            this.societe = societe;
        }

        /// <summary>
        /// Constructeur par défaut de la classe Directeur
        /// </summary>
        /// <returns></returns>
        public String Afficher() {
            return base.Afficher() + "Société : " + this.societe;
        }
    }
}
