using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Chef : Employee
    {
        /// <summary>
        /// Déclaration des attributs de la classe Chef
        /// </summary>
        private String service; // Le service du chef
        
        /// <summary>
        /// Propriété de l'attribut service
        /// </summary>
        public String Service{
            get { return service; }
            set { service = value; }
        }

        /// <summary>
        /// Redéfintion de la méthode afficher
        /// </summary>
        /// <returns></returns>
        public String Afficher() {
            return base.Afficher() + " Service : " + this.service;
        }

        /// <summary>
        /// Constructeur d'initialisation de la classe Chef
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="date_naissane"></param>
        /// <param name="salaire"></param>
        /// <param name="service"></param>
        public Chef(String nom, String prenom, DateTime date_naissane, double salaire, String service)
            : base(nom, prenom, date_naissane, salaire)
        {
            this.service = service;
        }

        /// <summary>
        /// Constructeur par défaut de la clase Chef
        /// </summary>
        public Chef() : base() {
            this.service = "";
        }
    }
}
