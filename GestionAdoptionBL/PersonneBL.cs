using GestionAdoptionEntite;

namespace GestionAdoptionEntite
{
    public class PersonneBL 
    {
        IDepotPersonne m_DepotPersonne;

        PersonneBL(IDepotPersonne p_depotPersonne)
        {
            m_DepotPersonne = p_depotPersonne;
        }
    }
}