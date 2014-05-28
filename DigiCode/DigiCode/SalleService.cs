using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace DigiCode
{
    class SalleService
    {
        public static IEnumerable<SalleEntity> LoadSalleList()
        {
            using (DbModelContainer ctx = new DbModelContainer())
            {
                return ctx.SalleEntityJeu.ToList();
            }
        }
    }
}
