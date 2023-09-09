using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAdoptionEntite
{
    public class GestionAdoptionsBL
    {
        public IDepotChat m_DepotChat;
        public IDepotPersonne m_DepotPersonne;

        GestionAdoptionsBL(IDepotChat p_DepotChat, IDepotPersonne p_DepotPersonne)
        {
            m_DepotChat = p_DepotChat;
            m_DepotPersonne = p_DepotPersonne;
        }
    }
}
