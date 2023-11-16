using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase13
{
    internal interface IConexion
    {
        DataTable ListarResultados(string query);
        int Modificar(string query);
    }
}