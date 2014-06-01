﻿using System.Collections.Generic;
using System.Linq;

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
