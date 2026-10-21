using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal_FP
{
    internal class Validaciones
    {
        public static bool CamposCompletos(string codigo,string dni,string nombre, string tramite)
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
        public static bool ValidarDNI(string dni)
        {
            if (dni.Length != 8)
            {
                return false;
            }
            for (int i = 0; i < dni.Length; i++)
            {
                if (!char.IsDigit(dni[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
