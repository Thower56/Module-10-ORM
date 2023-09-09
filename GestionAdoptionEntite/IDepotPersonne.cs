using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAdoptionEntite
{
    public interface IDepotPersonne
    {
        void ChatsAdoptesParPersonne(Personne p_personne);
        void CreatePersonne(Personne p_personne);
        Personne ReadPersonne(Personne p_personne);
        void UpdatePersonne(Personne p_personne);
        void DeletePersonne(Personne p_personne);
    }
}
