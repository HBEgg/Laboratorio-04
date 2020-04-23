using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio_04.Models
{
    public class NodoColaII
    {
        // lo que se encuentra en la cola de prioridad 
        public int Prioridad;
        public string Titulo;
        public NodoColaII Sgte; 

    }
}