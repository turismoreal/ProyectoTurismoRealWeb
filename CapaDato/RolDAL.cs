using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato
{
    public class RolDAL
    {
        private readonly TrealEntities db = new TrealEntities();

        public List<ROL> listarRoles()
        {
            var query = db.ROLs.ToList();

            return query;
        }
    }
}
