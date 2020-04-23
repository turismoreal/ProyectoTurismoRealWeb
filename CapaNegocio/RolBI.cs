using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato;

namespace CapaNegocio
{
    public class RolBI
    {
        private readonly RolDAL _rolBL = new RolDAL();

        public List<ROL> listarRoles()
        {
            return _rolBL.listarRoles();
        }

    }
}
