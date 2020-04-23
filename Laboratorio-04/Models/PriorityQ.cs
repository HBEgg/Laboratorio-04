using EO.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio_04.Models
{
    public class PriorityQ
    {
        public List<Trabajador>[] HashArray = new List<Trabajador>[50];
        public List<Trabajador>[] ListaTrabajador = new List<Trabajador>[50];
        public NodoColaII Primero;
        public NodoColaII Ultimo;
        
        public PriorityQ()
        {
            Primero = null;
            Ultimo = null;
        }
        public NodoColaII Sacar()
        {
            NodoColaII Auxiliar = new NodoColaII
            {
                Prioridad = Primero.Prioridad,
                Titulo = Primero.Titulo

            };
            Primero = Primero.Sgte;
            return Auxiliar; 
        }
        public void Push(string titulo, int prioridad)
        {
            NodoColaII auxiliar = new NodoColaII
            {
                Prioridad = prioridad,
                Titulo = titulo,
                Sgte = null
            };
            if (Vacio(Primero))
            {
                Primero = auxiliar;
            }
            else
            {
                Ultimo.Sgte = auxiliar;
            }
            Ultimo = auxiliar; 
        }
        public void Heap(int prioridad, string titulo, PriorityQ nuevo)
        {
            Push(titulo, prioridad);
            PriorityQ nvoaux = new PriorityQ();
            NodoColaII ultimo;
            while (nuevo.Primero.Sgte != null)
            {
                if (nuevo.Primero.Sgte != null)
                {
                    NodoColaII auxiliarI;
                    auxiliarI = nuevo.Sacar();
                    nvoaux.Push(auxiliarI.Titulo, auxiliarI.Prioridad);
                }
            }
        }
        public void maxHeap(int[] t, int n, int posicion)  //Trabajador []t ,int n
        {
            //NodoColaII izquierda = new NodoColaII(); 
            int izquierda = ((posicion + 1) * 2) - 1;
            int derecha = ((posicion + 1) * 2);
            int mayor = 0;
            if (izquierda < tamaño && t[izquierda] > t[posicion])
            {
                mayor = izquierda; 
            }
            else
            {
                mayor = posicion; 
            }
            if (derecha < tamaño && t[derecha] > t[mayor])
            {
                mayor = derecha; 
            }
            if (mayor != posicion)
            {
                int mientras = t[posicion];
                t[posicion] = t[mayor];
                t[mayor] = mientras;
                maxHeap(t, n, posicion);
            }

            //for (int i = n/2; i >0; --i)
            //{
            //    hundir(t, n, i); 
            //}
        }

        internal static NodoColaI Mostrar(List<Trabajador>[] trabajadors)
        {
            throw new NotImplementedException();
        }

        internal static NodoColaI Mostrar(object p, object prioridad)
        {
            throw new NotImplementedException();
        }

        //private Intervalo[] heap;
        private int tamaño;
        private object prioridad;

        public void Swap(int l1, int l2)
        {
            NodoColaII primero;
            NodoColaII ultimo;
            //Primero = heap[l1].; 

        }
        public void Heapsort(int[] arreglo)
        {
            int tam = arreglo.Length;
            for (int i = (tam -1)/2; i >=0; i--)
            {
                maxHeap(arreglo, tam, i);
            }
            for (int j = arreglo.Length -1; j >0; j--)
            {
                int temporal = arreglo[j];
                arreglo[j] = arreglo[0];
                arreglo[0] = temporal;
                tam--;
                maxHeap(arreglo, tam, 0);
            }
        }
        //public void MetodoSort()
        //{
        //    List<Trabajador>[] trabajadors = new List<Trabajador>[20];
        //    Mostrar(trabajadors);
        //    Console.WriteLine("----");
        //    Heapsort(trabajadors);
        //    ListaTrabajador = Mostrar(int[],prioridad); 
        //}

        private void Heapsort(List<Trabajador>[] trabajadors)
        {
            throw new NotImplementedException();
        }

        private void maxHeap(List<Trabajador>[] trabajadors, int tam, int i)
        {
            throw new NotImplementedException();
        }

        public static void Mostrar(int []Arreglo)
        {
            for (int l = 0; l < Arreglo.Length; l++)
            {
                Console.WriteLine("{0}", Arreglo[l]);
                Console.ReadLine(); 
            }
        }

       // public void swapI()
        //private void Primero(string titulo, int prioridad)
        //{
        //    throw new NotImplementedException();
        //}

        private bool Vacio(NodoColaII primero)
        {
            return (primero == null) ? true : false; 
            throw new NotImplementedException();
        }

    }
}
