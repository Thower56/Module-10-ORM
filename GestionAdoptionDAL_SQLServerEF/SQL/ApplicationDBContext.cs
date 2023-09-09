using GestionAdoptionDAL_SQLServerEF.DTO;
using GestionAdoptionEntite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAdoptionDAL_SQLServerEF.SQL
{
    internal class ApplicationDBContext : DbContext, ITransactionBD
    {
        private IDbContextTransaction? m_transaction;
        public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions) 
        {
            ;
        }

        public List<ChatDTO> ObtenirChatAdopter(int p_id)
        {
            return Chat.FromSqlRaw("Execute ObtenirChatAdopter {0};", p_id).ToList();
        }

        public List<ChatDTO> ObtenirChatNonAdopter()
        {
            return Chat.FromSqlRaw("Execute ObtenirChatNonAdopter;").ToList();
        }


        public DbSet<PersonneDTO> Personnes => Set<PersonneDTO>();
        public DbSet<ChatDTO> Chat => Set<ChatDTO>();
        public void BeginTransaction()
        {
            if (this.m_transaction is not null)
            {
                throw new InvalidOperationException("Une transaction est deja debutee");
            }
            this.m_transaction = this.Database.BeginTransaction();
        }

        public void Commit()
        {
            if (this.m_transaction is null)
            {
                throw new InvalidOperationException("Une transaction doit être débutée");
            }
            this.m_transaction.Commit();
            this.m_transaction?.Dispose();
            this.m_transaction = null;
        }

        public void Rollback()
        {
            if (this.m_transaction is null)
            {
                throw new InvalidOperationException("Une transaction doit être débutée");
            }
            this.m_transaction.Rollback();
            this.m_transaction?.Dispose();
            this.m_transaction = null;
        }

        public override void Dispose()
        {
            this.m_transaction?.Dispose();
            this.m_transaction = null;
            base.Dispose();
        }
    }
}
