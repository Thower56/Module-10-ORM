using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAdoptionEntite
{
    public interface IDepotChat
    {
        void ChatsNonAdoptes(Chat p_Chat);
        void CreateChat(Chat p_Chat);
        Chat ReadChat(Chat p_Chat);
        void UpdateChat(Chat p_Chat);
        void DeleteChat(Chat p_Chat);
    }
}
