using System;
using System.Collections.Generic;
using System.Data.Common.EntitySql;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace DigiCode
{
    partial class SalleEntity
    {
        public void SetUnamedSalle(string Libelle)
        {
            if (this.Libelle == null)
            {
                this.Libelle = Libelle;
            }
        }

        public void ResetCode()
        {
            using (var DbModelContainer = new DbModelContainer())
            {
                DbModelContainer.SalleEntityJeu.Find(this.ID).Code = null;
                DbModelContainer.SaveChanges();
            }
        }
    }
}
