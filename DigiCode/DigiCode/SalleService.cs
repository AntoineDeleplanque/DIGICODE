using System;
using System.Collections.Generic;
using System.Linq;

namespace DigiCode
{
    class SalleService
    {
        public static IEnumerable<SalleEntity> LoadSalleList()
        {
            using (DbModelContainer ctx = new DbModelContainer())
            {
                var salles = ctx.SalleEntityJeu.ToList();

                foreach (var salle in salles)
                {
                    if (DateTime.Compare(salle.LastUpdate.AddMonths(1), DateTime.Now) >= 0)
                    {
                        salle.ResetCode();
                    }
                }

                return salles;
            }
        }
    }
}
