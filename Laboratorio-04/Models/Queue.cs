using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio_04.Models
{
    public class Queue
    {
        public NodoColaI Primero;
        public NodoColaI Ultimo; 

        public Queue()
        {
            Primero = null;
            Ultimo = null;
        }
        public void Push(string titulo, string descripcion, string proyecto, int prioridad, int entrega)
        {
            NodoColaI auxiliar = new NodoColaI
            {
                Titulo = titulo,
                Describetarea = descripcion,
                Proyecto = proyecto,
                Prioridad = prioridad,
                Entrega = entrega
            };
            if(Empty(Primero))
            {
                Primero = auxiliar; 
            }
            else
            {
                Ultimo.Siguiente = auxiliar;
            }
            Primero = auxiliar;

        }
        //public NodoColaI Sacar()
        //{
        //    NodoColaI auxilii = new NodoColaI
        //    {
        //        Titulo = Primero.Titulo,
        //        Describetarea = Primero.Describetarea,
        //        Proyecto = Primero.Proyecto,
        //        Prioridad = Primero.Prioridad,
        //        Entrega = Primero.Entrega
        //    };
        //}
        public NodoColaI Peek(NodoColaI valor)
        {
            if (valor.Siguiente != null)
            {
                return valor.Siguiente; 
            }
            else
            {
                return null; 
            }
        }
        private bool Empty(NodoColaI primero)
        {
            return (primero == null) ? true : false;  //obtener el valor si es o no un numero nulo o verificar si existe

            throw new NotImplementedException();
        }
    }
}