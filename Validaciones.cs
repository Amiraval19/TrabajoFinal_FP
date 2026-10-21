using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal_FP
{
    internal class Validaciones
    {
        public static bool CamposCompletos(
            string codigo,
            string dni,
            string nombre,
            string tramite)
        {
            if (codigo.Trim() == "" ||
                dni.Trim() == "" ||
                nombre.Trim() == "" ||
                tramite.Trim() == "")
            {
                return false;
            }

            return true;
        }
    }
}
