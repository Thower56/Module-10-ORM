using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAdoptionEntite
{
    public class Chat
    {
        public Chat(int p_chatId, string p_nom, string p_proprietaire, DateTime dateAdoption)
        {
            ChatId = p_chatId;
            Nom = p_nom;
            Proprietaire = p_proprietaire;
        }
        public int ChatId { get; private set; } = 0;
        public string Nom { get; private set; } = "";
        public string? Proprietaire { get; set; } = ""; 
        public DateTime DateAdoption { get; set; }
    }
}
