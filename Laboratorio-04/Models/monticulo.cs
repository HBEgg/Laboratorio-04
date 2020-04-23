using C5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio_04.Models
{
    public class monticulo
    {
        public class Monticulo<T> : CollectionValueBase<T>, IPriorityQueue<T>
        {
            private struct IntervaloH
            {
                internal T primero, ultimo;
                //internal Handle? primerohandle, ultimohandle;
                public override string ToString()
                {
                    return string.Format("[{0}; {1}]", primero, ultimo); 
                }
            }
            //public void cambioFWL(int casilla, int casilla2)
            //{
            //    T first = 
            //}
            public T this[IPriorityQueueHandle<T> handle] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public override bool IsEmpty => throw new NotImplementedException();

            public override int Count => throw new NotImplementedException();

            public override Speed CountSpeed => throw new NotImplementedException();

            public IComparer<T> Comparer => throw new NotImplementedException();

            public bool IsReadOnly => throw new NotImplementedException();

            public bool AllowsDuplicates => throw new NotImplementedException();

            public IEqualityComparer<T> EqualityComparer => throw new NotImplementedException();

            public bool DuplicatesByCounting => throw new NotImplementedException();

            public bool Add(ref IPriorityQueueHandle<T> handle, T item)
            {
                throw new NotImplementedException();
            }

            public bool Add(T item)
            {
                throw new NotImplementedException();
            }

            public void AddAll(IEnumerable<T> items)
            {
                throw new NotImplementedException();
            }

            public bool Check()
            {
                throw new NotImplementedException();
            }

            public override T Choose()
            {
                throw new NotImplementedException();
            }

            public T Delete(IPriorityQueueHandle<T> handle)
            {
                throw new NotImplementedException();
            }

            public T DeleteMax()
            {
                throw new NotImplementedException();
            }

            public T DeleteMax(out IPriorityQueueHandle<T> handle)
            {
                throw new NotImplementedException();
            }

            public T DeleteMin()
            {
                throw new NotImplementedException();
            }

            public T DeleteMin(out IPriorityQueueHandle<T> handle)
            {
                throw new NotImplementedException();
            }

            public bool Find(IPriorityQueueHandle<T> handle, out T item)
            {
                throw new NotImplementedException();
            }

            public T FindMax()
            {
                throw new NotImplementedException();
            }

            public T FindMax(out IPriorityQueueHandle<T> handle)
            {
                throw new NotImplementedException();
            }

            public T FindMin()
            {
                throw new NotImplementedException();
            }

            public T FindMin(out IPriorityQueueHandle<T> handle)
            {
                throw new NotImplementedException();
            }

            public override IEnumerator<T> GetEnumerator()
            {
                throw new NotImplementedException();
            }

            public T Replace(IPriorityQueueHandle<T> handle, T item)
            {
                throw new NotImplementedException();
            }
        }
    }
}