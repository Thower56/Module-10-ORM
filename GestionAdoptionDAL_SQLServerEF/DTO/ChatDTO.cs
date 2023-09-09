using GestionAdoptionEntite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GestionAdoptionDAL_SQLServerEF.DTO
{
    public class ChatDTO
    {
        [Key]
        public int ChatId { get; private set; } = 0;
        public string Nom { get; private set; } = "";
        public string? Proprietaire { get; set; } = "";
        public DateTime DateAdoption { get; set; }
        public ChatDTO(Chat p_chat)
        {
            ChatId = p_chat.ChatId;
            Nom = p_chat.Nom;
            Proprietaire = p_chat.Proprietaire;
            DateAdoption = p_chat.DateAdoption;
        }

        public Chat VersEntite()
        {
            Chat versChat = new Chat
            (
                ChatId,
                Nom,
                Proprietaire,
                DateAdoption
            );

            return versChat;
        }
        
    }
}
