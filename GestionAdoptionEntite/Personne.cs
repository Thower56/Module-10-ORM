using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAdoptionEntite
{
    public class Personne
    {
        public Personne(int p_personneId, string p_nom, string p_prenom)
        {
            PersonneId = p_personneId;
            Nom = p_nom;
            Prenom = p_prenom;
        }
        public int PersonneId { get; private set; } = 0;
        public string Nom { get; private set; } = "";
        public string Prenom { get; private set; } = "";
        public override string ToString()
        {
            return $"Id: {PersonneId} - {Nom}, {Prenom} {Environment.NewLine} ";
        }
    }
}
