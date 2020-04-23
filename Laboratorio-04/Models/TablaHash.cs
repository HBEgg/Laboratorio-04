//using C5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio_04.Models
{
    public class TablaHash
    {
        
        public int indice = 0;
        public List<Trabajador>[] HashArray = new List<Trabajador>[50]; 
        public TablaHash()
        {
            for (int i = 0; i <= 49; i++)
            {
                HashArray[i] = new List<Trabajador>(); 
            }
        }
        public void insHash(Trabajador value)
        {
            string key = value.Titulo;
            indice = FuncHash(key);
    //HashArray[indice].Insert(value, key);
        }
        public int FuncHash(string clave)
        {
            int longitud = clave.Length;
            int func = longitud % 10; 
            return func; 
        }
    }
}