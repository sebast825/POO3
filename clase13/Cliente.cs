using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase13
{
    internal class Cliente
    {
        private int id { get; set; }
        private string nombre { get; set; }
        private string apellido { get; set; }

        public void SetId(int id)
        {
            this.id = id;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void SetApellido(string apellido)
        {
            this.apellido = apellido;
        }

        public int GetId() => this.id;

        public string GetNombre() => this.nombre;

        public string GetApellido() => this.apellido;

    }

    internal class Asociados
    {
        public List<Cliente> listaClientes { get; set; }

        public void AgregarCliente (Cliente datos)
        {

        }

    }

}