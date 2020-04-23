using Laboratorio_04.Models;
using Laboratorio_04.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio_04.Helpers
{
    public class Storage
    {
        private static Storage _instancia = null;

        public static Storage Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new Storage();
                }
                return _instancia;
            }
        }
        public List<Trabajador> ListaTrabajador = new List<Trabajador>();
    }
}