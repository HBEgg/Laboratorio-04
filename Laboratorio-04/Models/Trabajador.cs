using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Laboratorio_04.Helpers;

namespace Laboratorio_04.Models
{
    public class Trabajador
    {
        public string Titulo { get; set; }
        public string Describetarea { get; set; }
        public string Proyecto { get; set; }
        public int Prioridad { get; set; }
        public int Entrega { get; set; }
        public string idTitulo;
        public string idtarea;
        public string idproyecto; 
        public int idprioridad;
        public int identrega; 
        public bool Save()
        {
            try
            {
                Storage.Instancia.ListaTrabajador.Add(this);
                return true;
            }
            catch
            {

                return false;
            }
        }

        public static implicit operator int(Trabajador v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator Trabajador(int v)
        {
            throw new NotImplementedException();
        }

        //public static implicit operator Trabajador(Trabajador v)
        //{
        //   throw new NotImplementedException();
        //}
    }
}