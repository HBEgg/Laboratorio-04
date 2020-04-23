using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio_04.Models
{
    public class NodoColaI
    {
        public string Titulo;
        public string Describetarea;
        public string Proyecto;
        public string Fecha;
        public int Prioridad;
        public int Entrega;
        //public int izquierda;
        //public int derecha; 
        public NodoColaI Siguiente;

        public static implicit operator NodoColaI(int v)
        {
            throw new NotImplementedException();
        }
    }

}