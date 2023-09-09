using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GestionAdoptionEntite;

namespace GestionAdoptionDAL_SQLServerEF.DTO
{
    public class PersonneDTO
    {
        [Key]
        public int PersonneId { get; private set; } = 0;
        public string Nom { get; private set; } = "";
        public string Prenom { get; private set; } = "";
        public PersonneDTO(Personne p_personne)
        {
            if (p_personne is null)
            {
                throw new ArgumentNullException(nameof(p_personne));
            }
            PersonneId = p_personne.PersonneId;
            Nom = p_personne.Nom;
            Prenom = p_personne.Prenom;
        }

        public Personne VersEntite() 
        {
            Personne versPersonne = new Personne
                (
                    PersonneId,
                    Nom,
                    Prenom
                );
            return versPersonne;
        }
    }
}
