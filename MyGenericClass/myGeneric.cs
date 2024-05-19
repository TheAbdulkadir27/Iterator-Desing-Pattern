using System;
using System.Collections;
using System.Collections.Generic;

namespace MyGenericClass
{
    public class myGeneric<T> : IEnumerable<T> where T : struct
    {
        private int next = default(int);
        private T[] array;
        public myGeneric() => array = new T[1];
        public myGeneric(int count) => array = new T[count];
        public int Count => array.Length;
        public void Add(T item)
        {
        backto:
            if (next < array.Length)
            {
                array[next++] = item;
            }
            else
            {
                //Array.Resize(array.Length, 10); 
                this.Resize(ref array, array.Length + 1); //My Generic Method
                goto backto;
            }
        }
        public void Resize<T>(ref T[] array, int length) where T : struct
        {
            T[] newarray = new T[length];
            for (int i = 0; i < array.Length; i++)
            {
                newarray[i] = array[i];
            }
            array = newarray;
            newarray = null;
            GC.Collect();
        }
        public T this[int index]
        {
            get { return array[index]; }
            set { value = array[index]; }
        }
        public IEnumerator<T> GetEnumerator() => new MygenericSpecification<T>(array);
        IEnumerator IEnumerable.GetEnumerator() => new MygenericSpecification<T>(array);
    }
}
