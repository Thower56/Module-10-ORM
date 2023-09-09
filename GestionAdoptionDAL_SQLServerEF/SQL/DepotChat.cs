using GestionAdoptionDAL_SQLServerEF.DTO;
using GestionAdoptionEntite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAdoptionDAL_SQLServerEF.SQL
{
    internal class DepotChat : IDepotChat
    {
        private readonly ApplicationDBContext m_dbContext;

        public void ChatsNonAdoptes(Chat p_Chat)
        {
            m_dbContext.ObtenirChatAdopter(p_Chat.ChatId);
        }

        public void CreateChat(Chat p_Chat)
        {
            m_dbContext.Add(new ChatDTO(p_Chat));
            m_dbContext.SaveChanges();
        }

        public void DeleteChat(Chat p_Chat)
        {
            m_dbContext.Remove(new ChatDTO(p_Chat));
            m_dbContext.SaveChanges();
        }

        public Chat ReadChat(Chat p_Chat)
        {
            ChatDTO ChatDTO = m_dbContext.Chat.Where(c => c.ChatId == p_Chat.ChatId).SingleOrDefault();

            return ChatDTO.VersEntite();
        }

        public void UpdateChat(Chat p_Chat)
        {
            ChatDTO chatDTO = m_dbContext.Chat.Where(p => p.ChatId == p_Chat.ChatId).SingleOrDefault();
            if (chatDTO is null)
            {
                throw new ArgumentNullException(nameof(p_Chat));
            }
            m_dbContext.Update(chatDTO);
            m_dbContext.SaveChanges();

        }
    }
}
