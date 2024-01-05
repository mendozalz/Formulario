using Formulario.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario.Datos
{
    public  class Usuario
    {
        List<UsuarioModel> lista = new List<UsuarioModel>();

        /// <summary>
        /// Guarda los usuario  
        /// </summary>
        /// <param name="model">guarda los datos de los usuarios</param>
        public void Guardar(UsuarioModel model){
            lista.Add(model);
        }
        /// <summary>
        /// COnsulta todos lo usuario
        /// </summary>
        /// <returns>datos de los usuarios</returns>
        public List<UsuarioModel> Consultar(){
            return lista;
        }
    }
}
