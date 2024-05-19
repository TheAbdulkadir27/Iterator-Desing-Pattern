using System;
using System.Collections;
using System.Collections.Generic;
namespace MyGenericClass
{
    public class MygenericSpecification<T> : IEnumerator<T> where T : struct
    {
        int next = 0;
        private readonly T[] _array;
        public MygenericSpecification(T[] array) => _array = array;
        public T Current => _array[next++];
        object IEnumerator.Current => Current;
        public void Dispose() => GC.SuppressFinalize(this);
        public bool MoveNext() => next < _array.Length;

        public void Reset() => next = 0;
    }
}
