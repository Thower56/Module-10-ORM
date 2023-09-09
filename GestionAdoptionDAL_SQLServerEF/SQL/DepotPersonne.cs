using GestionAdoptionDAL_SQLServerEF.DTO;
using GestionAdoptionDAL_SQLServerEF.SQL;
using GestionAdoptionEntite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAdoptionDAL_SQLServerEF
{
    internal class DepotPersonne : IDepotPersonne
    {
        private readonly ApplicationDBContext m_dbContext;

        public void ChatsAdoptesParPersonne(Personne p_personne)
        {
            m_dbContext.ObtenirChatAdopter(p_personne.PersonneId);
        }

        public void CreatePersonne(Personne p_personne)
        {
            m_dbContext.Add(new PersonneDTO(p_personne));
            m_dbContext.SaveChanges();
        }

        public void DeletePersonne(Personne p_personne)
        {
            m_dbContext.Remove(new PersonneDTO(p_personne));
            m_dbContext.SaveChanges();
        }

        public Personne ReadPersonne(Personne p_personne)
        {
            PersonneDTO personneDTO = m_dbContext.Personnes.Where(p => p.PersonneId == p_personne.PersonneId).SingleOrDefault();

            return personneDTO.VersEntite();
        }

        public void UpdatePersonne(Personne p_personne)
        {
            PersonneDTO personneDTO = m_dbContext.Personnes.Where(p => p.PersonneId == p_personne.PersonneId).SingleOrDefault();
            if (personneDTO is null)
            {
                throw new ArgumentNullException(nameof(p_personne));
            }

            m_dbContext.Update(p_personne);
            m_dbContext.SaveChanges();

        }
    }
}
